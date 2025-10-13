using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace _1150080083_lab5
{
    public partial class Form3 : Form
    {
        private SqlConnection sqlCon = null;

        
        private readonly string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\DBConnect.mdf;
              Integrated Security=True;Connect Timeout=30";

        public Form3()
        {
            InitializeComponent();
        }

        // ===== Helpers mở/đóng kết nối =====
        private void MoKetNoi()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
        }
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open) sqlCon.Close();
        }

        // ===== Load danh sách mã lớp vào combobox (Lop: MaLop, TenLop) =====
        private void HienThiDSMaLop()
        {
            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand("SELECT MaLop, TenLop FROM Lop", sqlCon))
                using (var r = cmd.ExecuteReader())
                {
                    cbMaLop.Items.Clear();
                    while (r.Read())
                    {
                        string ma = r.GetString(0);
                        string ten = r.IsDBNull(1) ? "" : r.GetString(1);
                        cbMaLop.Items.Add($"{ma} - {ten}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message);
            }
            finally { DongKetNoi(); }
        }

        // ===== Hiển thị SV theo mã lớp đã chọn =====
        private void HienThiDSSinhVienTheoLop(string maLop)
        {
            try
            {
                MoKetNoi();
                string sql = "SELECT MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop " +
                             "FROM SinhVien WHERE MaLop='" + maLop.Replace("'", "''") + "'";
                using (var cmd = new SqlCommand(sql, sqlCon))
                using (var r = cmd.ExecuteReader())
                {
                    lsvDanhSach.Items.Clear();
                    while (r.Read())
                    {
                        var item = new ListViewItem(r["MaSV"].ToString());
                        item.SubItems.Add(r["TenSV"].ToString());
                        item.SubItems.Add(r["GioiTinh"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(r["NgaySinh"]).ToString("dd/MM/yyyy"));
                        item.SubItems.Add(r["QueQuan"].ToString());
                        item.SubItems.Add(r["MaLop"].ToString());
                        lsvDanhSach.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị SV theo lớp: " + ex.Message);
            }
            finally { DongKetNoi(); }
        }

        // ===== Form Load =====
        private void Form3_Load(object sender, EventArgs e)
        {
            HienThiDSMaLop();
        }

        // ===== Chọn lớp -> load DS SV =====
        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaLop.SelectedIndex == -1) return;
            var parts = cbMaLop.SelectedItem.ToString().Split('-');
            string maLop = parts[0].Trim();
            HienThiDSSinhVienTheoLop(maLop);
            btnSuaThongTin.Enabled = false;
        }

        // ===== Chọn 1 dòng SV -> đổ vào control bên phải =====
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0)
            {
                btnSuaThongTin.Enabled = false;
                return;
            }

            var lvi = lsvDanhSach.SelectedItems[0];
            txtMaSV.Text = lvi.SubItems[0].Text;
            txtTenSV.Text = lvi.SubItems[1].Text;
            cbGioiTinh.SelectedItem = lvi.SubItems[2].Text;
            // dd/MM/yyyy
            if (DateTime.TryParse(lvi.SubItems[3].Text, out DateTime d))
                dtpNgaySinh.Value = d;
            txtQueQuan.Text = lvi.SubItems[4].Text;
            txtMaLop.Text = lvi.SubItems[5].Text;

            btnSuaThongTin.Enabled = true;
        }

        // ===== Nút Sửa (KHÔNG Parameter) =====
        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string tenSV = txtTenSV.Text.Trim();
            string gioiTinh = cbGioiTinh.SelectedItem?.ToString() ?? "";
            string ngaySinh = dtpNgaySinh.Value.ToString("yyyy/MM/dd");
            string queQuan = txtQueQuan.Text.Trim();
            string maLop = txtMaLop.Text.Trim();

            if (string.IsNullOrWhiteSpace(maSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa (Mã SV).");
                return;
            }

            
            string sql = "UPDATE SinhVien SET " +
                         "TenSV = N'" + tenSV.Replace("'", "''") + "', " +
                         "GioiTinh = N'" + gioiTinh.Replace("'", "''") + "', " +
                         "NgaySinh = CAST('" + ngaySinh + "' AS DATETIME), " +
                         "QueQuan = N'" + queQuan.Replace("'", "''") + "', " +
                         "MaLop = N'" + maLop.Replace("'", "''") + "' " +
                         "WHERE MaSV = N'" + maSV.Replace("'", "''") + "'";

            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand(sql, sqlCon))
                {
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        HienThiDSSinhVienTheoLop(maLop);
                    }
                    else MessageBox.Show("Không có bản ghi nào được cập nhật.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật bị lỗi: " + ex.Message);
            }
            finally { DongKetNoi(); }
        }
    }
}

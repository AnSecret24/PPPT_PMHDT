using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1150080083_lab5
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlCon = null;

        // ✅ Kết nối SQL trực tiếp tại đây
        private readonly string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=E:\CNTT\Hoc_ki_7_2025\Phuong_phat_trien_phan_mem_huong_doi_tuong\BTtuan6\1150080083_lab5\1150080083_lab5\DBConnect.mdf;
              Integrated Security=True;
              Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");

            if (lsvDanhSachSV.Columns.Count == 0)
            {
                lsvDanhSachSV.View = View.Details;
                lsvDanhSachSV.FullRowSelect = true;
                lsvDanhSachSV.Columns.Add("Mã SV", 90);
                lsvDanhSachSV.Columns.Add("Tên SV", 150);
                lsvDanhSachSV.Columns.Add("Giới tính", 70);
                lsvDanhSachSV.Columns.Add("Ngày sinh", 90);
                lsvDanhSachSV.Columns.Add("Quê quán", 140);
                lsvDanhSachSV.Columns.Add("Mã lớp", 80);
            }

            HienThiDanhSach();
        }

        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        private void HienThiDanhSach()
        {
            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand("SELECT MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop FROM SinhVien", sqlCon))
                using (var reader = cmd.ExecuteReader())
                {
                    lsvDanhSachSV.Items.Clear();
                    while (reader.Read())
                    {
                        string maSv = reader.GetString(0);
                        string tenSv = reader.GetString(1);
                        string gioiTinh = reader.GetString(2);
                        string ngaySinh = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                        string queQuan = reader.IsDBNull(4) ? "" : reader.GetString(4);
                        string maLop = reader.IsDBNull(5) ? "" : reader.GetString(5);

                        var lvi = new ListViewItem(maSv);
                        lvi.SubItems.Add(tenSv);
                        lvi.SubItems.Add(gioiTinh);
                        lvi.SubItems.Add(ngaySinh);
                        lvi.SubItems.Add(queQuan);
                        lvi.SubItems.Add(maLop);
                        lsvDanhSachSV.Items.Add(lvi);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string tenSV = txtTenSV.Text.Trim();
            string gioiTinh = cbGioiTinh.SelectedItem?.ToString() ?? "";
            string ngaySinhSql = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            string queQuan = txtQueQuan.Text.Trim();
            string maLop = txtMaLop.Text.Trim();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(tenSV) || string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("Mã SV, Tên SV và Giới tính là bắt buộc.");
                return;
            }

            string sql =
                "INSERT INTO SinhVien(MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop) " +
                "VALUES (N'" + maSV.Replace("'", "''") + "', " +
                        "N'" + tenSV.Replace("'", "''") + "', " +
                        "N'" + gioiTinh.Replace("'", "''") + "', " +
                        "'" + ngaySinhSql + "', " +
                        "N'" + queQuan.Replace("'", "''") + "', " +
                        "N'" + maLop.Replace("'", "''") + "')";

            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand(sql, sqlCon))
                {
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm sinh viên thành công!");
                        HienThiDanhSach();
                    }
                    else
                    {
                        MessageBox.Show("Không có bản ghi nào được thêm.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu bị lỗi: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

    }
}

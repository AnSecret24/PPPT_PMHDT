using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1150080083_lab5   
{
    public partial class Form2 : Form
    {
        private SqlConnection sqlCon = null;


        private readonly string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\DBConnect.mdf;
              Integrated Security=True;Connect Timeout=30";

        public Form2()
        {
            InitializeComponent();
            if (cbGioiTinh.Items.Count == 0)
            {
                cbGioiTinh.Items.Add("Nam");
                cbGioiTinh.Items.Add("Nữ");
            }
            HienThiDanhSach();
        }

        private void MoKetNoi()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
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
                using (var cmd = new SqlCommand(
                    "SELECT MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop FROM SinhVien", sqlCon))
                using (var r = cmd.ExecuteReader())
                {
                    lsvDanhSach.Items.Clear();
                    while (r.Read())
                    {
                        var it = new ListViewItem(r["MaSV"].ToString());
                        it.SubItems.Add(r["TenSV"].ToString());
                        it.SubItems.Add(r["GioiTinh"].ToString());
                        it.SubItems.Add(Convert.ToDateTime(r["NgaySinh"]).ToString("dd/MM/yyyy"));
                        it.SubItems.Add(r["QueQuan"].ToString());
                        it.SubItems.Add(r["MaLop"].ToString());
                        lsvDanhSach.Items.Add(it);
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

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string tenSV = txtTenSV.Text.Trim();
            string gioiTinh = cbGioiTinh.SelectedItem?.ToString() ?? "";
            DateTime ngaySinh = dtpNgaySinh.Value.Date;
            string queQuan = txtQueQuan.Text.Trim();
            string maLop = txtMaLop.Text.Trim();

            if (string.IsNullOrWhiteSpace(maSV) ||
                string.IsNullOrWhiteSpace(tenSV) ||
                string.IsNullOrWhiteSpace(gioiTinh))
            {
                MessageBox.Show("Mã SV, Tên SV, Giới tính là bắt buộc.");
                return;
            }

            const string sql = @"
                INSERT INTO SinhVien (MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop)
                VALUES (@MaSV, @TenSV, @GioiTinh, @NgaySinh, @QueQuan, @MaLop);";

            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand(sql, sqlCon))
                {
                    cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 20).Value = maSV;
                    cmd.Parameters.Add("@TenSV", SqlDbType.NVarChar, 100).Value = tenSV;
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 5).Value = gioiTinh;
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ngaySinh;
                    cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 100).Value =
                        string.IsNullOrWhiteSpace(queQuan) ? (object)DBNull.Value : queQuan;
                    cmd.Parameters.Add("@MaLop", SqlDbType.NVarChar, 20).Value =
                        string.IsNullOrWhiteSpace(maLop) ? (object)DBNull.Value : maLop;

                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm sinh viên thành công (Parameter)!");
                        HienThiDanhSach();
                        ClearInputs();
                    }
                }
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("Mã SV đã tồn tại. Vui lòng chọn mã khác.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void ClearInputs()
        {
            txtMaSV.Clear();
            txtTenSV.Clear();
            cbGioiTinh.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Today;
            txtQueQuan.Clear();
            txtMaLop.Clear();
            txtMaSV.Focus();
        }
    }
}

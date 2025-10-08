using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab4_WinformKetNoiCSDL
{
    public partial class Form1 : Form
    {
        
        string strCon = @"Data Source=DESKTOP-G007UO8\MSSQLSERVER01;Initial Catalog=QuanLySinhVien_Lab4;Integrated Security=True";
        SqlConnection sqlCon = null;
        private object reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMoKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null) sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                {
                    sqlCon.Open();
                    MessageBox.Show("Kết nối thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void btnDongKetNoi_Click(object sender, EventArgs e)
        {
            if (sqlCon != null && sqlCon.State == System.Data.ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Đã đóng kết nối!");
            }
            else
            {
                MessageBox.Show("Chưa tạo kết nối!");
            }
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();

            var maSV = txtNhapMaSV.Text.Trim();
            if (string.IsNullOrWhiteSpace(maSV))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!");
                return;
            }

            using (var cmd = new SqlCommand("SELECT * FROM SINHVIEN WHERE MaSV=@maSV", sqlCon))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@maSV", maSV);

                using (var r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        txtTenSV.Text = r.GetString(1);
                        txtGioiTinh.Text = r.GetString(2);
                        txtNgaySinh.Text = r.GetDateTime(3).ToString("dd/MM/yyyy");
                        txtQueQuan.Text = r.GetString(4);
                        txtMaLop.Text = r.GetString(5);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên!");
                        txtTenSV.Clear(); 
                        txtGioiTinh.Clear(); 
                        txtNgaySinh.Clear();
                        txtQueQuan.Clear(); 
                        txtMaLop.Clear();
                    }
                    
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

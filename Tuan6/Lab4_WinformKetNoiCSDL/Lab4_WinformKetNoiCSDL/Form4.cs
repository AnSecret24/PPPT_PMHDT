using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab4_WinformKetNoiCSDL
{
    public partial class Form4 : Form
    {
        
        private string strCon = @"Data Source=DESKTOP-G007UO8\MSSQLSERVER01;Initial Catalog=QuanLySinhVien_Lab4;Integrated Security=True";
        private SqlConnection sqlCon = null;

        public Form4()
        {
            InitializeComponent();
        }

        private void EnsureOpen()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
        }

        
        private string MapTenKhoaToMa(string tenKhoa)
        {
            tenKhoa = tenKhoa.Trim();
            if (tenKhoa.Equals("Công nghệ thông tin", StringComparison.OrdinalIgnoreCase)) return "CNTT";
            if (tenKhoa.Equals("Cơ khí", StringComparison.OrdinalIgnoreCase)) return "CK";
            if (tenKhoa.Equals("Điện tử", StringComparison.OrdinalIgnoreCase)) return "DT";
            if (tenKhoa.Equals("Kinh tế", StringComparison.OrdinalIgnoreCase)) return "KT";
            return string.Empty;
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            try
            {
                EnsureOpen();

                string tenKhoa = txtNhapTenKhoa.Text.Trim();
                string maKhoa = MapTenKhoaToMa(tenKhoa);
                if (string.IsNullOrEmpty(maKhoa))
                {
                    MessageBox.Show("Tên khoa không hợp lệ. Nhập: Công nghệ thông tin / Cơ khí / Điện tử / Kinh tế.");
                    return;
                }

                lsvDanhSach.Items.Clear();

                using (var cmd = new SqlCommand("SELECT * FROM LOP WHERE MaKhoa=@maKhoa", sqlCon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@maKhoa", SqlDbType.Char) { Value = maKhoa });

                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            string maLop = r.GetString(0);  
                            string tenLop = r.GetString(1);  

                            var lvi = new ListViewItem(tenLop);
                            lvi.SubItems.Add(maLop);
                            lsvDanhSach.Items.Add(lvi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try { if (sqlCon != null && sqlCon.State == ConnectionState.Open) sqlCon.Close(); } catch { }
            base.OnFormClosing(e);
        }
    }
}

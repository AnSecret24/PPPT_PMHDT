using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab4_WinformKetNoiCSDL
{
    public partial class Form5 : Form
    {
        private string strCon = @"Data Source=DESKTOP-G007UO8\MSSQLSERVER01;Initial Catalog=QuanLySinhVien_Lab4;Integrated Security=True";
        private SqlConnection sqlCon = null;

        public Form5()
        {
            InitializeComponent();
        }

        private void EnsureOpen()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            try
            {
                EnsureOpen();

                string maLop = txtMaLop.Text.Trim();
                if (string.IsNullOrEmpty(maLop))
                {
                    MessageBox.Show("Vui lòng nhập mã lớp (ví dụ: CNTT1, CK1, KT1...)");
                    return;
                }

                lsvSinhVien.Items.Clear();

                
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM SinhVien WHERE MaLop = @MaLop";
                cmd.Connection = sqlCon;
                cmd.Parameters.Add(new SqlParameter("@MaLop", SqlDbType.Char) { Value = maLop });

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maSV = reader.GetString(0);
                    string tenSV = reader.GetString(1);
                    string gioiTinh = reader.GetString(2);
                    string ngaySinh = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    string queQuan = reader.GetString(4);
                    string maL = reader.GetString(5);

                    ListViewItem lvi = new ListViewItem(maSV);
                    lvi.SubItems.Add(tenSV);
                    lvi.SubItems.Add(gioiTinh);
                    lvi.SubItems.Add(ngaySinh);
                    lvi.SubItems.Add(queQuan);
                    lvi.SubItems.Add(maL);

                    lsvSinhVien.Items.Add(lvi);
                }
                reader.Close();
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

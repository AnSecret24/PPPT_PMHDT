using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab4_WinformKetNoiCSDL
{
    public partial class Form3 : Form
    {
        
        string strCon = @"Data Source=DESKTOP-G007UO8\MSSQLSERVER01;Initial Catalog=QuanLySinhVien_Lab4;Integrated Security=True";
        SqlConnection sqlCon = null;

        public Form3()
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

        private void btnListView_Click(object sender, EventArgs e)
        {
            try
            {
                EnsureOpen();

                
                lsvList.Items.Clear();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM SINHVIEN", sqlCon))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maSV = reader.GetString(0);
                            string tenSV = reader.GetString(1);
                            string gioiTinh = reader.GetString(2);
                            string ngaySinh = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                            string queQuan = reader.GetString(4);
                            string maLop = reader.GetString(5);

                            ListViewItem lvi = new ListViewItem(maSV);
                            lvi.SubItems.Add(tenSV);
                            lvi.SubItems.Add(gioiTinh);
                            lvi.SubItems.Add(ngaySinh);
                            lvi.SubItems.Add(queQuan);
                            lvi.SubItems.Add(maLop);
                            lsvList.Items.Add(lvi);
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
            try { if (sqlCon != null && sqlCon.State == ConnectionState.Open) sqlCon.Close(); }
            catch { }
            base.OnFormClosing(e);
        }
    }
}

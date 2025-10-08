using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_WinformKetNoiCSDL
{
    public partial class Form2 : Form
    {
        string strCon = @"Data Source=DESKTOP-G007UO8\MSSQLSERVER01;Initial Catalog=QuanLySinhVien_Lab4;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            
            {
                try
                {
                    if (sqlCon == null)
                        sqlCon = new SqlConnection(strCon);
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();

                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "SELECT COUNT(*) FROM SINHVIEN";
                    sqlCmd.Connection = sqlCon;

                    int soLuongSV = (int)sqlCmd.ExecuteScalar();
                    MessageBox.Show("Số lượng sinh viên là: " + soLuongSV,
                                    "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}

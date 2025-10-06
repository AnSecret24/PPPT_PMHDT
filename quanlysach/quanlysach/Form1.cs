using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace quanlysach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnMoKetNoi_Click(object sender, EventArgs e)
        {
            // code ở đây
        }
        // Chuỗi kết nối
        string strCon = @"Data Source=DESKTOP-G007UO8\MSSQLSERVER01;Initial Catalog=QL_SACH_SIMPLE;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

        // Đối tượng kết nối
        SqlConnection sqlCon = null;


    }
}

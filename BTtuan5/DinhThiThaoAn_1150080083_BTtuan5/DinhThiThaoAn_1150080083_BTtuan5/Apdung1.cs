using System;
using System.Windows.Forms;

namespace DinhThiThaoAn_1150080083_BTtuan5
{
    public partial class Apdung1 : Form
    {
        public Apdung1()
        {
            InitializeComponent();
            if (txtKetQua != null) txtKetQua.ReadOnly = true;
        }

        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        private int BCNN(int a, int b)
        {
            return Math.Abs(a * b) / UCLN(a, b);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtA.Text.Trim());
                int b = Convert.ToInt32(txtB.Text.Trim());

                if (radUSCLN.Checked)
                    txtKetQua.Text = "USCLN = " + UCLN(a, b);
                else if (radBSCNN.Checked)
                    txtKetQua.Text = "BSCNN = " + BCNN(a, b);
                else
                    MessageBox.Show("Vui lòng chọn USCLN hoặc BSCNN!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?",
                                "Xác nhận thoát",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // —— Stubs để tránh lỗi “does not contain a definition for …” ——
        private void txtKetQua_TextChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void txtA_TextChanged(object sender, EventArgs e) { }
        private void txtB_TextChanged(object sender, EventArgs e) { }
        private void radUSCLN_CheckedChanged(object sender, EventArgs e) { }
        private void radBSCNN_CheckedChanged(object sender, EventArgs e) { }
        private void groupBox3_Enter(object sender, EventArgs e) { }
    }
}

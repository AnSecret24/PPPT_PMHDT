using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DinhThiThaoAn_1150080083_BTtuan5
{
    public partial class Apdung2 : Form
    {
        // Bảng password -> nhóm
        private readonly Dictionary<string, string> _passToGroup =
            new Dictionary<string, string>
            {
                ["1496"] = "Phát triển công nghệ",
                ["2673"] = "Phát triển công nghệ",
                ["7462"] = "Nghiên cứu viên",
                ["8884"] = "Thiết kế mô hình",
                ["3842"] = "Thiết kế mô hình",
                ["3383"] = "Thiết kế mô hình",
            };

        public Apdung2()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        // ==== Helpers ====
        private void AppendDigit(string d)
        {
            if (txtPassword.Text.Length < 4)
                txtPassword.Text += d;
        }

        private void LogAccess(string group, string result)
        {
            dgvLog.Rows.Insert(0, DateTime.Now.ToString("G"), group, result);
        }

        private void ClearPassword()
        {
            txtPassword.Clear();
            txtPassword.Focus();
        }

        // ==== Event handlers ====
        private void DigitButton_Click(object sender, EventArgs e)
        {
            if (sender is Button b && b.Text.All(char.IsDigit))
                AppendDigit(b.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearPassword();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var pwd = txtPassword.Text.Trim();

            if (_passToGroup.TryGetValue(pwd, out string group))
            {
                LogAccess(group, "Chấp nhận!");
                MessageBox.Show($"Chào mừng nhóm: {group}", "Access Granted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LogAccess("Không có", "Từ chối!");
                MessageBox.Show("Sai password. Từ chối!", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ClearPassword();
        }

        private void btnRing_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            MessageBox.Show("BÁO ĐỘNG!", "RING",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

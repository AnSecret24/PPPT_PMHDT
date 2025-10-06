using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DinhThiThaoAn_1150080083_Lab3
{
    public partial class ThucHanh1 : Form
    {
        public ThucHanh1()
        {
            InitializeComponent();

            // Nạp ảnh logo (thử 2 vị trí phổ biến)
            string exeDir = AppDomain.CurrentDomain.BaseDirectory;
            string p1 = Path.Combine(exeDir, "bago.jpg");
            string p2 = Path.Combine(exeDir, "Images", "bago.jpg");

            string imgPath = File.Exists(p1) ? p1 : (File.Exists(p2) ? p2 : null);
            if (imgPath != null)
            {
                // Cách không khóa file (để tránh lỗi copy khi rebuild)
                byte[] bytes = File.ReadAllBytes(imgPath);
                using (var ms = new MemoryStream(bytes))
                using (var tmp = Image.FromStream(ms))
                {
                    picLogo.Image = new Bitmap(tmp);
                }
                picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                picLogo.BackColor = Color.LightYellow;
            }

            // Nạp danh sách bàn
            for (int i = 1; i <= 10; i++) cboBan.Items.Add($"Bàn {i}");
            if (cboBan.Items.Count > 0) cboBan.SelectedIndex = 0;

            // Gắn handler cho các nút món
            btnComChienTrung.Click += OnMenuButtonClick;
            btnBanhMiOpLa.Click += OnMenuButtonClick;
            btnCoca.Click += OnMenuButtonClick;
            btnLipton.Click += OnMenuButtonClick;

            btnOcRangMuoi.Click += OnMenuButtonClick;
            btnKhoaiTayChien.Click += OnMenuButtonClick;
            btn7Up.Click += OnMenuButtonClick;
            btnCam.Click += OnMenuButtonClick;

            btnMyXaoHaiSan.Click += OnMenuButtonClick;
            btnCaVienChien.Click += OnMenuButtonClick;
            btnPepsi.Click += OnMenuButtonClick;
            btnCafe.Click += OnMenuButtonClick;

            btnBurgerBoNuong.Click += OnMenuButtonClick;
            btnDuiGaRan.Click += OnMenuButtonClick;
            btnBunBoHue.Click += OnMenuButtonClick;

            // Nút chức năng
            btnXoa.Click += BtnXoa_Click;
            btnOrder.Click += BtnOrder_Click;

            // Cấu hình ListView
            lvOrder.View = View.Details;
            lvOrder.FullRowSelect = true;
            lvOrder.GridLines = true;
            if (lvOrder.Columns.Count == 0)
            {
                lvOrder.Columns.Add("Món", 230);
                lvOrder.Columns.Add("Số lượng", 90, HorizontalAlignment.Right);
            }
        }

        private void OnMenuButtonClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            AddOrIncreaseItem(btn.Text.Trim(), 1);
        }

        private void AddOrIncreaseItem(string tenMon, int soLuongTang)
        {
            foreach (ListViewItem it in lvOrder.Items)
            {
                if (string.Equals(it.SubItems[0].Text, tenMon, StringComparison.CurrentCultureIgnoreCase))
                {
                    int sl = int.Parse(it.SubItems[1].Text);
                    it.SubItems[1].Text = (sl + soLuongTang).ToString();
                    return;
                }
            }

            var item = new ListViewItem(tenMon);
            item.SubItems.Add(soLuongTang.ToString());
            lvOrder.Items.Add(item);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (lvOrder.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn món trong danh sách để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (ListViewItem it in lvOrder.SelectedItems)
                lvOrder.Items.Remove(it);
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            if (lvOrder.Items.Count == 0)
            {
                MessageBox.Show("Danh sách món đang trống.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboBan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bàn.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tenBan = cboBan.SelectedItem.ToString();
            string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Orders");
            Directory.CreateDirectory(dir);

            string fileName = $"Order_{tenBan.Replace(' ', '_')}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string fullPath = Path.Combine(dir, fileName);

            var sb = new StringBuilder();
            sb.AppendLine("QUÁN ĂN NHANH HÙNG THỊNH");
            sb.AppendLine($"Bàn: {tenBan}");
            sb.AppendLine($"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            sb.AppendLine(new string('-', 40));
            sb.AppendLine($"{"Món",-28}{"SL",3}");
            sb.AppendLine(new string('-', 40));
            foreach (ListViewItem it in lvOrder.Items)
            {
                string mon = it.SubItems[0].Text;
                string sl = it.SubItems[1].Text;
                string monTrim = mon.Length > 28 ? mon.Substring(0, 28) : mon;
                sb.AppendLine($"{monTrim,-28}{sl,3}");
            }
            sb.AppendLine(new string('-', 40));
            sb.AppendLine("Ghi chú: File tạo tự động, thay cho gửi xuống bếp.");

            File.WriteAllText(fullPath, sb.ToString(), new UTF8Encoding(true));
            MessageBox.Show($"Đã lưu đơn hàng:\n{fullPath}", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            lvOrder.Items.Clear();
        }
    }
}

using System;
using System.Windows.Forms;

namespace DinhThiThaoAn_1150080083_Lab3
{
    public partial class ThucHanh2 : Form
    {
        public ThucHanh2()
        {
            InitializeComponent();

            // Sự kiện
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnThoat.Click += (s, e) => this.Close();

            lvSinhVien.SelectedIndexChanged += LvSinhVien_SelectedIndexChanged;
        }

        // Thêm: kiểm tra Họ tên không rỗng
        private void BtnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Họ tên không được để trống.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            string lop = txtLop.Text.Trim();
            string ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            string diaChi = txtDiaChi.Text.Trim();

            var item = new ListViewItem(hoTen);
            item.SubItems.Add(ngaySinh);
            item.SubItems.Add(lop);
            item.SubItems.Add(diaChi);

            lvSinhVien.Items.Add(item);
            ClearInputs();
        }

        // Xóa: yêu cầu chọn dòng
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn một dòng để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (ListViewItem it in lvSinhVien.SelectedItems)
                lvSinhVien.Items.Remove(it);

            ClearInputs();
        }

        // Sửa: cập nhật dòng đang chọn
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn một dòng để sửa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sel = lvSinhVien.SelectedItems[0];

            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Họ tên không được để trống.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            sel.SubItems[0].Text = hoTen;
            sel.SubItems[1].Text = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            sel.SubItems[2].Text = txtLop.Text.Trim();
            sel.SubItems[3].Text = txtDiaChi.Text.Trim();
        }

        // Chọn dòng -> đổ dữ liệu lên vùng nhập
        private void LvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0) return;
            var it = lvSinhVien.SelectedItems[0];

            txtHoTen.Text = it.SubItems[0].Text;
            DateTime d;
            if (DateTime.TryParse(it.SubItems[1].Text, out d))
                dtpNgaySinh.Value = d;
            txtLop.Text = it.SubItems[2].Text;
            txtDiaChi.Text = it.SubItems[3].Text;
        }

        private void ClearInputs()
        {
            txtHoTen.Clear();
            txtLop.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            txtHoTen.Focus();
        }
    }
}

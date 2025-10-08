using System;
using System.Drawing;
using System.Windows.Forms;

namespace DinhThiThaoAn_1150080083_Lab3
{
    partial class ThucHanh2
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private GroupBox grpInfo;
        private Label lblHoTen, lblLop, lblNgaySinh, lblDiaChi;
        private TextBox txtHoTen, txtLop, txtDiaChi;
        private DateTimePicker dtpNgaySinh;   

        private GroupBox grpChucNang;
        private Button btnThem, btnSua, btnXoa, btnThoat;

        private GroupBox grpList;
        private ListView lvSinhVien;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            // ====== Form ======
            Text = "Danh sách sinh viên";
            ClientSize = new Size(900, 600);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.WhiteSmoke;

            // ====== Tiêu đề ======
            lblTitle = new Label();
            lblTitle.Text = "DANH MỤC SINH VIÊN";
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.RoyalBlue;
            lblTitle.AutoSize = false;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Height = 80;

            // ====== GroupBox Thông tin sinh viên ======
            grpInfo = new GroupBox();
            grpInfo.Text = "Thông tin sinh viên:";
            grpInfo.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            grpInfo.SetBounds(10, 90, 870, 130);

            lblHoTen = new Label();
            lblHoTen.Text = "Họ tên:";
            lblHoTen.Location = new Point(30, 35);
            lblHoTen.AutoSize = true;

            txtHoTen = new TextBox();
            txtHoTen.SetBounds(100, 30, 260, 28);

            lblLop = new Label();
            lblLop.Text = "Lớp:";
            lblLop.Location = new Point(470, 35);
            lblLop.AutoSize = true;

            txtLop = new TextBox();
            txtLop.SetBounds(530, 30, 310, 28);

            lblNgaySinh = new Label();
            lblNgaySinh.Text = "Ngày sinh:";
            lblNgaySinh.Location = new Point(30, 80);
            lblNgaySinh.AutoSize = true;

            dtpNgaySinh = new DateTimePicker();   
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.SetBounds(100, 75, 260, 28);

            lblDiaChi = new Label();
            lblDiaChi.Text = "Địa chỉ:";
            lblDiaChi.Location = new Point(470, 80);
            lblDiaChi.AutoSize = true;

            txtDiaChi = new TextBox();
            txtDiaChi.SetBounds(530, 75, 310, 28);

            grpInfo.Controls.AddRange(new Control[] {
                lblHoTen, txtHoTen, lblLop, txtLop, lblNgaySinh, dtpNgaySinh, lblDiaChi, txtDiaChi
            });

            // ====== GroupBox Chức năng ======
            grpChucNang = new GroupBox();
            grpChucNang.Text = "Chức năng:";
            grpChucNang.Font = new Font("Segoe UI", 10F);
            grpChucNang.SetBounds(10, 230, 870, 70);

            btnThem = new Button();
            btnThem.Text = "&Thêm"; // Alt + T
            btnThem.SetBounds(150, 25, 100, 30);

            btnSua = new Button();
            btnSua.Text = "&Sửa"; // Alt + S
            btnSua.SetBounds(300, 25, 100, 30);

            btnXoa = new Button();
            btnXoa.Text = "&Xóa"; // Alt + X
            btnXoa.SetBounds(450, 25, 100, 30);

            btnThoat = new Button();
            btnThoat.Text = "T&hoát"; // Alt + h
            btnThoat.SetBounds(600, 25, 100, 30);

            grpChucNang.Controls.AddRange(new Control[] { btnThem, btnSua, btnXoa, btnThoat });

            // ====== GroupBox danh sách ======
            grpList = new GroupBox();
            grpList.Text = "Thông tin chung sinh viên:";
            grpList.Font = new Font("Segoe UI", 10F);
            grpList.SetBounds(10, 310, 870, 270);

            lvSinhVien = new ListView();
            lvSinhVien.View = View.Details;
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;
            lvSinhVien.SetBounds(15, 30, 840, 220);
            lvSinhVien.Columns.Add("Họ tên", 200);
            lvSinhVien.Columns.Add("Ngày sinh", 150);
            lvSinhVien.Columns.Add("Lớp", 200);
            lvSinhVien.Columns.Add("Địa chỉ", 250);

            grpList.Controls.Add(lvSinhVien);

            // ====== Add to Form ======
            Controls.Add(lblTitle);
            Controls.Add(grpInfo);
            Controls.Add(grpChucNang);
            Controls.Add(grpList);
        }
    }
}

namespace Lab4_WinformKetNoiCSDL
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.btnMoKetNoi = new System.Windows.Forms.Button();
            this.btnDongKetNoi = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNhapMaSV = new System.Windows.Forms.Label();
            this.txtNhapMaSV = new System.Windows.Forms.TextBox();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMoKetNoi
            // 
            this.btnMoKetNoi.Location = new System.Drawing.Point(27, 19);
            this.btnMoKetNoi.Name = "btnMoKetNoi";
            this.btnMoKetNoi.Size = new System.Drawing.Size(137, 34);
            this.btnMoKetNoi.TabIndex = 0;
            this.btnMoKetNoi.Text = "Mở kết nối";
            this.btnMoKetNoi.UseVisualStyleBackColor = true;
            this.btnMoKetNoi.Click += new System.EventHandler(this.btnMoKetNoi_Click);
            // 
            // btnDongKetNoi
            // 
            this.btnDongKetNoi.Location = new System.Drawing.Point(176, 19);
            this.btnDongKetNoi.Name = "btnDongKetNoi";
            this.btnDongKetNoi.Size = new System.Drawing.Size(137, 34);
            this.btnDongKetNoi.TabIndex = 1;
            this.btnDongKetNoi.Text = "Đóng kết nối";
            this.btnDongKetNoi.UseVisualStyleBackColor = true;
            this.btnDongKetNoi.Click += new System.EventHandler(this.btnDongKetNoi_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(14, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(640, 28);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Thực hiện truy vấn 1 dòng dữ liệu";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhapMaSV
            // 
            this.lblNhapMaSV.AutoSize = true;
            this.lblNhapMaSV.Location = new System.Drawing.Point(46, 115);
            this.lblNhapMaSV.Name = "lblNhapMaSV";
            this.lblNhapMaSV.Size = new System.Drawing.Size(120, 16);
            this.lblNhapMaSV.TabIndex = 3;
            this.lblNhapMaSV.Text = "Nhập mã sinh viên:";
            // 
            // txtNhapMaSV
            // 
            this.txtNhapMaSV.Location = new System.Drawing.Point(206, 112);
            this.txtNhapMaSV.Name = "txtNhapMaSV";
            this.txtNhapMaSV.Size = new System.Drawing.Size(377, 22);
            this.txtNhapMaSV.TabIndex = 2;
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnXemThongTin.Location = new System.Drawing.Point(49, 150);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(534, 35);
            this.btnXemThongTin.TabIndex = 3;
            this.btnXemThongTin.Text = "Xem thông tin chi tiết";
            this.btnXemThongTin.UseVisualStyleBackColor = false;
            this.btnXemThongTin.Click += new System.EventHandler(this.btnXemThongTin_Click);
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(46, 208);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(89, 16);
            this.lblTenSV.TabIndex = 6;
            this.lblTenSV.Text = "Tên sinh viên:";
            // 
            // txtTenSV
            // 
            this.txtTenSV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenSV.Location = new System.Drawing.Point(206, 205);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.ReadOnly = true;
            this.txtTenSV.Size = new System.Drawing.Size(377, 22);
            this.txtTenSV.TabIndex = 4;
            this.txtTenSV.TabStop = false;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(46, 246);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(57, 16);
            this.lblGioiTinh.TabIndex = 8;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGioiTinh.Location = new System.Drawing.Point(206, 243);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.ReadOnly = true;
            this.txtGioiTinh.Size = new System.Drawing.Size(377, 22);
            this.txtGioiTinh.TabIndex = 5;
            this.txtGioiTinh.TabStop = false;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(46, 285);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 16);
            this.lblNgaySinh.TabIndex = 10;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNgaySinh.Location = new System.Drawing.Point(206, 282);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.ReadOnly = true;
            this.txtNgaySinh.Size = new System.Drawing.Size(377, 22);
            this.txtNgaySinh.TabIndex = 6;
            this.txtNgaySinh.TabStop = false;
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(46, 323);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(68, 16);
            this.lblQueQuan.TabIndex = 12;
            this.lblQueQuan.Text = "Quê quán:";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtQueQuan.Location = new System.Drawing.Point(206, 320);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.ReadOnly = true;
            this.txtQueQuan.Size = new System.Drawing.Size(377, 22);
            this.txtQueQuan.TabIndex = 7;
            this.txtQueQuan.TabStop = false;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(46, 362);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(51, 16);
            this.lblMaLop.TabIndex = 14;
            this.lblMaLop.Text = "Mã lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaLop.Location = new System.Drawing.Point(206, 358);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(377, 22);
            this.txtMaLop.TabIndex = 8;
            this.txtMaLop.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnXemThongTin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 406);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.lblQueQuan);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.lblTenSV);
            this.Controls.Add(this.btnXemThongTin);
            this.Controls.Add(this.txtNhapMaSV);
            this.Controls.Add(this.lblNhapMaSV);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDongKetNoi);
            this.Controls.Add(this.btnMoKetNoi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAB4 - Kết nối CSDL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnMoKetNoi;
        private System.Windows.Forms.Button btnDongKetNoi;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhapMaSV;
        private System.Windows.Forms.TextBox txtNhapMaSV;
        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
    }
}

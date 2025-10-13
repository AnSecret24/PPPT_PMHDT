namespace _1150080083_lab5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxLeft = new System.Windows.Forms.GroupBox();
            this.btnThemSinhVien = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRight = new System.Windows.Forms.GroupBox();
            this.lsvDanhSachSV = new System.Windows.Forms.ListView();
            this.colMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQueQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxLeft.SuspendLayout();
            this.groupBoxRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(14, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(990, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM DỮ LIỆU KHÔNG DÙNG PARAMETER";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxLeft
            // 
            this.groupBoxLeft.Controls.Add(this.btnThemSinhVien);
            this.groupBoxLeft.Controls.Add(this.txtMaLop);
            this.groupBoxLeft.Controls.Add(this.label6);
            this.groupBoxLeft.Controls.Add(this.txtQueQuan);
            this.groupBoxLeft.Controls.Add(this.label5);
            this.groupBoxLeft.Controls.Add(this.dtpNgaySinh);
            this.groupBoxLeft.Controls.Add(this.label4);
            this.groupBoxLeft.Controls.Add(this.cbGioiTinh);
            this.groupBoxLeft.Controls.Add(this.label3);
            this.groupBoxLeft.Controls.Add(this.txtTenSV);
            this.groupBoxLeft.Controls.Add(this.label2);
            this.groupBoxLeft.Controls.Add(this.txtMaSV);
            this.groupBoxLeft.Controls.Add(this.label1);
            this.groupBoxLeft.Location = new System.Drawing.Point(14, 53);
            this.groupBoxLeft.Name = "groupBoxLeft";
            this.groupBoxLeft.Size = new System.Drawing.Size(366, 395);
            this.groupBoxLeft.TabIndex = 1;
            this.groupBoxLeft.TabStop = false;
            this.groupBoxLeft.Text = "Nhập thông tin sinh viên";
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.Location = new System.Drawing.Point(23, 331);
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.Size = new System.Drawing.Size(320, 36);
            this.btnThemSinhVien.TabIndex = 12;
            this.btnThemSinhVien.Text = "Thêm sinh viên";
            this.btnThemSinhVien.UseVisualStyleBackColor = true;
            this.btnThemSinhVien.Click += new System.EventHandler(this.btnThemSinhVien_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(114, 277);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(228, 22);
            this.txtMaLop.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã lớp:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(114, 235);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(228, 22);
            this.txtQueQuan.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quê quán:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(114, 192);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(228, 22);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày sinh:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(114, 149);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(228, 24);
            this.cbGioiTinh.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(114, 107);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(228, 22);
            this.txtTenSV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên SV:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(114, 64);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(228, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxRight
            // 
            this.groupBoxRight.Controls.Add(this.lsvDanhSachSV);
            this.groupBoxRight.Location = new System.Drawing.Point(386, 53);
            this.groupBoxRight.Name = "groupBoxRight";
            this.groupBoxRight.Size = new System.Drawing.Size(617, 395);
            this.groupBoxRight.TabIndex = 2;
            this.groupBoxRight.TabStop = false;
            this.groupBoxRight.Text = "Danh sách sinh viên";
            // 
            // lsvDanhSachSV
            // 
            this.lsvDanhSachSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSV,
            this.colTenSV,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colQueQuan,
            this.colMaLop});
            this.lsvDanhSachSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDanhSachSV.FullRowSelect = true;
            this.lsvDanhSachSV.GridLines = true;
            this.lsvDanhSachSV.HideSelection = false;
            this.lsvDanhSachSV.Location = new System.Drawing.Point(3, 18);
            this.lsvDanhSachSV.MultiSelect = false;
            this.lsvDanhSachSV.Name = "lsvDanhSachSV";
            this.lsvDanhSachSV.Size = new System.Drawing.Size(611, 374);
            this.lsvDanhSachSV.TabIndex = 0;
            this.lsvDanhSachSV.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachSV.View = System.Windows.Forms.View.Details;
            // 
            // colMaSV
            // 
            this.colMaSV.Text = "Mã SV";
            // 
            // colTenSV
            // 
            this.colTenSV.Text = "Tên SV";
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới tính";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            // 
            // colQueQuan
            // 
            this.colQueQuan.Text = "Quê quán";
            // 
            // colMaLop
            // 
            this.colMaLop.Text = "Mã lớp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 469);
            this.Controls.Add(this.groupBoxRight);
            this.Controls.Add(this.groupBoxLeft);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên (Thêm dữ liệu không dùng Parameter)";
            this.groupBoxLeft.ResumeLayout(false);
            this.groupBoxLeft.PerformLayout();
            this.groupBoxRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxLeft;
        private System.Windows.Forms.Button btnThemSinhVien;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxRight;
        private System.Windows.Forms.ListView lsvDanhSachSV;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colTenSV;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colQueQuan;
        private System.Windows.Forms.ColumnHeader colMaLop;
    }
}

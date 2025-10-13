namespace _1150080083_lab5   
{
    partial class Form2
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxLeft = new System.Windows.Forms.GroupBox();
            this.btnThemSV = new System.Windows.Forms.Button();
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
            this.lsvDanhSach = new System.Windows.Forms.ListView();
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
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(860, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ÁP DỤNG 1 - THÊM DỮ LIỆU CÓ DÙNG PARAMETER";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxLeft
            // 
            this.groupBoxLeft.Controls.Add(this.btnThemSV);
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
            this.groupBoxLeft.Location = new System.Drawing.Point(12, 45);
            this.groupBoxLeft.Name = "groupBoxLeft";
            this.groupBoxLeft.Size = new System.Drawing.Size(300, 380);
            this.groupBoxLeft.TabIndex = 1;
            this.groupBoxLeft.TabStop = false;
            this.groupBoxLeft.Text = "Nhập thông tin";
            // 
            // btnThemSV
            // 
            this.btnThemSV.Location = new System.Drawing.Point(18, 320);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(260, 36);
            this.btnThemSV.TabIndex = 12;
            this.btnThemSV.Text = "Thêm sinh viên (Parameter)";
            this.btnThemSV.UseVisualStyleBackColor = true;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(98, 270);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(180, 23);
            this.txtMaLop.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(18, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã lớp:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(98, 230);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(180, 23);
            this.txtQueQuan.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quê quán:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(98, 190);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(180, 23);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày sinh:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cbGioiTinh.Location = new System.Drawing.Point(98, 150);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(180, 23);
            this.cbGioiTinh.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(98, 110);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(180, 23);
            this.txtTenSV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên SV:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(98, 70);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(180, 23);
            this.txtMaSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxRight
            // 
            this.groupBoxRight.Controls.Add(this.lsvDanhSach);
            this.groupBoxRight.Location = new System.Drawing.Point(318, 45);
            this.groupBoxRight.Name = "groupBoxRight";
            this.groupBoxRight.Size = new System.Drawing.Size(554, 380);
            this.groupBoxRight.TabIndex = 2;
            this.groupBoxRight.TabStop = false;
            this.groupBoxRight.Text = "Danh sách sinh viên";
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSV,
            this.colTenSV,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colQueQuan,
            this.colMaLop});
            this.lsvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.Location = new System.Drawing.Point(3, 19);
            this.lsvDanhSach.MultiSelect = false;
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(548, 358);
            this.lsvDanhSach.TabIndex = 0;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            // 
            // Columns
            // 
            this.colMaSV.Text = "Mã SV"; this.colMaSV.Width = 90;
            this.colTenSV.Text = "Tên SV"; this.colTenSV.Width = 150;
            this.colGioiTinh.Text = "Giới tính"; this.colGioiTinh.Width = 70;
            this.colNgaySinh.Text = "Ngày sinh"; this.colNgaySinh.Width = 90;
            this.colQueQuan.Text = "Quê quán"; this.colQueQuan.Width = 120;
            this.colMaLop.Text = "Mã lớp"; this.colMaLop.Width = 80;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 441);
            this.Controls.Add(this.groupBoxRight);
            this.Controls.Add(this.groupBoxLeft);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2 - Thêm SV dùng Parameter";
            this.groupBoxLeft.ResumeLayout(false);
            this.groupBoxLeft.PerformLayout();
            this.groupBoxRight.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxLeft;
        private System.Windows.Forms.Button btnThemSV;
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
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colTenSV;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colQueQuan;
        private System.Windows.Forms.ColumnHeader colMaLop;
    }
}

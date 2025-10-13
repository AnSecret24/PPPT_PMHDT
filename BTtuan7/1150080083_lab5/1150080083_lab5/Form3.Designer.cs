namespace _1150080083_lab5
{
    partial class Form3
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpDS = new System.Windows.Forms.GroupBox();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.colMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQueQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnSuaThongTin = new System.Windows.Forms.Button();
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
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpDS.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(980, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sửa dữ liệu không dùng Parameter";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.cbMaLop);
            this.pnlTop.Controls.Add(this.label7);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 34);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(980, 50);
            this.pnlTop.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(15, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chọn mã lớp:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMaLop
            // 
            this.cbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaLop.Location = new System.Drawing.Point(126, 11);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(220, 23);
            this.cbMaLop.TabIndex = 1;
            this.cbMaLop.SelectedIndexChanged += new System.EventHandler(this.cbMaLop_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 84);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpDS);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpInfo);
            this.splitContainer1.Size = new System.Drawing.Size(980, 446);
            this.splitContainer1.SplitterDistance = 560;
            this.splitContainer1.TabIndex = 2;
            // 
            // grpDS
            // 
            this.grpDS.Controls.Add(this.lsvDanhSach);
            this.grpDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDS.Location = new System.Drawing.Point(0, 0);
            this.grpDS.Name = "grpDS";
            this.grpDS.Size = new System.Drawing.Size(560, 446);
            this.grpDS.TabIndex = 0;
            this.grpDS.TabStop = false;
            this.grpDS.Text = "Danh sách sinh viên:";
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
            this.lsvDanhSach.Size = new System.Drawing.Size(554, 424);
            this.lsvDanhSach.TabIndex = 0;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
            // 
            // columns
            // 
            this.colMaSV.Text = "Mã SV"; this.colMaSV.Width = 80;
            this.colTenSV.Text = "Tên SV"; this.colTenSV.Width = 150;
            this.colGioiTinh.Text = "Giới tính"; this.colGioiTinh.Width = 70;
            this.colNgaySinh.Text = "Ngày sinh"; this.colNgaySinh.Width = 90;
            this.colQueQuan.Text = "Quê quán"; this.colQueQuan.Width = 120;
            this.colMaLop.Text = "Mã lớp"; this.colMaLop.Width = 70;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnSuaThongTin);
            this.grpInfo.Controls.Add(this.txtMaLop);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.txtQueQuan);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Controls.Add(this.dtpNgaySinh);
            this.grpInfo.Controls.Add(this.label4);
            this.grpInfo.Controls.Add(this.cbGioiTinh);
            this.grpInfo.Controls.Add(this.label3);
            this.grpInfo.Controls.Add(this.txtTenSV);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.txtMaSV);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInfo.Location = new System.Drawing.Point(0, 0);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(416, 446);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin sinh viên:";
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.Enabled = false;
            this.btnSuaThongTin.Location = new System.Drawing.Point(32, 330);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(350, 36);
            this.btnSuaThongTin.TabIndex = 12;
            this.btnSuaThongTin.Text = "Sửa thông tin";
            this.btnSuaThongTin.UseVisualStyleBackColor = true;
            this.btnSuaThongTin.Click += new System.EventHandler(this.btnSuaThongTin_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(116, 282);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(266, 23);
            this.txtMaLop.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(29, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã lớp:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(116, 241);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(266, 23);
            this.txtQueQuan.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(29, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quê quán:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(116, 200);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(266, 23);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(29, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày sinh:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cbGioiTinh.Location = new System.Drawing.Point(116, 159);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(266, 23);
            this.cbGioiTinh.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(29, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(116, 118);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(266, 23);
            this.txtTenSV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên SV:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(116, 77);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(266, 23);
            this.txtMaSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 530);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa dữ liệu (không dùng Parameter)";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pnlTop.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.grpDS.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpDS;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colTenSV;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colQueQuan;
        private System.Windows.Forms.ColumnHeader colMaLop;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Button btnSuaThongTin;
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
    }
}

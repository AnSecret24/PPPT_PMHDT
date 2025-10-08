namespace Lab4_WinformKetNoiCSDL
{
    partial class Form5
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
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.btnXemDS = new System.Windows.Forms.Button();
            this.lsvSinhVien = new System.Windows.Forms.ListView();
            this.colMaSV = new System.Windows.Forms.ColumnHeader();
            this.colTenSV = new System.Windows.Forms.ColumnHeader();
            this.colGioiTinh = new System.Windows.Forms.ColumnHeader();
            this.colNgaySinh = new System.Windows.Forms.ColumnHeader();
            this.colQueQuan = new System.Windows.Forms.ColumnHeader();
            this.colMaLop = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(760, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hiển thị danh sách sinh viên theo MÃ LỚP";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(26, 58);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(51, 15);
            this.lblMaLop.TabIndex = 1;
            this.lblMaLop.Text = "Mã lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(83, 55);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(180, 23);
            this.txtMaLop.TabIndex = 2;
            // 
            // btnXemDS
            // 
            this.btnXemDS.Location = new System.Drawing.Point(280, 52);
            this.btnXemDS.Name = "btnXemDS";
            this.btnXemDS.Size = new System.Drawing.Size(180, 30);
            this.btnXemDS.TabIndex = 3;
            this.btnXemDS.Text = "Xem danh sách";
            this.btnXemDS.UseVisualStyleBackColor = true;
            this.btnXemDS.Click += new System.EventHandler(this.btnXemDS_Click);
            // 
            // lsvSinhVien
            // 
            this.lsvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSV,
            this.colTenSV,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colQueQuan,
            this.colMaLop});
            this.lsvSinhVien.FullRowSelect = true;
            this.lsvSinhVien.GridLines = true;
            this.lsvSinhVien.HideSelection = false;
            this.lsvSinhVien.Location = new System.Drawing.Point(26, 100);
            this.lsvSinhVien.MultiSelect = false;
            this.lsvSinhVien.Name = "lsvSinhVien";
            this.lsvSinhVien.Size = new System.Drawing.Size(736, 320);
            this.lsvSinhVien.TabIndex = 4;
            this.lsvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lsvSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // colMaSV
            // 
            this.colMaSV.Text = "Mã sinh viên";
            this.colMaSV.Width = 120;
            // 
            // colTenSV
            // 
            this.colTenSV.Text = "Tên sinh viên";
            this.colTenSV.Width = 160;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới tính";
            this.colGioiTinh.Width = 80;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 100;
            // 
            // colQueQuan
            // 
            this.colQueQuan.Text = "Quê quán";
            this.colQueQuan.Width = 160;
            // 
            // colMaLop
            // 
            this.colMaLop.Text = "Mã lớp";
            this.colMaLop.Width = 100;
            // 
            // Form5
            // 
            this.AcceptButton = this.btnXemDS;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.lsvSinhVien);
            this.Controls.Add(this.btnXemDS);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5 - Danh sách SV theo lớp";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button btnXemDS;
        private System.Windows.Forms.ListView lsvSinhVien;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colTenSV;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colQueQuan;
        private System.Windows.Forms.ColumnHeader colMaLop;
    }
}

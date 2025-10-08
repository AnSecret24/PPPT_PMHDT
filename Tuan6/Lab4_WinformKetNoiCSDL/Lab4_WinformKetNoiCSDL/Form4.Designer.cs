namespace Lab4_WinformKetNoiCSDL
{
    partial class Form4
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
            this.lblNhapTenKhoa = new System.Windows.Forms.Label();
            this.txtNhapTenKhoa = new System.Windows.Forms.TextBox();
            this.btnXemDS = new System.Windows.Forms.Button();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.colTenLop = new System.Windows.Forms.ColumnHeader();
            this.colMaLop = new System.Windows.Forms.ColumnHeader();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNhapTenKhoa
            // 
            this.lblNhapTenKhoa.AutoSize = true;
            this.lblNhapTenKhoa.Location = new System.Drawing.Point(26, 58);
            this.lblNhapTenKhoa.Name = "lblNhapTenKhoa";
            this.lblNhapTenKhoa.Size = new System.Drawing.Size(94, 15);
            this.lblNhapTenKhoa.TabIndex = 0;
            this.lblNhapTenKhoa.Text = "Nhập tên khoa:";
            // 
            // txtNhapTenKhoa
            // 
            this.txtNhapTenKhoa.Location = new System.Drawing.Point(130, 55);
            this.txtNhapTenKhoa.Name = "txtNhapTenKhoa";
            this.txtNhapTenKhoa.Size = new System.Drawing.Size(300, 23);
            this.txtNhapTenKhoa.TabIndex = 1;
            // 
            // btnXemDS
            // 
            this.btnXemDS.Location = new System.Drawing.Point(29, 92);
            this.btnXemDS.Name = "btnXemDS";
            this.btnXemDS.Size = new System.Drawing.Size(401, 36);
            this.btnXemDS.TabIndex = 2;
            this.btnXemDS.Text = "Xem danh sách";
            this.btnXemDS.UseVisualStyleBackColor = true;
            this.btnXemDS.Click += new System.EventHandler(this.btnXemDS_Click);
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenLop,
            this.colMaLop});
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(29, 145);
            this.lsvDanhSach.MultiSelect = false;
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(401, 230);
            this.lsvDanhSach.TabIndex = 3;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            // 
            // colTenLop
            // 
            this.colTenLop.Text = "Tên lớp";
            this.colTenLop.Width = 240;
            // 
            // colMaLop
            // 
            this.colMaLop.Text = "Mã lớp";
            this.colMaLop.Width = 120;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(432, 28);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Hiển thị danh sách lớp theo Khoa (Parameter)";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.AcceptButton = this.btnXemDS;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 394);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lsvDanhSach);
            this.Controls.Add(this.btnXemDS);
            this.Controls.Add(this.txtNhapTenKhoa);
            this.Controls.Add(this.lblNhapTenKhoa);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4 - Lọc lớp theo khoa";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblNhapTenKhoa;
        private System.Windows.Forms.TextBox txtNhapTenKhoa;
        private System.Windows.Forms.Button btnXemDS;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader colTenLop;
        private System.Windows.Forms.ColumnHeader colMaLop;
        private System.Windows.Forms.Label lblTitle;
    }
}

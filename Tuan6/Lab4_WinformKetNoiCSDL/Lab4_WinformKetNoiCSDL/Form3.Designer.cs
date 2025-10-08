﻿namespace Lab4_WinformKetNoiCSDL
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
            this.btnListView = new System.Windows.Forms.Button();
            this.lsvList = new System.Windows.Forms.ListView();
            this.colMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQueQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(14, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(754, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hiển thị thông tin các sinh viên";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListView
            // 
            this.btnListView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnListView.Location = new System.Drawing.Point(19, 48);
            this.btnListView.Name = "btnListView";
            this.btnListView.Size = new System.Drawing.Size(747, 34);
            this.btnListView.TabIndex = 1;
            this.btnListView.Text = "Xem danh sách";
            this.btnListView.UseVisualStyleBackColor = false;
            this.btnListView.Click += new System.EventHandler(this.btnListView_Click);
            // 
            // lsvList
            // 
            this.lsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSV,
            this.colTenSV,
            this.colGioiTinh,
            this.colQueQuan,
            this.colMaLop});
            this.lsvList.FullRowSelect = true;
            this.lsvList.GridLines = true;
            this.lsvList.HideSelection = false;
            this.lsvList.Location = new System.Drawing.Point(21, 98);
            this.lsvList.MultiSelect = false;
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(745, 352);
            this.lsvList.TabIndex = 2;
            this.lsvList.UseCompatibleStateImageBehavior = false;
            this.lsvList.View = System.Windows.Forms.View.Details;
            // 
            // colMaSV
            // 
            this.colMaSV.Text = "Mã sinh viên";
            this.colMaSV.Width = 110;
            // 
            // colTenSV
            // 
            this.colTenSV.Text = "Tên sinh viên";
            this.colTenSV.Width = 170;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới tính";
            this.colGioiTinh.Width = 80;
            // 
            // colQueQuan
            // 
            this.colQueQuan.Text = "Quê quán";
            this.colQueQuan.Width = 170;
            // 
            // colMaLop
            // 
            this.colMaLop.Text = "Mã lớp";
            this.colMaLop.Width = 100;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 470);
            this.Controls.Add(this.lsvList);
            this.Controls.Add(this.btnListView);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3 - Danh sách sinh viên";
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnListView;
        private System.Windows.Forms.ListView lsvList;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colTenSV;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colQueQuan;
        private System.Windows.Forms.ColumnHeader colMaLop;
    }
}

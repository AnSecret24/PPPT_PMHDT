namespace DinhThiThaoAn_1150080083_BTtuan5
{
    partial class Apdung2
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnRing = new System.Windows.Forms.Button();
            // NEW: thanh nền + nhãn Password
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.pnlPassword.SuspendLayout();
            this.SuspendLayout();

            // ===== Panel Password (nền xám) =====
            this.pnlPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlPassword.Location = new System.Drawing.Point(10, 8);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(380, 46);
            this.pnlPassword.TabIndex = 200;

            // ===== Label "Password:" =====
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPassword.Location = new System.Drawing.Point(10, 14);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 19);
            this.lblPassword.Text = "Password:";

            // ===== TextBox Password (đặt trong Panel) =====
            this.txtPassword.Location = new System.Drawing.Point(100, 12);
            this.txtPassword.MaxLength = 4;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(260, 23);
            this.txtPassword.TabIndex = 0;

            // add controls vào panel
            this.pnlPassword.Controls.Add(this.lblPassword);
            this.pnlPassword.Controls.Add(this.txtPassword);

            // ===== DataGridView Log =====
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTime,
                this.colGroup,
                this.colResult});
            this.dgvLog.Location = new System.Drawing.Point(20, 215);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.Size = new System.Drawing.Size(360, 185);
            this.dgvLog.TabIndex = 100;

            this.colTime.HeaderText = "Ngày giờ";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;

            this.colGroup.HeaderText = "Nhóm";
            this.colGroup.Name = "colGroup";
            this.colGroup.ReadOnly = true;

            this.colResult.HeaderText = "Kết quả";
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;

            // ===== Bố trí lưới phím số 1..9 =====
            int x0 = 20, y0 = 65, w = 60, h = 40, gap = 10;
            this.btn1.Location = new System.Drawing.Point(x0, y0);
            this.btn1.Name = "btn1"; this.btn1.Size = new System.Drawing.Size(w, h); this.btn1.Text = "1"; this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.DigitButton_Click);

            this.btn2.Location = new System.Drawing.Point(x0 + (w + gap), y0);
            this.btn2.Name = "btn2"; this.btn2.Size = new System.Drawing.Size(w, h); this.btn2.Text = "2"; this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.DigitButton_Click);

            this.btn3.Location = new System.Drawing.Point(x0 + 2 * (w + gap), y0);
            this.btn3.Name = "btn3"; this.btn3.Size = new System.Drawing.Size(w, h); this.btn3.Text = "3"; this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.DigitButton_Click);

            this.btn4.Location = new System.Drawing.Point(x0, y0 + (h + gap));
            this.btn4.Name = "btn4"; this.btn4.Size = new System.Drawing.Size(w, h); this.btn4.Text = "4"; this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.DigitButton_Click);

            this.btn5.Location = new System.Drawing.Point(x0 + (w + gap), y0 + (h + gap));
            this.btn5.Name = "btn5"; this.btn5.Size = new System.Drawing.Size(w, h); this.btn5.Text = "5"; this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.DigitButton_Click);

            this.btn6.Location = new System.Drawing.Point(x0 + 2 * (w + gap), y0 + (h + gap));
            this.btn6.Name = "btn6"; this.btn6.Size = new System.Drawing.Size(w, h); this.btn6.Text = "6"; this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.DigitButton_Click);

            this.btn7.Location = new System.Drawing.Point(x0, y0 + 2 * (h + gap));
            this.btn7.Name = "btn7"; this.btn7.Size = new System.Drawing.Size(w, h); this.btn7.Text = "7"; this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.DigitButton_Click);

            this.btn8.Location = new System.Drawing.Point(x0 + (w + gap), y0 + 2 * (h + gap));
            this.btn8.Name = "btn8"; this.btn8.Size = new System.Drawing.Size(w, h); this.btn8.Text = "8"; this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.DigitButton_Click);

            this.btn9.Location = new System.Drawing.Point(x0 + 2 * (w + gap), y0 + 2 * (h + gap));
            this.btn9.Name = "btn9"; this.btn9.Size = new System.Drawing.Size(w, h); this.btn9.Text = "9"; this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.DigitButton_Click);

            // ===== Nút Clear / Enter / RING có màu =====
            this.btnClear.Location = new System.Drawing.Point(220, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 40);
            this.btnClear.Text = "Clear";
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnEnter.Location = new System.Drawing.Point(220, 115);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(80, 40);
            this.btnEnter.Text = "Enter";
            this.btnEnter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);

            this.btnRing.Location = new System.Drawing.Point(220, 165);
            this.btnRing.Name = "btnRing";
            this.btnRing.Size = new System.Drawing.Size(80, 40);
            this.btnRing.Text = "RING";
            this.btnRing.BackColor = System.Drawing.Color.Red;
            this.btnRing.ForeColor = System.Drawing.Color.White;
            this.btnRing.UseVisualStyleBackColor = false;
            this.btnRing.Click += new System.EventHandler(this.btnRing_Click);

            // ===== Form =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.Controls.Add(this.pnlPassword);   // panel chứa label + textbox
            this.Controls.Add(this.btnRing);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.dgvLog);
            this.Name = "Apdung2";
            this.Text = "Security Panel - Apdung2";

            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Label lblPassword;

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnRing;
    }
}

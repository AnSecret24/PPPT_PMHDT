using System.Drawing;
using System.Windows.Forms;

namespace DinhThiThaoAn_1150080083_Lab3
{
    partial class ThucHanh1
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private Panel pnlHeader;
        private PictureBox picLogo;
        private Label lblTitle;

        // Nhóm menu
        private GroupBox grpMenu;

        // Hàng 1
        private Button btnComChienTrung;
        private Button btnBanhMiOpLa;
        private Button btnCoca;
        private Button btnLipton;

        // Hàng 2
        private Button btnOcRangMuoi;
        private Button btnKhoaiTayChien;
        private Button btn7Up;
        private Button btnCam;

        // Hàng 3
        private Button btnMyXaoHaiSan;
        private Button btnCaVienChien;
        private Button btnPepsi;
        private Button btnCafe;

        // Hàng 4
        private Button btnBurgerBoNuong;
        private Button btnDuiGaRan;
        private Button btnBunBoHue;

        // Thanh điều khiển dưới
        private Panel pnlActions;
        private Button btnXoa;
        private Label lblChonBan;
        private ComboBox cboBan;
        private Button btnOrder;

        // Danh sách order
        private ListView lvOrder;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnComChienTrung = new System.Windows.Forms.Button();
            this.btnBanhMiOpLa = new System.Windows.Forms.Button();
            this.btnCoca = new System.Windows.Forms.Button();
            this.btnLipton = new System.Windows.Forms.Button();
            this.btnOcRangMuoi = new System.Windows.Forms.Button();
            this.btnKhoaiTayChien = new System.Windows.Forms.Button();
            this.btn7Up = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.btnMyXaoHaiSan = new System.Windows.Forms.Button();
            this.btnCaVienChien = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btnBurgerBoNuong = new System.Windows.Forms.Button();
            this.btnDuiGaRan = new System.Windows.Forms.Button();
            this.btnBunBoHue = new System.Windows.Forms.Button();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblChonBan = new System.Windows.Forms.Label();
            this.cboBan = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lvOrder = new System.Windows.Forms.ListView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Quán ăn nhanh Hùng Thịnh - PDA";
            this.ClientSize = new System.Drawing.Size(760, 560);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(740, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(10, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(80, 58);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Quán ăn nhanh Hùng Thịnh";
            this.lblTitle.AutoSize = false;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.BackColor = System.Drawing.Color.ForestGreen;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(100, 10);
            this.lblTitle.Size = new System.Drawing.Size(630, 50);
            // 
            // add header children
            // 
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Controls.Add(this.lblTitle);
            // 
            // grpMenu
            // 
            this.grpMenu.Text = "Danh sách món ăn:";
            this.grpMenu.Location = new System.Drawing.Point(10, 90);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(740, 200);
            this.grpMenu.TabIndex = 1;
            // 
            // layout helper
            // 
            int left = 15, top = 25, w = 170, h = 35, gapX = 10, gapY = 12;
            // Row 1
            this.btnComChienTrung.SetBounds(left, top, w, h); this.btnComChienTrung.Text = "Cơm chiên trứng";
            this.btnBanhMiOpLa.SetBounds(left + (w + gapX), top, w, h); this.btnBanhMiOpLa.Text = "Bánh mì ốp la";
            this.btnCoca.SetBounds(left + 2 * (w + gapX), top, w, h); this.btnCoca.Text = "Coca";
            this.btnLipton.SetBounds(left + 3 * (w + gapX), top, w, h); this.btnLipton.Text = "Lipton";
            // Row 2
            top += h + gapY;
            this.btnOcRangMuoi.SetBounds(left, top, w, h); this.btnOcRangMuoi.Text = "Ốc rang muối";
            this.btnKhoaiTayChien.SetBounds(left + (w + gapX), top, w, h); this.btnKhoaiTayChien.Text = "Khoai tây chiên";
            this.btn7Up.SetBounds(left + 2 * (w + gapX), top, w, h); this.btn7Up.Text = "7 up";
            this.btnCam.SetBounds(left + 3 * (w + gapX), top, w, h); this.btnCam.Text = "Cam";
            // Row 3
            top += h + gapY;
            this.btnMyXaoHaiSan.SetBounds(left, top, w, h); this.btnMyXaoHaiSan.Text = "Mỳ xào hải sản";
            this.btnCaVienChien.SetBounds(left + (w + gapX), top, w, h); this.btnCaVienChien.Text = "Cá viên chiên";
            this.btnPepsi.SetBounds(left + 2 * (w + gapX), top, w, h); this.btnPepsi.Text = "Pepsi";
            this.btnCafe.SetBounds(left + 3 * (w + gapX), top, w, h); this.btnCafe.Text = "Cafe";
            // Row 4
            top += h + gapY;
            this.btnBurgerBoNuong.SetBounds(left, top, w, h); this.btnBurgerBoNuong.Text = "Burger bò nướng";
            this.btnDuiGaRan.SetBounds(left + (w + gapX), top, w, h); this.btnDuiGaRan.Text = "Đùi gà rán";
            this.btnBunBoHue.SetBounds(left + 2 * (w + gapX), top, w, h); this.btnBunBoHue.Text = "Bún bò Huế";

            this.grpMenu.Controls.Add(this.btnComChienTrung);
            this.grpMenu.Controls.Add(this.btnBanhMiOpLa);
            this.grpMenu.Controls.Add(this.btnCoca);
            this.grpMenu.Controls.Add(this.btnLipton);
            this.grpMenu.Controls.Add(this.btnOcRangMuoi);
            this.grpMenu.Controls.Add(this.btnKhoaiTayChien);
            this.grpMenu.Controls.Add(this.btn7Up);
            this.grpMenu.Controls.Add(this.btnCam);
            this.grpMenu.Controls.Add(this.btnMyXaoHaiSan);
            this.grpMenu.Controls.Add(this.btnCaVienChien);
            this.grpMenu.Controls.Add(this.btnPepsi);
            this.grpMenu.Controls.Add(this.btnCafe);
            this.grpMenu.Controls.Add(this.btnBurgerBoNuong);
            this.grpMenu.Controls.Add(this.btnDuiGaRan);
            this.grpMenu.Controls.Add(this.btnBunBoHue);
            // 
            // pnlActions
            // 
            this.pnlActions.Location = new System.Drawing.Point(10, 295);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(740, 45);
            // 
            // btnXoa
            // 
            this.btnXoa.Text = "Xóa";
            this.btnXoa.SetBounds(5, 8, 90, 28);
            // 
            // lblChonBan
            // 
            this.lblChonBan.Text = "Chọn bàn:";
            this.lblChonBan.AutoSize = true;
            this.lblChonBan.Location = new System.Drawing.Point(115, 13);
            // 
            // cboBan
            // 
            this.cboBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBan.SetBounds(180, 10, 180, 28);
            // 
            // btnOrder
            // 
            this.btnOrder.Text = "Order";
            this.btnOrder.SetBounds(640, 8, 90, 28);

            this.pnlActions.Controls.Add(this.btnXoa);
            this.pnlActions.Controls.Add(this.lblChonBan);
            this.pnlActions.Controls.Add(this.cboBan);
            this.pnlActions.Controls.Add(this.btnOrder);
            // 
            // lvOrder
            // 
            this.lvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.lvOrder.Location = new System.Drawing.Point(10, 345);
            this.lvOrder.Name = "lvOrder";
            this.lvOrder.Size = new System.Drawing.Size(740, 205);
            this.lvOrder.TabIndex = 4;
            // 
            // add to form
            // 
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.lvOrder);

            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
    }
}

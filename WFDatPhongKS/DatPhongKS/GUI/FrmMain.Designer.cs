
namespace GUI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDoiMK = new DevExpress.XtraEditors.SimpleButton();
            this.lbltendangnhap = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoatNick = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.menu_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_customer = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Rooms = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_invoice = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_statistics = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoatNick)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.LightBlue;
            this.panelContent.Controls.Add(this.pictureBox2);
            this.panelContent.Location = new System.Drawing.Point(151, 83);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(683, 487);
            this.panelContent.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(677, 445);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.btnDoiMK);
            this.panel2.Controls.Add(this.lbltendangnhap);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnThoatNick);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(10, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 498);
            this.panel2.TabIndex = 28;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.Appearance.Options.UseFont = true;
            this.btnDoiMK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDoiMK.ImageOptions.SvgImage")));
            this.btnDoiMK.Location = new System.Drawing.Point(0, 117);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDoiMK.Size = new System.Drawing.Size(132, 39);
            this.btnDoiMK.TabIndex = 4;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            this.btnDoiMK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDoiMK_MouseClick);
            // 
            // lbltendangnhap
            // 
            this.lbltendangnhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltendangnhap.Appearance.Options.UseFont = true;
            this.lbltendangnhap.Location = new System.Drawing.Point(25, 368);
            this.lbltendangnhap.Name = "lbltendangnhap";
            this.lbltendangnhap.Size = new System.Drawing.Size(61, 22);
            this.lbltendangnhap.TabIndex = 3;
            this.lbltendangnhap.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(50, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quay lại";
            // 
            // btnThoatNick
            // 
            this.btnThoatNick.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatNick.Image")));
            this.btnThoatNick.Location = new System.Drawing.Point(0, 406);
            this.btnThoatNick.Name = "btnThoatNick";
            this.btnThoatNick.Size = new System.Drawing.Size(44, 47);
            this.btnThoatNick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnThoatNick.TabIndex = 1;
            this.btnThoatNick.TabStop = false;
            this.btnThoatNick.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnThoatNick_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(10, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 10);
            this.panel1.TabIndex = 27;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(840, 10);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(10, 566);
            this.panelRight.TabIndex = 25;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 10);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 566);
            this.panelLeft.TabIndex = 24;
            // 
            // panelBot
            // 
            this.panelBot.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelBot.Location = new System.Drawing.Point(0, 576);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(850, 10);
            this.panelBot.TabIndex = 23;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(850, 10);
            this.panelTop.TabIndex = 22;
            // 
            // menu_employee
            // 
            this.menu_employee.BackColor = System.Drawing.Color.LightCyan;
            this.menu_employee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem});
            this.menu_employee.ForeColor = System.Drawing.Color.OrangeRed;
            this.menu_employee.Image = ((System.Drawing.Image)(resources.GetObject("menu_employee.Image")));
            this.menu_employee.Name = "menu_employee";
            this.menu_employee.Size = new System.Drawing.Size(143, 54);
            this.menu_employee.Text = "Quản Lý";
            this.menu_employee.Click += new System.EventHandler(this.menu_employee_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // menu_customer
            // 
            this.menu_customer.ForeColor = System.Drawing.Color.OrangeRed;
            this.menu_customer.Image = ((System.Drawing.Image)(resources.GetObject("menu_customer.Image")));
            this.menu_customer.Name = "menu_customer";
            this.menu_customer.Size = new System.Drawing.Size(174, 54);
            this.menu_customer.Text = "Khách Hàng";
            // 
            // menu_Rooms
            // 
            this.menu_Rooms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đặtPhòngToolStripMenuItem,
            this.trảPhòngToolStripMenuItem});
            this.menu_Rooms.ForeColor = System.Drawing.Color.OrangeRed;
            this.menu_Rooms.Image = ((System.Drawing.Image)(resources.GetObject("menu_Rooms.Image")));
            this.menu_Rooms.Name = "menu_Rooms";
            this.menu_Rooms.Size = new System.Drawing.Size(124, 54);
            this.menu_Rooms.Text = "Phòng";
            // 
            // đặtPhòngToolStripMenuItem
            // 
            this.đặtPhòngToolStripMenuItem.Name = "đặtPhòngToolStripMenuItem";
            this.đặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.đặtPhòngToolStripMenuItem.Text = "Đặt phòng";
            this.đặtPhòngToolStripMenuItem.Click += new System.EventHandler(this.đặtPhòngToolStripMenuItem_Click);
            // 
            // trảPhòngToolStripMenuItem
            // 
            this.trảPhòngToolStripMenuItem.Name = "trảPhòngToolStripMenuItem";
            this.trảPhòngToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.trảPhòngToolStripMenuItem.Text = "Trả phòng";
            this.trảPhòngToolStripMenuItem.Click += new System.EventHandler(this.trảPhòngToolStripMenuItem_Click);
            // 
            // menu_invoice
            // 
            this.menu_invoice.ForeColor = System.Drawing.Color.OrangeRed;
            this.menu_invoice.Image = ((System.Drawing.Image)(resources.GetObject("menu_invoice.Image")));
            this.menu_invoice.Name = "menu_invoice";
            this.menu_invoice.Size = new System.Drawing.Size(146, 54);
            this.menu_invoice.Text = "Hoá Đơn";
            // 
            // menu_statistics
            // 
            this.menu_statistics.ForeColor = System.Drawing.Color.OrangeRed;
            this.menu_statistics.Image = ((System.Drawing.Image)(resources.GetObject("menu_statistics.Image")));
            this.menu_statistics.Name = "menu_statistics";
            this.menu_statistics.Size = new System.Drawing.Size(153, 54);
            this.menu_statistics.Text = "Thống Kê";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.LightCyan;
            this.Menu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_employee,
            this.menu_customer,
            this.menu_Rooms,
            this.menu_invoice,
            this.menu_statistics});
            this.Menu.Location = new System.Drawing.Point(10, 10);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(830, 58);
            this.Menu.TabIndex = 26;
            this.Menu.Text = "menuStrip1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 368);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 586);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelTop);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmMain.IconOptions.LargeImage")));
            this.Name = "FrmMain";
            this.Text = "Trang Chủ - Quản Lý Đặt Phòng Khách Sạn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoatNick)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnThoatNick;
        private System.Windows.Forms.ToolStripMenuItem menu_employee;
        private System.Windows.Forms.ToolStripMenuItem menu_customer;
        private System.Windows.Forms.ToolStripMenuItem menu_Rooms;
        private System.Windows.Forms.ToolStripMenuItem menu_invoice;
        private System.Windows.Forms.ToolStripMenuItem menu_statistics;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảPhòngToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl lbltendangnhap;
        private DevExpress.XtraEditors.SimpleButton btnDoiMK;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}


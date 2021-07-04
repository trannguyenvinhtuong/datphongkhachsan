
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
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.menu_products = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_invoice = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_statistics = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoatNick)).BeginInit();
            this.Menu.SuspendLayout();
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
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.LightBlue;
            this.panelContent.Location = new System.Drawing.Point(151, 83);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(683, 487);
            this.panelContent.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnThoatNick);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(10, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 498);
            this.panel2.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(53, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quay lại";
            // 
            // btnThoatNick
            // 
            this.btnThoatNick.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatNick.Image")));
            this.btnThoatNick.Location = new System.Drawing.Point(6, 338);
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
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // menu_customer
            // 
            this.menu_customer.ForeColor = System.Drawing.Color.OrangeRed;
            this.menu_customer.Image = ((System.Drawing.Image)(resources.GetObject("menu_customer.Image")));
            this.menu_customer.Name = "menu_customer";
            this.menu_customer.Size = new System.Drawing.Size(174, 54);
            this.menu_customer.Text = "Khách Hàng";
            // 
            // menu_products
            // 
            this.menu_products.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đặtPhòngToolStripMenuItem,
            this.trảPhòngToolStripMenuItem});
            this.menu_products.ForeColor = System.Drawing.Color.OrangeRed;
            this.menu_products.Image = ((System.Drawing.Image)(resources.GetObject("menu_products.Image")));
            this.menu_products.Name = "menu_products";
            this.menu_products.Size = new System.Drawing.Size(124, 54);
            this.menu_products.Text = "Phòng";
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
            this.menu_products,
            this.menu_invoice,
            this.menu_statistics});
            this.Menu.Location = new System.Drawing.Point(10, 10);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(830, 58);
            this.Menu.TabIndex = 26;
            this.Menu.Text = "menuStrip1";
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoatNick)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem menu_products;
        private System.Windows.Forms.ToolStripMenuItem menu_invoice;
        private System.Windows.Forms.ToolStripMenuItem menu_statistics;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảPhòngToolStripMenuItem;
    }
}


namespace GUI
{
    partial class QLPhong
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.MAKHACHSAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTICH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANGCANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANH2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANH3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANH4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANH5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOGIUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAIGIUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOKHACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 20;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(798, 158);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 496);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(798, 24);
            // 
            // dgvPhong
            // 
            this.dgvPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKHACHSAN,
            this.MALOAI,
            this.MAPHONG,
            this.TENPHONG,
            this.DIENTICH,
            this.QUANGCANH,
            this.GIA,
            this.GIAM,
            this.ANH1,
            this.ANH2,
            this.ANH3,
            this.ANH4,
            this.ANH5,
            this.SOGIUONG,
            this.LOAIGIUONG,
            this.SOLUONG,
            this.SOKHACH});
            this.dgvPhong.Location = new System.Drawing.Point(12, 164);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(774, 326);
            this.dgvPhong.TabIndex = 4;
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellContentClick);
            // 
            // MAKHACHSAN
            // 
            this.MAKHACHSAN.DataPropertyName = "MAKHACHSAN";
            this.MAKHACHSAN.HeaderText = "Mã khách sạn";
            this.MAKHACHSAN.Name = "MAKHACHSAN";
            this.MAKHACHSAN.Width = 43;
            // 
            // MALOAI
            // 
            this.MALOAI.DataPropertyName = "MALOAI";
            this.MALOAI.HeaderText = "Mã loại";
            this.MALOAI.Name = "MALOAI";
            this.MALOAI.Width = 43;
            // 
            // MAPHONG
            // 
            this.MAPHONG.DataPropertyName = "MAPHONG";
            this.MAPHONG.HeaderText = "Mã phòng";
            this.MAPHONG.Name = "MAPHONG";
            this.MAPHONG.Width = 43;
            // 
            // TENPHONG
            // 
            this.TENPHONG.DataPropertyName = "TENPHONG";
            this.TENPHONG.HeaderText = "Tên phòng";
            this.TENPHONG.Name = "TENPHONG";
            this.TENPHONG.Width = 43;
            // 
            // DIENTICH
            // 
            this.DIENTICH.DataPropertyName = "DIENTICH";
            this.DIENTICH.HeaderText = "Diện tích";
            this.DIENTICH.Name = "DIENTICH";
            this.DIENTICH.Width = 43;
            // 
            // QUANGCANH
            // 
            this.QUANGCANH.DataPropertyName = "QUANGCANH";
            this.QUANGCANH.HeaderText = "Quang cảnh";
            this.QUANGCANH.Name = "QUANGCANH";
            this.QUANGCANH.Width = 43;
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.HeaderText = "Gía";
            this.GIA.Name = "GIA";
            this.GIA.Width = 43;
            // 
            // GIAM
            // 
            this.GIAM.DataPropertyName = "GIAM";
            this.GIAM.HeaderText = "Giảm";
            this.GIAM.Name = "GIAM";
            this.GIAM.Width = 43;
            // 
            // ANH1
            // 
            this.ANH1.DataPropertyName = "ANH1";
            this.ANH1.HeaderText = "Ảnh 1";
            this.ANH1.Name = "ANH1";
            this.ANH1.Width = 43;
            // 
            // ANH2
            // 
            this.ANH2.DataPropertyName = "ANH2";
            this.ANH2.HeaderText = "Ảnh 2";
            this.ANH2.Name = "ANH2";
            this.ANH2.Width = 43;
            // 
            // ANH3
            // 
            this.ANH3.DataPropertyName = "ANH3";
            this.ANH3.HeaderText = "Ảnh 3";
            this.ANH3.Name = "ANH3";
            this.ANH3.Width = 43;
            // 
            // ANH4
            // 
            this.ANH4.DataPropertyName = "ANH4";
            this.ANH4.HeaderText = "Ảnh 4";
            this.ANH4.Name = "ANH4";
            this.ANH4.Width = 43;
            // 
            // ANH5
            // 
            this.ANH5.DataPropertyName = "ANH5";
            this.ANH5.HeaderText = "Ảnh 5";
            this.ANH5.Name = "ANH5";
            this.ANH5.Width = 43;
            // 
            // SOGIUONG
            // 
            this.SOGIUONG.DataPropertyName = "SOGIUONG";
            this.SOGIUONG.HeaderText = "Số giường";
            this.SOGIUONG.Name = "SOGIUONG";
            this.SOGIUONG.Width = 43;
            // 
            // LOAIGIUONG
            // 
            this.LOAIGIUONG.DataPropertyName = "LOAIGIUONG";
            this.LOAIGIUONG.HeaderText = "Loại giường";
            this.LOAIGIUONG.Name = "LOAIGIUONG";
            this.LOAIGIUONG.Width = 43;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 43;
            // 
            // SOKHACH
            // 
            this.SOKHACH.DataPropertyName = "SOKHACH";
            this.SOKHACH.HeaderText = "Số khách";
            this.SOKHACH.Name = "SOKHACH";
            this.SOKHACH.Width = 43;
            // 
            // QLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 520);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "QLPhong";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Load += new System.EventHandler(this.QLPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHACHSAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTICH;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANGCANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANH2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANH3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANH4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANH5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOGIUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAIGIUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOKHACH;
    }
}
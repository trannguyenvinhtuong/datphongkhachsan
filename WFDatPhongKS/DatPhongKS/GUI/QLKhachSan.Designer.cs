namespace GUI
{
    partial class QLKhachSan
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
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dgvKS = new System.Windows.Forms.DataGridView();
            this.MAKHACHSAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKHACHSAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOSAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHICUTHE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANHKS1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANHKS2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANHKS3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANHKS4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANHKS5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIADANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DANHGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDIADIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKS)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
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
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
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
            this.ribbonPage1.Text = "Quản lý khách sạn";
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 575);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(798, 24);
            // 
            // dgvKS
            // 
            this.dgvKS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKHACHSAN,
            this.MANCC,
            this.TENKHACHSAN,
            this.SOLUONGPHONG,
            this.SOSAO,
            this.TINH,
            this.QUAN,
            this.PHUONG,
            this.DUONG,
            this.DIACHICUTHE,
            this.ANHKS1,
            this.ANHKS2,
            this.ANHKS3,
            this.ANHKS4,
            this.ANHKS5,
            this.MOTA,
            this.DIADANH,
            this.DANHGIA,
            this.DIEM,
            this.IDDIADIEM});
            this.dgvKS.Location = new System.Drawing.Point(12, 164);
            this.dgvKS.Name = "dgvKS";
            this.dgvKS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKS.Size = new System.Drawing.Size(774, 405);
            this.dgvKS.TabIndex = 2;
            // 
            // MAKHACHSAN
            // 
            this.MAKHACHSAN.DataPropertyName = "MAKHACHSAN";
            this.MAKHACHSAN.HeaderText = "Mã khách sạn";
            this.MAKHACHSAN.Name = "MAKHACHSAN";
            this.MAKHACHSAN.Width = 74;
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "Mã nhà cung cấp";
            this.MANCC.Name = "MANCC";
            this.MANCC.Width = 62;
            // 
            // TENKHACHSAN
            // 
            this.TENKHACHSAN.DataPropertyName = "TENKHACHSAN";
            this.TENKHACHSAN.HeaderText = "Tên khách sạn";
            this.TENKHACHSAN.Name = "TENKHACHSAN";
            this.TENKHACHSAN.Width = 78;
            // 
            // SOLUONGPHONG
            // 
            this.SOLUONGPHONG.DataPropertyName = "SOLUONGPHONG";
            this.SOLUONGPHONG.HeaderText = "Số lượng phòng";
            this.SOLUONGPHONG.Name = "SOLUONGPHONG";
            this.SOLUONGPHONG.Width = 71;
            // 
            // SOSAO
            // 
            this.SOSAO.DataPropertyName = "SOSAO";
            this.SOSAO.HeaderText = "Số sao";
            this.SOSAO.Name = "SOSAO";
            this.SOSAO.Width = 60;
            // 
            // TINH
            // 
            this.TINH.DataPropertyName = "TINH";
            this.TINH.HeaderText = "Tỉnh";
            this.TINH.Name = "TINH";
            this.TINH.Width = 52;
            // 
            // QUAN
            // 
            this.QUAN.DataPropertyName = "QUAN";
            this.QUAN.HeaderText = "Quận";
            this.QUAN.Name = "QUAN";
            this.QUAN.Width = 58;
            // 
            // PHUONG
            // 
            this.PHUONG.DataPropertyName = "PHUONG";
            this.PHUONG.HeaderText = "Phường";
            this.PHUONG.Name = "PHUONG";
            this.PHUONG.Width = 69;
            // 
            // DUONG
            // 
            this.DUONG.DataPropertyName = "DUONG";
            this.DUONG.HeaderText = "Đường";
            this.DUONG.Name = "DUONG";
            this.DUONG.Width = 65;
            // 
            // DIACHICUTHE
            // 
            this.DIACHICUTHE.DataPropertyName = "DIACHICUTHE";
            this.DIACHICUTHE.HeaderText = "Địa chỉ cụ thể";
            this.DIACHICUTHE.Name = "DIACHICUTHE";
            this.DIACHICUTHE.Width = 48;
            // 
            // ANHKS1
            // 
            this.ANHKS1.DataPropertyName = "ANHKS1";
            this.ANHKS1.HeaderText = "Ảnh khách sạn số 1";
            this.ANHKS1.Name = "ANHKS1";
            this.ANHKS1.Width = 61;
            // 
            // ANHKS2
            // 
            this.ANHKS2.DataPropertyName = "ANHKS2";
            this.ANHKS2.HeaderText = "Ảnh khách sạn số 2";
            this.ANHKS2.Name = "ANHKS2";
            this.ANHKS2.Width = 61;
            // 
            // ANHKS3
            // 
            this.ANHKS3.DataPropertyName = "ANHKS3";
            this.ANHKS3.HeaderText = "Ảnh khách sạn số 3";
            this.ANHKS3.Name = "ANHKS3";
            this.ANHKS3.Width = 61;
            // 
            // ANHKS4
            // 
            this.ANHKS4.DataPropertyName = "ANHKS4";
            this.ANHKS4.HeaderText = "Ảnh khách sạn số 4";
            this.ANHKS4.Name = "ANHKS4";
            this.ANHKS4.Width = 61;
            // 
            // ANHKS5
            // 
            this.ANHKS5.DataPropertyName = "ANHKS5";
            this.ANHKS5.HeaderText = "Ảnh khách sạn số 5";
            this.ANHKS5.Name = "ANHKS5";
            this.ANHKS5.Width = 61;
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.HeaderText = "Mô tả";
            this.MOTA.Name = "MOTA";
            this.MOTA.Width = 46;
            // 
            // DIADANH
            // 
            this.DIADANH.DataPropertyName = "DIADANH";
            this.DIADANH.HeaderText = "Địa danh";
            this.DIADANH.Name = "DIADANH";
            this.DIADANH.Width = 69;
            // 
            // DANHGIA
            // 
            this.DANHGIA.DataPropertyName = "DANHGIA";
            this.DANHGIA.HeaderText = "Đánh giá";
            this.DANHGIA.Name = "DANHGIA";
            this.DANHGIA.Width = 69;
            // 
            // DIEM
            // 
            this.DIEM.DataPropertyName = "DIEM";
            this.DIEM.HeaderText = "Điểm";
            this.DIEM.Name = "DIEM";
            this.DIEM.Width = 56;
            // 
            // IDDIADIEM
            // 
            this.IDDIADIEM.DataPropertyName = "IDDIADIEM";
            this.IDDIADIEM.HeaderText = "ID Địa điểm";
            this.IDDIADIEM.Name = "IDDIADIEM";
            this.IDDIADIEM.Width = 60;
            // 
            // QLKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 599);
            this.Controls.Add(this.dgvKS);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "QLKhachSan";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Load += new System.EventHandler(this.QLKhachSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private System.Windows.Forms.DataGridView dgvKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHACHSAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKHACHSAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOSAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHICUTHE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANHKS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANHKS2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANHKS3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANHKS4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANHKS5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIADANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DANHGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDIADIEM;
    }
}
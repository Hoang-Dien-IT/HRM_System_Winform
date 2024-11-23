namespace FRONTENDPlayer
{
    partial class frmCongTac
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCongTac));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.Them_NV = new DevExpress.XtraBars.BarButtonItem();
            this.Sua_NV = new DevExpress.XtraBars.BarButtonItem();
            this.Xoa_NV = new DevExpress.XtraBars.BarButtonItem();
            this.Dong_fromNV = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.qTCongTacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRMDataSet = new FRONTENDPlayer.HRMDataSet();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qT_CongTacTableAdapter = new FRONTENDPlayer.HRMDataSetTableAdapters.QT_CongTacTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qTCongTacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Them_NV,
            this.Sua_NV,
            this.Dong_fromNV,
            this.Xoa_NV,
            this.barDockingMenuItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Them_NV, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Sua_NV, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Xoa_NV, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Dong_fromNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // Them_NV
            // 
            this.Them_NV.Caption = "Thêm";
            this.Them_NV.Id = 0;
            this.Them_NV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Them_NV.ImageOptions.SvgImage")));
            this.Them_NV.Name = "Them_NV";
            this.Them_NV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Them_CT_ItemClick);
            // 
            // Sua_NV
            // 
            this.Sua_NV.Caption = "Sửa";
            this.Sua_NV.Id = 2;
            this.Sua_NV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Sua_NV.ImageOptions.SvgImage")));
            this.Sua_NV.Name = "Sua_NV";
            this.Sua_NV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Sua_CT_ItemClick);
            // 
            // Xoa_NV
            // 
            this.Xoa_NV.Caption = "Xóa";
            this.Xoa_NV.Id = 5;
            this.Xoa_NV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Xoa_NV.ImageOptions.SvgImage")));
            this.Xoa_NV.Name = "Xoa_NV";
            this.Xoa_NV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Xoa_CT_ItemClick);
            // 
            // Dong_fromNV
            // 
            this.Dong_fromNV.Caption = "Đóng";
            this.Dong_fromNV.Id = 4;
            this.Dong_fromNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Dong_fromNV.ImageOptions.SvgImage")));
            this.Dong_fromNV.Name = "Dong_fromNV";
            this.Dong_fromNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Dong_fromCT_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1004, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 432);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1004, 29);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 385);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1004, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 385);
            // 
            // barDockingMenuItem1
            // 
            this.barDockingMenuItem1.Caption = "barDockingMenuItem1";
            this.barDockingMenuItem1.Id = 6;
            this.barDockingMenuItem1.Name = "barDockingMenuItem1";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.DataSource = this.qTCongTacBindingSource;
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.EmbeddedNavigator.AutoSize = true;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 47);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1004, 385);
            this.gcDanhSach.TabIndex = 14;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // qTCongTacBindingSource
            // 
            this.qTCongTacBindingSource.DataMember = "QT_CongTac";
            this.qTCongTacBindingSource.DataSource = this.hRMDataSet;
            // 
            // hRMDataSet
            // 
            this.hRMDataSet.DataSetName = "HRMDataSet";
            this.hRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvDanhSach.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaCT,
            this.MaNhanVien,
            this.BatDau,
            this.KetThuc,
            this.GhiChu});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsFind.AlwaysVisible = true;
            this.gvDanhSach.OptionsFind.FindNullPrompt = "Nhập từ khóa để tìm kiếm...";
            this.gvDanhSach.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gvDanhSach.OptionsFind.ShowFindButton = false;
            // 
            // MaCT
            // 
            this.MaCT.Caption = "Mã công tác";
            this.MaCT.FieldName = "MaCT";
            this.MaCT.MinWidth = 25;
            this.MaCT.Name = "MaCT";
            this.MaCT.Visible = true;
            this.MaCT.VisibleIndex = 0;
            this.MaCT.Width = 94;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.Caption = "Mã nhân viên";
            this.MaNhanVien.FieldName = "MaNhanVien";
            this.MaNhanVien.MinWidth = 25;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Visible = true;
            this.MaNhanVien.VisibleIndex = 1;
            this.MaNhanVien.Width = 94;
            // 
            // BatDau
            // 
            this.BatDau.Caption = "Ngày bắt đầu";
            this.BatDau.FieldName = "BatDau";
            this.BatDau.MinWidth = 25;
            this.BatDau.Name = "BatDau";
            this.BatDau.Visible = true;
            this.BatDau.VisibleIndex = 2;
            this.BatDau.Width = 94;
            // 
            // KetThuc
            // 
            this.KetThuc.Caption = "Ngày kết thúc";
            this.KetThuc.FieldName = "KetThuc";
            this.KetThuc.MinWidth = 25;
            this.KetThuc.Name = "KetThuc";
            this.KetThuc.Visible = true;
            this.KetThuc.VisibleIndex = 3;
            this.KetThuc.Width = 94;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.MinWidth = 25;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 4;
            this.GhiChu.Width = 94;
            // 
            // qT_CongTacTableAdapter
            // 
            this.qT_CongTacTableAdapter.ClearBeforeFill = true;
            // 
            // frmCongTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 461);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCongTac";
            this.Text = "Công tác";
            this.Load += new System.EventHandler(this.frmCongTac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qTCongTacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem Them_NV;
        private DevExpress.XtraBars.BarButtonItem Sua_NV;
        private DevExpress.XtraBars.BarButtonItem Dong_fromNV;
        private DevExpress.XtraBars.BarButtonItem Xoa_NV;
        private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn BatDau;
        private DevExpress.XtraGrid.Columns.GridColumn KetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn MaCT;
        private HRMDataSet hRMDataSet;
        private System.Windows.Forms.BindingSource qTCongTacBindingSource;
        private HRMDataSetTableAdapters.QT_CongTacTableAdapter qT_CongTacTableAdapter;
    }
}
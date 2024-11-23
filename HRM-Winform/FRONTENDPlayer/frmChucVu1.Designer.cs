namespace FRONTENDPlayer
{
    partial class frmChucVu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChucVu1));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.Them_ChuVu = new DevExpress.XtraBars.BarButtonItem();
            this.Sua_ChuVu = new DevExpress.XtraBars.BarButtonItem();
            this.Xoa_ChuVu = new DevExpress.XtraBars.BarButtonItem();
            this.Dong_ChuVu = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dMChucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRMDataSet = new FRONTENDPlayer.HRMDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dMChucVuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dM_ChucVuTableAdapter = new FRONTENDPlayer.HRMDataSetTableAdapters.DM_ChucVuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMChucVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMChucVuBindingSource1)).BeginInit();
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
            this.Them_ChuVu,
            this.Sua_ChuVu,
            this.Xoa_ChuVu,
            this.Dong_ChuVu});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Them_ChuVu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Sua_ChuVu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Xoa_ChuVu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Dong_ChuVu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // Them_ChuVu
            // 
            this.Them_ChuVu.Caption = "Thêm";
            this.Them_ChuVu.Id = 0;
            this.Them_ChuVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Them_ChuVu.ImageOptions.SvgImage")));
            this.Them_ChuVu.Name = "Them_ChuVu";
            this.Them_ChuVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Them_ChuVu_ItemClick);
            // 
            // Sua_ChuVu
            // 
            this.Sua_ChuVu.Caption = "Sửa";
            this.Sua_ChuVu.Id = 1;
            this.Sua_ChuVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Sua_ChuVu.ImageOptions.SvgImage")));
            this.Sua_ChuVu.Name = "Sua_ChuVu";
            this.Sua_ChuVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Sua_ChuVu_ItemClick);
            // 
            // Xoa_ChuVu
            // 
            this.Xoa_ChuVu.Caption = "Xóa";
            this.Xoa_ChuVu.Id = 2;
            this.Xoa_ChuVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Xoa_ChuVu.ImageOptions.SvgImage")));
            this.Xoa_ChuVu.Name = "Xoa_ChuVu";
            this.Xoa_ChuVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Xoa_ChuVu_ItemClick);
            // 
            // Dong_ChuVu
            // 
            this.Dong_ChuVu.Caption = "Đóng";
            this.Dong_ChuVu.Id = 3;
            this.Dong_ChuVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Dong_ChuVu.ImageOptions.SvgImage")));
            this.Dong_ChuVu.Name = "Dong_ChuVu";
            this.Dong_ChuVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Dong_ChuVu_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(843, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 403);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(843, 29);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 356);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(843, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 356);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dMChucVuBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1.Location = new System.Drawing.Point(0, 47);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(843, 356);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dMChucVuBindingSource
            // 
            this.dMChucVuBindingSource.DataMember = "DM_ChucVu";
            this.dMChucVuBindingSource.DataSource = this.hRMDataSet;
            // 
            // hRMDataSet
            // 
            this.hRMDataSet.DataSetName = "HRMDataSet";
            this.hRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaChucVu,
            this.colTenChucVu,
            this.colHeSoLuong});
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1250;
            this.gridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindDelay = 100;
            this.gridView1.OptionsFind.SearchInPreview = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colHeSoLuong, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMaChucVu
            // 
            this.colMaChucVu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colMaChucVu.AppearanceHeader.Options.UseFont = true;
            this.colMaChucVu.Caption = "Mã Chức Vụ";
            this.colMaChucVu.FieldName = "MaChucVu";
            this.colMaChucVu.MinWidth = 39;
            this.colMaChucVu.Name = "colMaChucVu";
            this.colMaChucVu.Visible = true;
            this.colMaChucVu.VisibleIndex = 0;
            this.colMaChucVu.Width = 146;
            // 
            // colTenChucVu
            // 
            this.colTenChucVu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colTenChucVu.AppearanceHeader.Options.UseFont = true;
            this.colTenChucVu.Caption = "Tên Chức Vụ";
            this.colTenChucVu.FieldName = "TenChucVu";
            this.colTenChucVu.MinWidth = 39;
            this.colTenChucVu.Name = "colTenChucVu";
            this.colTenChucVu.Visible = true;
            this.colTenChucVu.VisibleIndex = 1;
            this.colTenChucVu.Width = 146;
            // 
            // colHeSoLuong
            // 
            this.colHeSoLuong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colHeSoLuong.AppearanceHeader.Options.UseFont = true;
            this.colHeSoLuong.Caption = "Hệ Số Lương";
            this.colHeSoLuong.FieldName = "HeSoLuong";
            this.colHeSoLuong.MinWidth = 39;
            this.colHeSoLuong.Name = "colHeSoLuong";
            this.colHeSoLuong.Visible = true;
            this.colHeSoLuong.VisibleIndex = 2;
            this.colHeSoLuong.Width = 146;
            // 
            // dM_ChucVuTableAdapter
            // 
            this.dM_ChucVuTableAdapter.ClearBeforeFill = true;
            // 
            // frmChucVu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 432);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmChucVu1";
            this.Text = "Chức Vụ";
            this.Load += new System.EventHandler(this.frmChucVu1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMChucVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMChucVuBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem Them_ChuVu;
        private DevExpress.XtraBars.BarButtonItem Sua_ChuVu;
        private DevExpress.XtraBars.BarButtonItem Xoa_ChuVu;
        private DevExpress.XtraBars.BarButtonItem Dong_ChuVu;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private HRMDataSet hRMDataSet;
        private System.Windows.Forms.BindingSource dMChucVuBindingSource;
        private HRMDataSetTableAdapters.DM_ChucVuTableAdapter dM_ChucVuTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colHeSoLuong;
        private System.Windows.Forms.BindingSource dMChucVuBindingSource1;
    }
}
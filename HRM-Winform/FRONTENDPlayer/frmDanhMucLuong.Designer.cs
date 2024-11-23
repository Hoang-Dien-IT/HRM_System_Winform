namespace FRONTENDPlayer
{
    partial class frmDanhMucLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMucLuong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.Sua_DMLuong = new DevExpress.XtraBars.BarButtonItem();
            this.Dong_DMLuong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dMLuongBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hRMDataSet = new FRONTENDPlayer.HRMDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLuongCoBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhuCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhauTruThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dM_LuongTableAdapter = new FRONTENDPlayer.HRMDataSetTableAdapters.DM_LuongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMLuongBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.Sua_DMLuong,
            this.Dong_DMLuong});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Sua_DMLuong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Dong_DMLuong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // Sua_DMLuong
            // 
            this.Sua_DMLuong.Caption = "Sửa";
            this.Sua_DMLuong.Id = 1;
            this.Sua_DMLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Sua_DMLuong.ImageOptions.SvgImage")));
            this.Sua_DMLuong.Name = "Sua_DMLuong";
            this.Sua_DMLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Sua_DMLuong_ItemClick);
            // 
            // Dong_DMLuong
            // 
            this.Dong_DMLuong.Caption = "Đóng";
            this.Dong_DMLuong.Id = 3;
            this.Dong_DMLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Dong_DMLuong.ImageOptions.SvgImage")));
            this.Dong_DMLuong.Name = "Dong_DMLuong";
            this.Dong_DMLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Dong_DMLuong_ItemClick);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1209, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 500);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1209, 29);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 453);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1209, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 453);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dMLuongBindingSource2;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gridControl1.Location = new System.Drawing.Point(0, 47);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1209, 453);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dMLuongBindingSource2
            // 
            this.dMLuongBindingSource2.DataMember = "DM_Luong";
            this.dMLuongBindingSource2.DataSource = this.hRMDataSet;
            // 
            // hRMDataSet
            // 
            this.hRMDataSet.DataSetName = "HRMDataSet";
            this.hRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNhanVien,
            this.colTenNhanVien,
            this.colLuongCoBan,
            this.colPhuCap,
            this.colKhauTruThue});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.Caption = "Mã Nhân Viên";
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.MinWidth = 23;
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.Visible = true;
            this.colMaNhanVien.VisibleIndex = 0;
            this.colMaNhanVien.Width = 87;
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.Caption = "Tên Nhân Viên";
            this.colTenNhanVien.FieldName = "TenNhanVien";
            this.colTenNhanVien.MinWidth = 25;
            this.colTenNhanVien.Name = "colTenNhanVien";
            this.colTenNhanVien.Visible = true;
            this.colTenNhanVien.VisibleIndex = 1;
            this.colTenNhanVien.Width = 94;
            // 
            // colLuongCoBan
            // 
            this.colLuongCoBan.Caption = "Lương Cơ Bản";
            this.colLuongCoBan.FieldName = "LuongCoBan";
            this.colLuongCoBan.MinWidth = 23;
            this.colLuongCoBan.Name = "colLuongCoBan";
            this.colLuongCoBan.Visible = true;
            this.colLuongCoBan.VisibleIndex = 2;
            this.colLuongCoBan.Width = 87;
            this.colLuongCoBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLuongCoBan.DisplayFormat.FormatString = "N0";
            // 
            // colPhuCap
            // 
            this.colPhuCap.Caption = "Phụ Cấp";
            this.colPhuCap.FieldName = "PhuCap";
            this.colPhuCap.MinWidth = 23;
            this.colPhuCap.Name = "colPhuCap";
            this.colPhuCap.Visible = true;
            this.colPhuCap.VisibleIndex = 3;
            this.colPhuCap.Width = 87;
            this.colPhuCap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPhuCap.DisplayFormat.FormatString = "N0";
            // 
            // colKhauTruThue
            // 
            this.colKhauTruThue.Caption = "Khấu Trừ Thuế";
            this.colKhauTruThue.FieldName = "KhauTruThue";
            this.colKhauTruThue.MinWidth = 23;
            this.colKhauTruThue.Name = "colKhauTruThue";
            this.colKhauTruThue.Visible = true;
            this.colKhauTruThue.VisibleIndex = 4;
            this.colKhauTruThue.Width = 87;
            this.colKhauTruThue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKhauTruThue.DisplayFormat.FormatString = "N0";
            // 
            // dM_LuongTableAdapter
            // 
            this.dM_LuongTableAdapter.ClearBeforeFill = true;
            // 
            // frmDanhMucLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 529);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDanhMucLuong";
            this.Text = "Danh Mục Lương";
            this.Load += new System.EventHandler(this.frmDanhMucLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMLuongBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem Sua_DMLuong;
        private DevExpress.XtraBars.BarButtonItem Dong_DMLuong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private HRMDataSet hRMDataSet;
        private HRMDataSetTableAdapters.DM_LuongTableAdapter dM_LuongTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colLuongCoBan;
        private DevExpress.XtraGrid.Columns.GridColumn colPhuCap;
        private DevExpress.XtraGrid.Columns.GridColumn colKhauTruThue;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhanVien;
        private System.Windows.Forms.BindingSource dMLuongBindingSource2;
    }
}
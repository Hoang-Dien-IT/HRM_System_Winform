namespace FRONTENDPlayer
{
    partial class frmThoiViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThoiViec));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1_LamViecLai = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridView1_ChoThoiViec = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenPhongBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhTrangLamViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSach_ThoiViec = new DevExpress.XtraGrid.GridControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1_ChoThoiViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach_ThoiViec)).BeginInit();
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
            this.barButtonItem1_LamViecLai});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1_LamViecLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1_LamViecLai
            // 
            this.barButtonItem1_LamViecLai.Caption = "Làm Việc Lại";
            this.barButtonItem1_LamViecLai.Id = 0;
            this.barButtonItem1_LamViecLai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1_LamViecLai.ImageOptions.SvgImage")));
            this.barButtonItem1_LamViecLai.Name = "barButtonItem1_LamViecLai";
            this.barButtonItem1_LamViecLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_LamViecLai_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(711, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 396);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(711, 29);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 349);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(711, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 349);
            // 
            // gridView1_ChoThoiViec
            // 
            this.gridView1_ChoThoiViec.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1_ChoThoiViec.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1_ChoThoiViec.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.NgaySinh,
            this.DiaChi,
            this.SoDienThoai,
            this.TenPhongBan,
            this.TenChucVu,
            this.TinhTrangLamViec});
            this.gridView1_ChoThoiViec.GridControl = this.gcDanhSach_ThoiViec;
            this.gridView1_ChoThoiViec.Name = "gridView1_ChoThoiViec";
            this.gridView1_ChoThoiViec.OptionsFind.AlwaysVisible = true;
            this.gridView1_ChoThoiViec.OptionsFind.FindDelay = 100;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.Caption = "Mã nhân viên";
            this.MaNhanVien.FieldName = "MaNhanVien";
            this.MaNhanVien.MinWidth = 25;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Visible = true;
            this.MaNhanVien.VisibleIndex = 0;
            this.MaNhanVien.Width = 94;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.Caption = "Tên nhân viên";
            this.TenNhanVien.FieldName = "TenNhanVien";
            this.TenNhanVien.MinWidth = 25;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Visible = true;
            this.TenNhanVien.VisibleIndex = 1;
            this.TenNhanVien.Width = 94;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày sinh";
            this.NgaySinh.FieldName = "NgaySinh";
            this.NgaySinh.MinWidth = 25;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 2;
            this.NgaySinh.Width = 94;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MinWidth = 25;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 3;
            this.DiaChi.Width = 94;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.Caption = "Số điện thoại";
            this.SoDienThoai.FieldName = "SoDienThoai";
            this.SoDienThoai.MinWidth = 25;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Visible = true;
            this.SoDienThoai.VisibleIndex = 4;
            this.SoDienThoai.Width = 94;
            // 
            // TenPhongBan
            // 
            this.TenPhongBan.Caption = "Tên phòng ban";
            this.TenPhongBan.FieldName = "TenPhongBan";
            this.TenPhongBan.MinWidth = 25;
            this.TenPhongBan.Name = "TenPhongBan";
            this.TenPhongBan.Visible = true;
            this.TenPhongBan.VisibleIndex = 5;
            this.TenPhongBan.Width = 94;
            // 
            // TenChucVu
            // 
            this.TenChucVu.Caption = "Tên chức vụ";
            this.TenChucVu.FieldName = "TenChucVu";
            this.TenChucVu.MinWidth = 25;
            this.TenChucVu.Name = "TenChucVu";
            this.TenChucVu.Visible = true;
            this.TenChucVu.VisibleIndex = 6;
            this.TenChucVu.Width = 94;
            // 
            // TinhTrangLamViec
            // 
            this.TinhTrangLamViec.Caption = "Tình trạng làm việc";
            this.TinhTrangLamViec.FieldName = "TinhTrangLamViec";
            this.TinhTrangLamViec.MinWidth = 25;
            this.TinhTrangLamViec.Name = "TinhTrangLamViec";
            this.TinhTrangLamViec.Visible = true;
            this.TinhTrangLamViec.VisibleIndex = 7;
            this.TinhTrangLamViec.Width = 94;
            // 
            // gcDanhSach_ThoiViec
            // 
            this.gcDanhSach_ThoiViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach_ThoiViec.Location = new System.Drawing.Point(0, 47);
            this.gcDanhSach_ThoiViec.MainView = this.gridView1_ChoThoiViec;
            this.gcDanhSach_ThoiViec.MenuManager = this.barManager1;
            this.gcDanhSach_ThoiViec.Name = "gcDanhSach_ThoiViec";
            this.gcDanhSach_ThoiViec.Size = new System.Drawing.Size(711, 349);
            this.gcDanhSach_ThoiViec.TabIndex = 4;
            this.gcDanhSach_ThoiViec.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1_ChoThoiViec});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // frmThoiViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 425);
            this.Controls.Add(this.gcDanhSach_ThoiViec);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmThoiViec";
            this.Text = "Danh sách cho thôi việc";
            this.Load += new System.EventHandler(this.frmThoiViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1_ChoThoiViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach_ThoiViec)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1_LamViecLai;
        private DevExpress.XtraGrid.GridControl gcDanhSach_ThoiViec;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1_ChoThoiViec;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn SoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn TenPhongBan;
        private DevExpress.XtraGrid.Columns.GridColumn TenChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrangLamViec;
    }
}
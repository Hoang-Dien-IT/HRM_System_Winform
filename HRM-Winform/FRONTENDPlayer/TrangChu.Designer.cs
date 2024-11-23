namespace FRONTENDPlayer
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3_DangXuat = new DevExpress.XtraBars.BarStaticItem();
            this.nghiphep = new DevExpress.XtraBars.BarButtonItem();
            this.PhongBan = new DevExpress.XtraBars.BarButtonItem();
            this.ChucVu = new DevExpress.XtraBars.BarButtonItem();
            this.ThoiViec = new DevExpress.XtraBars.BarButtonItem();
            this.Thoat_N = new DevExpress.XtraBars.BarButtonItem();
            this.Thoat_H = new DevExpress.XtraBars.BarButtonItem();
            this.ThoiGian = new DevExpress.XtraBars.BarButtonItem();
            this.NhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.CongTac = new DevExpress.XtraBars.BarButtonItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinPaletteDropDownButtonItem2 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.NgayNghi = new DevExpress.XtraBars.BarButtonItem();
            this.DanhMucLuong = new DevExpress.XtraBars.BarButtonItem();
            this.ChiTietLuong = new DevExpress.XtraBars.BarButtonItem();
            this.TKNgayNghi = new DevExpress.XtraBars.BarButtonItem();
            this.TKLuong = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.NhanSu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.DanhMucDungChung = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Luong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ThongTinLamViec = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ThongTinLuong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.GiaoDien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.CaptionBarItemLinks.Add(this.barStaticItem2);
            this.ribbon.CaptionBarItemLinks.Add(this.barStaticItem3_DangXuat);
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(69, 60, 69, 60);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem2,
            this.barStaticItem3_DangXuat,
            this.ribbon.ExpandCollapseItem,
            this.nghiphep,
            this.PhongBan,
            this.ChucVu,
            this.ThoiViec,
            this.Thoat_N,
            this.Thoat_H,
            this.ThoiGian,
            this.NhanVien,
            this.CongTac,
            this.skinPaletteDropDownButtonItem1,
            this.skinDropDownButtonItem1,
            this.skinPaletteDropDownButtonItem2,
            this.NgayNghi,
            this.DanhMucLuong,
            this.ChiTietLuong,
            this.TKNgayNghi,
            this.TKLuong});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ribbon.MaxItemId = 39;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 765;
            this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.NhanSu,
            this.Luong,
            this.HeThong});
            this.ribbon.Size = new System.Drawing.Size(1940, 242);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Cấp quyền";
            this.barStaticItem2.Id = 28;
            this.barStaticItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barStaticItem2.ImageOptions.SvgImage")));
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barStaticItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barStaticItem2_ItemClick);
            // 
            // barStaticItem3_DangXuat
            // 
            this.barStaticItem3_DangXuat.Caption = "Đăng xuất";
            this.barStaticItem3_DangXuat.Id = 29;
            this.barStaticItem3_DangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barStaticItem3_DangXuat.ImageOptions.SvgImage")));
            this.barStaticItem3_DangXuat.Name = "barStaticItem3_DangXuat";
            this.barStaticItem3_DangXuat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barStaticItem3_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barStaticItem3_DangXuat_ItemClick);
            // 
            // nghiphep
            // 
            this.nghiphep.Caption = "Nghi Phép";
            this.nghiphep.Id = 6;
            this.nghiphep.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("nghiphep.ImageOptions.SvgImage")));
            this.nghiphep.Name = "nghiphep";
            // 
            // PhongBan
            // 
            this.PhongBan.Caption = "Phòng Ban";
            this.PhongBan.Id = 7;
            this.PhongBan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("PhongBan.ImageOptions.SvgImage")));
            this.PhongBan.Name = "PhongBan";
            this.PhongBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PhongBang_ItemClick);
            // 
            // ChucVu
            // 
            this.ChucVu.Caption = "Chức Vụ";
            this.ChucVu.Id = 9;
            this.ChucVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ChucVu.ImageOptions.SvgImage")));
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChucVu_ItemClick);
            // 
            // ThoiViec
            // 
            this.ThoiViec.Caption = "Thôi Việc";
            this.ThoiViec.Id = 13;
            this.ThoiViec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ThoiViec.ImageOptions.SvgImage")));
            this.ThoiViec.Name = "ThoiViec";
            this.ThoiViec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ThoiViec_ItemClick);
            // 
            // Thoat_N
            // 
            this.Thoat_N.Caption = "Thoát";
            this.Thoat_N.Id = 14;
            this.Thoat_N.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Thoat_N.ImageOptions.SvgImage")));
            this.Thoat_N.Name = "Thoat_N";
            this.Thoat_N.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Thoat_ItemClick);
            // 
            // Thoat_H
            // 
            this.Thoat_H.Caption = "Thoát";
            this.Thoat_H.Id = 18;
            this.Thoat_H.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Thoat_H.ImageOptions.SvgImage")));
            this.Thoat_H.Name = "Thoat_H";
            this.Thoat_H.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Thoat_H_ItemClick);
            // 
            // ThoiGian
            // 
            this.ThoiGian.Caption = "Thời Gian";
            this.ThoiGian.Id = 20;
            this.ThoiGian.Name = "ThoiGian";
            // 
            // NhanVien
            // 
            this.NhanVien.Caption = "Nhân Viên";
            this.NhanVien.Id = 22;
            this.NhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NhanVien.ImageOptions.SvgImage")));
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NhanVien_ItemClick);
            // 
            // CongTac
            // 
            this.CongTac.Caption = "Công Tác";
            this.CongTac.Id = 25;
            this.CongTac.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("CongTac.ImageOptions.SvgImage")));
            this.CongTac.Name = "CongTac";
            this.CongTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CongTac_ItemClick);
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Id = 30;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 31;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinPaletteDropDownButtonItem2
            // 
            this.skinPaletteDropDownButtonItem2.Id = 32;
            this.skinPaletteDropDownButtonItem2.Name = "skinPaletteDropDownButtonItem2";
            // 
            // NgayNghi
            // 
            this.NgayNghi.Caption = "Ngày Nghỉ";
            this.NgayNghi.Id = 33;
            this.NgayNghi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NgayNghi.ImageOptions.SvgImage")));
            this.NgayNghi.Name = "NgayNghi";
            this.NgayNghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NgayNghi_ItemClick);
            // 
            // DanhMucLuong
            // 
            this.DanhMucLuong.Caption = "Danh Mục Lương";
            this.DanhMucLuong.Id = 35;
            this.DanhMucLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DanhMucLuong.ImageOptions.SvgImage")));
            this.DanhMucLuong.Name = "DanhMucLuong";
            this.DanhMucLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DanhMucLuong_ItemClick);
            // 
            // ChiTietLuong
            // 
            this.ChiTietLuong.Caption = "Chi Tiết Lương";
            this.ChiTietLuong.Id = 36;
            this.ChiTietLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ChiTietLuong.ImageOptions.SvgImage")));
            this.ChiTietLuong.Name = "ChiTietLuong";
            this.ChiTietLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChiTietLuong_ItemClick);
            // 
            // TKNgayNghi
            // 
            this.TKNgayNghi.Caption = "Thống Kê Ngày Nghỉ";
            this.TKNgayNghi.Id = 37;
            this.TKNgayNghi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TKNgayNghi.ImageOptions.SvgImage")));
            this.TKNgayNghi.Name = "TKNgayNghi";
            // 
            // TKLuong
            // 
            this.TKLuong.Caption = "Thống Kê Lương";
            this.TKLuong.Id = 38;
            this.TKLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TKLuong.ImageOptions.SvgImage")));
            this.TKLuong.Name = "TKLuong";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // NhanSu
            // 
            this.NhanSu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.DanhMucDungChung});
            this.NhanSu.Name = "NhanSu";
            this.NhanSu.Text = "Nhân Sự";
            // 
            // DanhMucDungChung
            // 
            this.DanhMucDungChung.ItemLinks.Add(this.NhanVien);
            this.DanhMucDungChung.ItemLinks.Add(this.ChucVu, true);
            this.DanhMucDungChung.ItemLinks.Add(this.PhongBan, true);
            this.DanhMucDungChung.ItemLinks.Add(this.ThoiViec, true);
            this.DanhMucDungChung.ItemLinks.Add(this.Thoat_N, true);
            this.DanhMucDungChung.Name = "DanhMucDungChung";
            this.DanhMucDungChung.Text = "Danh Mục Dùng Chung";
            // 
            // Luong
            // 
            this.Luong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ThongTinLamViec,
            this.ThongTinLuong});
            this.Luong.Name = "Luong";
            this.Luong.Text = "Lương";
            // 
            // ThongTinLamViec
            // 
            this.ThongTinLamViec.ItemLinks.Add(this.CongTac);
            this.ThongTinLamViec.ItemLinks.Add(this.NgayNghi, true);
            this.ThongTinLamViec.Name = "ThongTinLamViec";
            this.ThongTinLamViec.Text = "Thông Tin Làm Việc";
            // 
            // ThongTinLuong
            // 
            this.ThongTinLuong.ItemLinks.Add(this.DanhMucLuong);
            this.ThongTinLuong.ItemLinks.Add(this.ChiTietLuong);
            this.ThongTinLuong.Name = "ThongTinLuong";
            this.ThongTinLuong.Text = "Thông Tin Lương";
            // 
            // HeThong
            // 
            this.HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.GiaoDien});
            this.HeThong.Name = "HeThong";
            this.HeThong.Text = "Hệ Thống";
            // 
            // GiaoDien
            // 
            this.GiaoDien.ItemLinks.Add(this.skinDropDownButtonItem1);
            this.GiaoDien.ItemLinks.Add(this.skinPaletteDropDownButtonItem2);
            this.GiaoDien.ItemLinks.Add(this.Thoat_H, true);
            this.GiaoDien.Name = "GiaoDien";
            this.GiaoDien.Text = "Giao Diện";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 977);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1940, 45);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // TrangChu
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 1022);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("TrangChu.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TrangChu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Trang Chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrangChu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage NhanSu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup DanhMucDungChung;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage Luong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ThongTinLamViec;
        private DevExpress.XtraBars.BarButtonItem nghiphep;
        private DevExpress.XtraBars.BarButtonItem PhongBan;
        private DevExpress.XtraBars.BarButtonItem ChucVu;
        private DevExpress.XtraBars.BarButtonItem ThoiViec;
        private DevExpress.XtraBars.BarButtonItem Thoat_N;
        private DevExpress.XtraBars.Ribbon.RibbonPage HeThong;
        private DevExpress.XtraBars.BarButtonItem Thoat_H;
        private DevExpress.XtraBars.BarButtonItem ThoiGian;
        private DevExpress.XtraBars.BarButtonItem NhanVien;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem CongTac;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3_DangXuat;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GiaoDien;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem2;
        private DevExpress.XtraBars.BarButtonItem NgayNghi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ThongTinLuong;
        private DevExpress.XtraBars.BarButtonItem DanhMucLuong;
        private DevExpress.XtraBars.BarButtonItem ChiTietLuong;
        private DevExpress.XtraBars.BarButtonItem TKNgayNghi;
        private DevExpress.XtraBars.BarButtonItem TKLuong;
    }
}
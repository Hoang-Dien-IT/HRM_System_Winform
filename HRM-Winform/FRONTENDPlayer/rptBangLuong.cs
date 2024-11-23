using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DATAPlayer;
using System.Collections.Generic;

namespace FRONTENDPlayer
{
    public partial class rptBangLuong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangLuong()
        {
            InitializeComponent();
        }

        public rptBangLuong(List<frmLuong.Luong1> _lstBangLuong)
        {
            InitializeComponent();
            this.DataSource = _lstBangLuong;
            loadData();
        }

        public rptBangLuong( List<frmLuong.Luong1> luongTheoThangNam, int tongLuongThucLanh)
        {
            InitializeComponent();
            this.DataSource = luongTheoThangNam;
            lblTongLuong.Text = tongLuongThucLanh.ToString("N0");
            lblLuongThucLanh.TextFormatString = "{0:N0}";
            loadData();

        }

        void loadData()
        {
            lblMaNV.DataBindings.Add("Text", DataSource, "MaNhanVien");
            lblHoTen.DataBindings.Add("Text", DataSource, "TenNhanVien");
            lblThangNam.DataBindings.Add("Text", DataSource, "ThangNam");
            lblSoNgayLam.DataBindings.Add("Text", DataSource, "SoNgayLam");
            lblLuongThucLanh.DataBindings.Add("Text", DataSource, "LuongThucLanh");
        }
    }
}

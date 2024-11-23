using DATAPlayer;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using LOGICPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FRONTENDPlayer;


namespace FRONTENDPlayer
{
    public partial class InLuong : DevExpress.XtraEditors.XtraForm
    {
        public InLuong()
        {
            InitializeComponent();

        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        InBackend inBackend = new InBackend();
        private void simpleButton_In_Click(object sender, EventArgs e)
        {
            // Lấy giá trị ThangNamIn đã chọn từ DateEdit
            string selectedThangNam = ThangNamIn.DateTime.ToString("MM/yyyy");

            // Tạo danh sách Luong theo ThangNam
            List<frmLuong.Luong1> luongTheoThangNam = LayBangLuongTheoThangNam(selectedThangNam);

            int tongLuongThucLanh = inBackend.TinhTongLuongThucLanh(selectedThangNam);

            // Khởi tạo báo cáo và truyền dữ liệu
            if (luongTheoThangNam.Count > 0)
            {
                rptBangLuong rpt = new rptBangLuong(luongTheoThangNam, tongLuongThucLanh); // truyền thêm tổng lương vào báo cáo
                rpt.ShowPreviewDialog();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu lương cho tháng năm đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ThangNamIn_EditValueChanged(object sender, EventArgs e)
        {

        }


        frmLuong frmLuong = new frmLuong();

        public List<frmLuong.Luong1> LayBangLuongTheoThangNam(string thangNam)
        {
            using (var context = new HRMEntities())
            {
                var query = from luong in context.Luong
                            join nhanVien in context.NhanVien on luong.MaNhanVien equals nhanVien.MaNhanVien
                            where luong.ThangNam == thangNam
                            select new frmLuong.Luong1
                            {
                                MaNhanVien = luong.MaNhanVien,
                                TenNhanVien = nhanVien.TenNhanVien,
                                ThangNam = luong.ThangNam,
                                SoNgayLam = luong.SoNgayLam ?? 0,
                                LuongThucLanh = luong.LuongThucLanh ?? 0
                            };

                return query.ToList();
               
            }
        }
    }
}
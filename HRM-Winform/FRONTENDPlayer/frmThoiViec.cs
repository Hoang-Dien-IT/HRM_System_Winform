using DATAPlayer;
using DevExpress.XtraEditors;
using LOGICPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRONTENDPlayer
{
    public partial class frmThoiViec : DevExpress.XtraEditors.XtraForm
    {

        public frmThoiViec()
        {
            ThongBao.Load_TableThoiViec += LoadData;
            ThongBao.Load_DM_Luong += LoadData;
            InitializeComponent();
        }
        NhanVienBackEnd nhanvienbackend = new NhanVienBackEnd();
        public void LoadData()
        {
            gcDanhSach_ThoiViec.DataSource = nhanvienbackend.LoadDataTable_ThoiViec();
            gridView1_ChoThoiViec.OptionsBehavior.Editable = false;
        }

        public void frmThoiViec_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void barButtonItem1_LamViecLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            int selectedRow = gridView1_ChoThoiViec.FocusedRowHandle;
            if (selectedRow < 0)
            {
                XtraMessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ hàng được chọn
            string maNhanVien = gridView1_ChoThoiViec.GetRowCellValue(selectedRow, "MaNhanVien")?.ToString();
            string tenNhanVien = gridView1_ChoThoiViec.GetRowCellValue(selectedRow, "TenNhanVien")?.ToString();
            DateTime? ngaySinh = gridView1_ChoThoiViec.GetRowCellValue(selectedRow, "NgaySinh") as DateTime?;
            string diaChi = gridView1_ChoThoiViec.GetRowCellValue(selectedRow, "DiaChi")?.ToString();
            string soDienThoai = gridView1_ChoThoiViec.GetRowCellValue(selectedRow, "SoDienThoai")?.ToString();
            string tenPhongBan = gridView1_ChoThoiViec.GetRowCellValue(selectedRow, "TenPhongBan")?.ToString();
            string tinhTrangLamViec = gridView1_ChoThoiViec.GetRowCellValue(selectedRow, "TenChucVu")?.ToString();
            string tenChucVu = gridView1_ChoThoiViec.GetRowCellValue(selectedRow, "TenChucVu")?.ToString();

            string maPhongBan = nhanvienbackend.layMaPhongBanByTen(tenPhongBan);
            string maChucVu = nhanvienbackend.layMaChucVuByTen(tenChucVu);

            if (string.IsNullOrEmpty(maPhongBan) || string.IsNullOrEmpty(maChucVu))
            {
                XtraMessageBox.Show("Không tìm thấy mã phòng ban hoặc chức vụ tương ứng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //maNhanVien, tenNhanVien, ngaySinh, diaChi, soDienThoai, maPhongBan, maChucVu
            // Tạo đối tượng NhanVien mới với mã phòng ban và chức vụ
            NhanVien nhanVienSua = new NhanVien();
            nhanVienSua.MaNhanVien = maNhanVien;
            nhanVienSua.TenNhanVien = tenNhanVien;
            nhanVienSua.NgaySinh = ngaySinh;
            nhanVienSua.DiaChi = diaChi;
            nhanVienSua.SoDienThoai = soDienThoai;
            nhanVienSua.MaPhongBan = maPhongBan;
            nhanVienSua.MaChucVu = maChucVu;

            try
            {
                NhanVienBackEnd nhanVienBackEnd = new NhanVienBackEnd();
                nhanVienBackEnd.LamViecLai(nhanVienSua);

                MessageBox.Show("Cho làm việc lại thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LoadData();
                ThongBao.CapNhatBang_LamViecLai();
                ThongBao.CapNhatBang_DMLuong();
            }
            catch
            {
                MessageBox.Show("Lỗi cho thôi việc lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
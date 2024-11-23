using DATAPlayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using LOGICPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRONTENDPlayer
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            ThongBao.Load_TableNhanVien += LoadData;
            ThongBao.Load_TableLamViec += LoadData;
            //ThongBao.Load_DM_Luong += LoadData;
            InitializeComponent();
        }

        NhanVienBackEnd nhanvienbackend = new NhanVienBackEnd();

        private void LoadData()
        {
            gcDanhSach.DataSource = nhanvienbackend.LoadDataTable_DangLamViec();
            gvDanhSach.OptionsBehavior.Editable = false;
            nhanvienbackend.Update_DMLuong();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {

            LoadData();
        }
        private void Them_NV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemThongTinNhanVien FormThemNV = new ThemThongTinNhanVien();
            if(FormThemNV.ShowDialog() == DialogResult.OK)
            {
                
            }
            LoadData();
            ThongBao.CapNhatBang_DMLuong();
        }

        private void Sua_NV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            int selectedRow = gvDanhSach.FocusedRowHandle;
            if (selectedRow < 0) 
            {
                XtraMessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ hàng được chọn
            string maNhanVien = gvDanhSach.GetRowCellValue(selectedRow, "MaNhanVien")?.ToString();
            string tenNhanVien = gvDanhSach.GetRowCellValue(selectedRow, "TenNhanVien")?.ToString();
            DateTime? ngaySinh = gvDanhSach.GetRowCellValue(selectedRow, "NgaySinh") as DateTime?;
            string diaChi = gvDanhSach.GetRowCellValue(selectedRow, "DiaChi")?.ToString();
            string soDienThoai = gvDanhSach.GetRowCellValue(selectedRow, "SoDienThoai")?.ToString();
            string tenPhongBan = gvDanhSach.GetRowCellValue(selectedRow, "TenPhongBan")?.ToString();
            string tenChucVu = gvDanhSach.GetRowCellValue(selectedRow, "TenChucVu")?.ToString();

            // Lấy mã phòng ban và chức vụ từ tên
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




            // Mở form sửa với thông tin của hàng được chọn
            SuaNhanVien formSuaNV = new SuaNhanVien(nhanVienSua);
            if (formSuaNV.ShowDialog() == DialogResult.OK)
            {
                
            }
            LoadData();
            ThongBao.CapNhatBang_DMLuong();
        }


        private void Dong_fromNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongBao.Load_TableNhanVien -= LoadData;
            ThongBao.Load_TableLamViec -= LoadData;
            this.Close();
        }

        private void Xoa_NV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Get the focused row (selected row) index
            int selectedRow = gvDanhSach.FocusedRowHandle;

            // Check if any row is selected
            if (selectedRow < 0)
            {
                XtraMessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the MaNhanVien from the selected row
            string maNhanVien = gvDanhSach.GetRowCellValue(selectedRow, "MaNhanVien")?.ToString();
            if (string.IsNullOrEmpty(maNhanVien))
            {
                XtraMessageBox.Show("Không tìm thấy mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show confirmation dialog
            DialogResult result = XtraMessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên với mã {maNhanVien}?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Call backend logic to delete the employee
                bool isDeleted = nhanvienbackend.DeleteNhanVien(maNhanVien);

                if (isDeleted)
                {
                    XtraMessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();  // Reload data after deletion
                    ThongBao.CapNhatBang_DMLuong();
                }
                else
                {
                    XtraMessageBox.Show("Xóa nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChoThoiViec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            int selectedRow = gvDanhSach.FocusedRowHandle;
            if (selectedRow < 0)
            {
                XtraMessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ hàng được chọn
            string maNhanVien = gvDanhSach.GetRowCellValue(selectedRow, "MaNhanVien")?.ToString();
            string tenNhanVien = gvDanhSach.GetRowCellValue(selectedRow, "TenNhanVien")?.ToString();
            DateTime? ngaySinh = gvDanhSach.GetRowCellValue(selectedRow, "NgaySinh") as DateTime?;
            string diaChi = gvDanhSach.GetRowCellValue(selectedRow, "DiaChi")?.ToString();
            string soDienThoai = gvDanhSach.GetRowCellValue(selectedRow, "SoDienThoai")?.ToString();
            string tenPhongBan = gvDanhSach.GetRowCellValue(selectedRow, "TenPhongBan")?.ToString();
            string tinhTrangLamViec = gvDanhSach.GetRowCellValue(selectedRow, "TenChucVu")?.ToString();
            string tenChucVu = gvDanhSach.GetRowCellValue(selectedRow, "TenChucVu")?.ToString();

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
                nhanVienBackEnd.ChoThoiViec(nhanVienSua);

                MessageBox.Show("Cho thôi việc thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LoadData();
                ThongBao.CapNhatBang_ChoThoiViec();
                ThongBao.CapNhatBang_DMLuong();
            }
            catch
            {
                MessageBox.Show("Lỗi cho thôi việc !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }
    }
}
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
    public partial class frmCongTac : DevExpress.XtraEditors.XtraForm
    {
        public frmCongTac()
        {
            InitializeComponent();
        }

        CongTacBackEnd congtacbackend = new CongTacBackEnd();

        private void LoadData()
        {
            gcDanhSach.DataSource = congtacbackend.LoadDataTable();
            gvDanhSach.OptionsBehavior.Editable = false;
            // Khởi tạo RepositoryItemMemoEdit cho việc hiển thị nhiều dòng trong ô
            DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit memoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();

            gcDanhSach.RepositoryItems.Add(memoEdit);

            // Tìm cột GhiChu và gán memoEdit vào cột đó
            var ghiChuColumn = gvDanhSach.Columns["GhiChu"];
            if (ghiChuColumn != null)
            {
                ghiChuColumn.ColumnEdit = memoEdit;
                ghiChuColumn.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap; // Kích hoạt WordWrap cho cột GhiChu
            }

            // Bật tính năng tự động điều chỉnh chiều cao của hàng
            gvDanhSach.OptionsView.RowAutoHeight = true;

            // Đảm bảo các cột được điều chỉnh để hiển thị hết nội dung
            gvDanhSach.BestFitColumns();

            // Áp dụng WordWrap cho tất cả các cột trong GridView
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gvDanhSach.Columns)
            {
                column.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            }

        }
        private void frmCongTac_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void Them_CT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemCongTac FormThemNV = new ThemCongTac();
            if (FormThemNV.ShowDialog() == DialogResult.OK)
            {

            }
            LoadData();
        }

        private void Sua_CT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            int selectedRow = gvDanhSach.FocusedRowHandle;
            if (selectedRow < 0)
            {
                XtraMessageBox.Show("Vui lòng chọn công tác cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ hàng được chọn
            string maCT = gvDanhSach.GetRowCellValue(selectedRow, "MaCT")?.ToString();

            // Lấy dữ liệu ngày và chuyển đổi định dạng
            DateTime? ngayBD = gvDanhSach.GetRowCellValue(selectedRow, "BatDau") as DateTime?;
            DateTime? ngayKT = gvDanhSach.GetRowCellValue(selectedRow, "KetThuc") as DateTime?;

            string ghichu = gvDanhSach.GetRowCellValue(selectedRow, "GhiChu")?.ToString();
            string maNhanVien = gvDanhSach.GetRowCellValue(selectedRow, "MaNhanVien")?.ToString();

            // Tạo đối tượng CongTac mới 
            QT_CongTac CTSua = new QT_CongTac();
            CTSua.MaCT = maCT;
            CTSua.MaNhanVien = maNhanVien;
            CTSua.BatDau = ngayBD; 
            CTSua.KetThuc = ngayKT; 
            CTSua.GhiChu = ghichu;

            // Mở form sửa với thông tin của hàng được chọn
            SuaCongTac formSuaNV = new SuaCongTac(CTSua);
            if (formSuaNV.ShowDialog() == DialogResult.OK)
            {
                // Cập nhật thông tin nếu cần thiết
            }

            LoadData();
        }



        private void Dong_fromCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Xoa_CT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int selectedRow = gvDanhSach.FocusedRowHandle;

            // Kiểm tra có hàng nào được chon không
            if (selectedRow < 0)
            {
                XtraMessageBox.Show("Vui lòng chọn công tác cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy khóa chính gồm mã công tác và mã nhân viên
            string maCT = gvDanhSach.GetRowCellValue(selectedRow, "MaCT")?.ToString();
            string maNhanVien = gvDanhSach.GetRowCellValue(selectedRow, "MaNhanVien")?.ToString();

            if (string.IsNullOrEmpty(maCT) || string.IsNullOrEmpty(maNhanVien))
            {
                XtraMessageBox.Show("Không tìm thấy công tác này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hỏi khẳng định
            DialogResult result = XtraMessageBox.Show($"Bạn có chắc chắn muốn xóa công tác {maCT} cho nhân viên {maNhanVien}?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = congtacbackend.DeleteCongTac(maCT, maNhanVien);

                if (isDeleted)
                {
                    XtraMessageBox.Show("Xóa công tác thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    XtraMessageBox.Show("Xóa công tác thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}





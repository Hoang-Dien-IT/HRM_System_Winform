using DATAPlayer;
using DevExpress.XtraCharts.Designer.Native;
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
    public partial class frmNgayNghi : DevExpress.XtraEditors.XtraForm
    {
        public frmNgayNghi()
        {
            ThongBao.Load_TableDM_ChucVu += load_data;
            ThongBao.Load_TableNhanVien += load_data;
            ThongBao.Load_TableLuong += load_data;
            InitializeComponent();
        }
        NgayNghiBackEnd ngayNghiBackEnd = new NgayNghiBackEnd();
        private void frmNgayNghi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMDataSet.NgayNghi' table. You can move, or remove it, as needed.
            //this.ngayNghiTableAdapter.FillBy1(this.hRMDataSet.NgayNghi);
            load_data();
        }

        public void load_data()
        {
            this.ngayNghiTableAdapter.FillBy1(this.hRMDataSet.NgayNghi);
            gridView1.OptionsBehavior.Editable = false;
            // Khởi tạo RepositoryItemMemoEdit cho việc hiển thị nhiều dòng trong ô
            DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit memoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();

            gridControl1.RepositoryItems.Add(memoEdit);

            // Tìm cột GhiChu và gán memoEdit vào cột đó
            var ghiChuColumn = gridView1.Columns["GhiChu"];
            if (ghiChuColumn != null)
            {
                ghiChuColumn.ColumnEdit = memoEdit;
                ghiChuColumn.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap; // Kích hoạt WordWrap cho cột GhiChu
            }

            // Bật tính năng tự động điều chỉnh chiều cao của hàng
            gridView1.OptionsView.RowAutoHeight = true;

            // Đảm bảo các cột được điều chỉnh để hiển thị hết nội dung
            gridView1.BestFitColumns();

            // Áp dụng WordWrap cho tất cả các cột trong GridView
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView1.Columns)
            {
                column.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            }
        }
        // click thêm ngày nghỉ
        private void barButtonItem1_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                openFileDialog.Title = "Chọn file Excel";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Đọc và lưu dữ liệu từ file Excel trực tiếp vào cơ sở dữ liệu
                    var filePath = openFileDialog.FileName;
                    bool check = ngayNghiBackEnd.LoadNgayNghiFromExcel(filePath);
                    if(!check)
                    {
                        XtraMessageBox.Show("File excel có dữ liệu sai, trùng hoặc dữ liệu đã tồn tại trong CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Cập nhật dữ liệu hiển thị
                    load_data();
                    ThongBao.CapNhatBang_Luong();
                }
            }
        }

        private void barButtonItem4_Dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem3_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lấy GridView từ GridControl
            var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            // Kiểm tra xem có dòng nào được chọn không
            if (gridView.FocusedRowHandle >= 0)
            {
                

                try
                {
                    // Lấy dữ liệu từ dòng được chọn
                    string maNhanVien = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaNhanVien").ToString();
                    string thangNam = gridView.GetRowCellValue(gridView.FocusedRowHandle, "ThangNam").ToString();
                    int soNgayNghi = Convert.ToInt32(gridView.GetRowCellValue(gridView.FocusedRowHandle, "SoNgayNghi"));
                    string ghiChu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "GhiChu").ToString();


                    NgayNghi ngayNghi = new NgayNghi();
                    ngayNghi.MaNhanVien = maNhanVien;
                    ngayNghi.ThangNam = thangNam;
                    ngayNghi.SoNgayNghi = soNgayNghi;
                    ngayNghi.GhiChu = ghiChu;

                    
                    ngayNghiBackEnd.Remove(ngayNghi);


                    MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ngayNghiTableAdapter.FillBy1(this.hRMDataSet.NgayNghi);
                    ThongBao.CapNhatBang_Luong();
                    //ThongBao.CapNhatBang_DMChucVu();
                    //ThongBao.CapNhatBang_NhanVien();
                }
                catch
                {
                    MessageBox.Show("Xóa phòng ban thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
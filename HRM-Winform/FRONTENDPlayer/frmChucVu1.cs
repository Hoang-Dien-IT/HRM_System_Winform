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
    public partial class frmChucVu1 : DevExpress.XtraEditors.XtraForm
    {
        public frmChucVu1()
        {
            //ThongBao.Load_TableDM_ChucVu += load_data;
            InitializeComponent();
        }

        private void Dong_ChuVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        public void load_data()
        {
            this.dM_ChucVuTableAdapter.Fill(this.hRMDataSet.DM_ChucVu);
        }
        private void frmChucVu1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMDataSet1.DM_ChucVu' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'hRMDataSet.DM_ChucVu' table. You can move, or remove it, as needed.
            load_data();
            gridView1.OptionsBehavior.Editable = false;

        }

        private void Them_ChuVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemChucVu formthem = new ThemChucVu();
            if (formthem.ShowDialog() == DialogResult.OK)
            {
                this.dM_ChucVuTableAdapter.Fill(this.hRMDataSet.DM_ChucVu);
            }
        }

        private void Sua_ChuVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lấy GridView từ GridControl
            var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            // Kiểm tra xem có dòng nào được chọn không
            if (gridView.FocusedRowHandle >= 0)
            {
                // Lấy dữ liệu từ dòng được chọn
                string maChucVu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaChucVu").ToString();
                string tenChucVu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "TenChucVu").ToString();
                decimal heSoLuong = Convert.ToDecimal(gridView.GetRowCellValue(gridView.FocusedRowHandle, "HeSoLuong"));

                // Tạo đối tượng form sửa với dữ liệu được chọn
                SuaChucVu formSua = new SuaChucVu(maChucVu, tenChucVu, heSoLuong);

                // Hiển thị form sửa
                if (formSua.ShowDialog() == DialogResult.OK)
                {
                    // Sau khi sửa, tải lại dữ liệu vào GridControl
                    this.dM_ChucVuTableAdapter.Fill(this.hRMDataSet.DM_ChucVu);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Xoa_ChuVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView.FocusedRowHandle >= 0)
            {
                try
                {
                    //// Lấy dữ liệu của hàng được chọn

                    string maChucVu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaChucVu").ToString();

                    ChucVuBackEnd chucVuBackEnd = new ChucVuBackEnd();
                    DM_ChucVu chucVu = new DM_ChucVu();
                    chucVu.MaChucVu = maChucVu;

                    chucVuBackEnd.Remove(chucVu);

                    MessageBox.Show("Xóa chức vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.dM_ChucVuTableAdapter.Fill(this.hRMDataSet.DM_ChucVu);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa chức vụ đã có trong bảng nhân viên .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chức vụ để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
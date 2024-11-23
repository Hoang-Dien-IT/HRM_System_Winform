using DATAPlayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using FRONTENDPlayer.HRMDataSetTableAdapters;
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
    public partial class frmPhongBan1 : DevExpress.XtraEditors.XtraForm
    {
        public frmPhongBan1()
        {
            InitializeComponent();
        }

        private void frmPhongBan1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMDataSet.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.hRMDataSet.PhongBan);
            gridView1_PhongBan.OptionsBehavior.Editable = false;


        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemPhongBan themPhongBan = new ThemPhongBan();
            if (themPhongBan.ShowDialog() == DialogResult.OK)
            {
                this.phongBanTableAdapter.Fill(this.hRMDataSet.PhongBan);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Lấy GridView từ GridControl
            var gridView = gridControl1_PhongBan.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            // Kiểm tra xem có dòng nào được chọn không
            if (gridView.FocusedRowHandle >= 0)
            {
                // Lấy dữ liệu từ dòng được chọn
                string maPhongBan = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhongBan").ToString();
                string tenPhongBan = gridView.GetRowCellValue(gridView.FocusedRowHandle, "TenPhongBan").ToString();
                string vanPhong = gridView.GetRowCellValue(gridView.FocusedRowHandle, "VanPhong").ToString();

                // Tạo đối tượng form sửa với dữ liệu được chọn
                SuaPhongBan formSua = new SuaPhongBan(maPhongBan, tenPhongBan, vanPhong);

                // Hiển thị form sửa
                if (formSua.ShowDialog() == DialogResult.OK)
                {
                    // Sau khi sửa, tải lại dữ liệu vào GridControl
                    this.phongBanTableAdapter.Fill(this.hRMDataSet.PhongBan);
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void barButtonItem3_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var gridView = gridControl1_PhongBan.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            // Chưa nhấp vào hàng thì k hiện bảng sửa
            if (gridView.FocusedRowHandle >= 0)
            {
                try
                {
                    PhongBanBackEnd phongBanBackEnd = new PhongBanBackEnd();

                    PhongBan phongBan = new PhongBan();
                    phongBan.MaPhongBan = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaPhongBan").ToString();
                    phongBan.TenPhongBan = gridView.GetRowCellValue(gridView.FocusedRowHandle, "TenPhongBan").ToString();
                    phongBan.VanPhong = gridView.GetRowCellValue(gridView.FocusedRowHandle, "VanPhong").ToString();

                    phongBanBackEnd.Remove(phongBan);
                    MessageBox.Show("Xóa phòng ban thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.phongBanTableAdapter.Fill(this.hRMDataSet.PhongBan);
                }
                catch
                {
                    MessageBox.Show("Xóa phòng ban thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gridControl1_PhongBan_Click(object sender, EventArgs e)
        {

        }
    }
}
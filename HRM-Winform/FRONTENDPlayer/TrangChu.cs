using DevExpress.XtraBars;
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
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TrangChu()
        {
            InitializeComponent();

        }

        void openForm(Type typeForm)
        {
            foreach (var frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }

        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị thông báo xác nhận
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát?",
                                           "Xác nhận thoát",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

            // Nếu người dùng chọn "No", hủy việc đóng form
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void PhongBang_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmPhongBan1));
        }

        private void ChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(frmChucVu1));
        }

        private void Thoat_H_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void NhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmNhanVien));
        }

        private void ThoiViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmThoiViec));
        }

        private void CongTac_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmCongTac));
        }


        private void barStaticItem3_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắn chắn muốn đăng xuất ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Dangnhap dangnhap = new Dangnhap();
                dangnhap.Show();
            }
        }

        private void barStaticItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCapQuyen frmCapQuyen = new frmCapQuyen();

            if (frmCapQuyen.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void NgayNghi_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmNgayNghi));
        }

        private void DanhMucLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmDanhMucLuong));
        }

        private void ChiTietLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmLuong));
        }
    }
}
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
   
    public partial class frmCapQuyen : DevExpress.XtraEditors.XtraForm
    {
        Logic_TaiKhoan logic_TaiKhoan = new Logic_TaiKhoan();
        public int stt_TK = -1;
        public string tenTK = "";
        public frmCapQuyen()
        {
            InitializeComponent();
        }

        private void barStaticItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // chưa chọn hàng TK
            if (stt_TK == -1)
            {
                MessageBox.Show("Vui lòng click chọn tài khoản !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else // Đã click vào hàng TK
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn cấp quyền cho tài khoản: " + tenTK + " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        Logic_TaiKhoan logic_TaiKhoan = new Logic_TaiKhoan();
                        TaiKhoan taiKhoan_Object = new TaiKhoan();
                        taiKhoan_Object.STT_Tk = stt_TK;
                        logic_TaiKhoan.CapQuyen(taiKhoan_Object);

                        MessageBox.Show("Cấp quyền thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_DataTK();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi cấp quyền !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    load_DataTK();
                }
                
            }
        }

        private void dataGridView_capQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dataGridView_capQuyen.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột và lưu vào biến
                stt_TK = (int)row.Cells[0].Value; // Cột 1
                tenTK = row.Cells[1].Value.ToString();
            }
        }

        public void load_DataTK()
        {
            dataGridView_capQuyen.DataSource = logic_TaiKhoan.LoadDataTable();
            dataGridView_capQuyen.ClearSelection();
        }
        private void frmCapQuyen_Load(object sender, EventArgs e)
        {
            load_DataTK();
        }

        private void barStaticItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stt_TK == -1)
            {
                MessageBox.Show("Vui lòng click chọn tài khoản !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thu hồi quyền tài khoản: " + tenTK + " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Logic_TaiKhoan logic_TaiKhoan = new Logic_TaiKhoan();
                        TaiKhoan taiKhoan_Object = new TaiKhoan();
                        taiKhoan_Object.STT_Tk = stt_TK;
                        logic_TaiKhoan.ThuHoi(taiKhoan_Object);

                        MessageBox.Show("Thu hồi quyền thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_DataTK();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi thu hồi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    load_DataTK();
                }

            }
        }

        private void barStaticItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stt_TK == -1)
            {
                MessageBox.Show("Vui lòng click chọn tài khoản !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tài khoản: " + tenTK + " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Logic_TaiKhoan logic_TaiKhoan = new Logic_TaiKhoan();
                        TaiKhoan taiKhoan_Object = new TaiKhoan();
                        taiKhoan_Object.STT_Tk = stt_TK;
                        logic_TaiKhoan.Xoa(taiKhoan_Object);

                        MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_DataTK();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    load_DataTK();
                }

            }
        }
    }
}
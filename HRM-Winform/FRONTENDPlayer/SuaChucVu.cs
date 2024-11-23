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
    public partial class SuaChucVu : DevExpress.XtraEditors.XtraForm
    {
        private string maChucVu;

        public SuaChucVu(string maChucVu, string tenChucVu, decimal heSoLuong)
        {
            InitializeComponent();

            // Gán dữ liệu lên các trường nhập liệu
            this.maChucVu = maChucVu; // Giữ lại mã chức vụ để cập nhật
            textEdit_MaChucVu.Text = maChucVu;
            textEdit_TenChucVu.Text = tenChucVu;

            // Gán giá trị cho comboBox_HeSoLuong
            lookUpEdit1.EditValue = heSoLuong;

            this.AcceptButton = this.simpleButton_Luu;
        }


        private void SuaChucVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMDataSet.DM_ChucVu' table. You can move, or remove it, as needed.
            this.dM_ChucVuTableAdapter.Fill(this.hRMDataSet.DM_ChucVu);

        }

        private void simpleButton1_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton_Luu_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu đã chỉnh sửa
            string tenChucVuMoi = textEdit_TenChucVu.Text.Trim();
            decimal heSoLuongMoi;

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(tenChucVuMoi))
            {
                MessageBox.Show("Tên chức vụ không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra nếu giá trị trong comboBox hợp lệ và là decimal
            if (!decimal.TryParse(lookUpEdit1.Text, out heSoLuongMoi) || heSoLuongMoi <= 0)
            {
                MessageBox.Show("Hệ số lương phải là một số hợp lệ lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChucVuBackEnd chucVuBackEnd = new ChucVuBackEnd();
            // Gọi backend để cập nhật dữ liệu
            bool result = chucVuBackEnd.UpdateChucVu(maChucVu, tenChucVuMoi, heSoLuongMoi);

            if (result)
            {
                MessageBox.Show("Sửa chức vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi khi sửa chức vụ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
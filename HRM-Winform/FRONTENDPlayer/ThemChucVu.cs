using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.Html;
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
    public partial class ThemChucVu : DevExpress.XtraEditors.XtraForm
    {
        public ThemChucVu()
        {
            InitializeComponent();
            this.AcceptButton = this.simpleButton_Luu;
        }
        ChucVuBackEnd chucVuBackEnd = new ChucVuBackEnd();



        private void ThemChucVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMDataSet.DM_ChucVu' table. You can move, or remove it, as needed.
            this.dM_ChucVuTableAdapter.Fill(this.hRMDataSet.DM_ChucVu);

        }

        private void simpleButton_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các trường
                string maChucVu = textEdit_MaChucVu.Text.ToUpper();
                string tenChucVu = textEdit_TenChucVu.Text;
                decimal heSoLuong;

                // Kiểm tra các điều kiện không được để trống
                if (string.IsNullOrEmpty(maChucVu))
                {
                    MessageBox.Show("Mã chức vụ không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (maChucVu.Length < 2)
                {
                    MessageBox.Show("Mã chức vụ phải có ít nhất 2 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(tenChucVu))
                {
                    MessageBox.Show("Tên chức vụ không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(lookUpEdit1.Text, out heSoLuong))
                {
                    MessageBox.Show("Hệ số lương không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

     

                // Kiểm tra trùng lặp mã hoặc tên chức vụ
                if (chucVuBackEnd.IsDuplicate(maChucVu, tenChucVu))
                {
                    MessageBox.Show("Mã hoặc tên chức vụ đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool result = chucVuBackEnd.AddChucVu(maChucVu, tenChucVu, heSoLuong);

                if (result)
                {
                    MessageBox.Show("Thêm chức vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm chức vụ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi thêm chức vụ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
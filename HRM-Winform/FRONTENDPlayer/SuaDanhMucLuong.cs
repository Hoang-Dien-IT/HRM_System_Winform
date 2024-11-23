using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGICPlayer;

namespace FRONTENDPlayer
{
    public partial class SuaDanhMucLuong : DevExpress.XtraEditors.XtraForm
    {
        private BackendDMLuong backend = new BackendDMLuong();
        private string maNhanVien;

        public SuaDanhMucLuong(string maNhanVien, decimal? luongCoBan, decimal? phuCap, decimal? khauTruThue)
        {
            InitializeComponent();
            this.maNhanVien = maNhanVien;

            // Hiển thị dữ liệu vào các TextBox không có dấu phân cách
            textBox_MaNhanVien.Text = maNhanVien;
            textBox_LuongCoBan.Text = luongCoBan?.ToString("F0") ?? string.Empty;
            textBox_PhuCap.Text = phuCap?.ToString("F0") ?? string.Empty;
            textBox_KhauTruThue.Text = khauTruThue?.ToString("F0") ?? string.Empty;
        }


        private void simpleButton_Luu_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            decimal? luongCoBan = !string.IsNullOrEmpty(textBox_LuongCoBan.Text) ? Convert.ToDecimal(textBox_LuongCoBan.Text) : (decimal?)null;
            decimal? phuCap = !string.IsNullOrEmpty(textBox_PhuCap.Text) ? Convert.ToDecimal(textBox_PhuCap.Text) : (decimal?)null;
            decimal? khauTruThue = !string.IsNullOrEmpty(textBox_KhauTruThue.Text) ? Convert.ToDecimal(textBox_KhauTruThue.Text) : (decimal?)null;

            // Gọi phương thức sửa lương trong BackendDMLuong
            if (backend.SuaLuong(maNhanVien, luongCoBan, phuCap, khauTruThue))
            {
                MessageBox.Show("Cập nhật lương thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật lương thất bại.");
            }
        }

        private void simpleButton_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
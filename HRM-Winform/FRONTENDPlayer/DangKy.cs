using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DevExpress.DataAccess.DataFederation;
using DevExpress.DataAccess.Native.EntityFramework;
using LOGICPlayer;

namespace FRONTENDPlayer
{
    public partial class DangKy : DevExpress.XtraEditors.XtraForm
    {
        public DangKy()
        {
            InitializeComponent();
            this.AcceptButton = this.button1_DangKy;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dangnhap dangnhap = new Dangnhap();
            this.Hide();
            dangnhap.Show();
        }



        private void button2_Click_2(object sender, EventArgs e)
        {
            textBox_TaiKhoan.Text = string.Empty;
            textBox2_MatKhau.Text = string.Empty;
            textBox3_XacNhanMK.Text = string.Empty;
            textBox1_Gmail.Text = string.Empty;
            textBox_TaiKhoan.Focus();
        }


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Dangnhap dangnhap = new Dangnhap();
            dangnhap.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Logic_TaiKhoan logic_TaiKhoan = new Logic_TaiKhoan();

            if (textBox_TaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_TaiKhoan.Focus();
            }
            else if (textBox2_MatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2_MatKhau.Focus();
            }
            else if (textBox3_XacNhanMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập xác nhận mật khẩu !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3_XacNhanMK.Focus();
            }
            else if (textBox3_XacNhanMK.Text != textBox2_MatKhau.Text)
            {
                MessageBox.Show("Bạn đã nhập sai xác nhận mật khẩu !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3_XacNhanMK.Focus();
            }
            else if (textBox1_Gmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Gmail !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1_Gmail.Focus();
            }
            else if (!Regex.IsMatch(textBox1_Gmail.Text, @"^[\w\.-]+@([\w-]+\.)+[\w-]{2,4}$"))
                {
                MessageBox.Show("Gmail không hợp lệ, vui lòng nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1_Gmail.Focus();
            }
            // nếu tại tk hợp lệ -> lưu tài khoản và chuyển đến trang đăng ký
            else if (!logic_TaiKhoan.TrungTaiKhoan1(textBox_TaiKhoan.Text))
            {
                if (logic_TaiKhoan.ThemTaiKhoan1(textBox_TaiKhoan.Text, textBox2_MatKhau.Text, textBox1_Gmail.Text))
                {
                    MessageBox.Show("Tạo tài khoản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Dangnhap dangnhap = new Dangnhap();
                    dangnhap.Show();
                }
                
            } else
            {
                label6_ThongBaoTrungTK.Visible = true;
            }

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắn chắn muốn thoát ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
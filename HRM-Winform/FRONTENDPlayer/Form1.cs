using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DATAPlayer;
using DevExpress.DataAccess.Native.EntityFramework;
using DevExpress.Pdf.Native.BouncyCastle.Ocsp;
using LOGICPlayer;

namespace FRONTENDPlayer
{

    public partial class Dangnhap : DevExpress.XtraEditors.XtraForm
    {
        

        public Dangnhap()
        {
            InitializeComponent();
            this.AcceptButton = this.button_DangNhap;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

            DangKy dangky = new DangKy();
            dangky.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắn chắn muốn thoát ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            Logic_TaiKhoan logic_TaiKhoan = new Logic_TaiKhoan();

            label4_SaiTK.Visible = false;
            if (textBox_TaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_TaiKhoan.Focus();
            }
            else if (textBox_MatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_MatKhau.Focus();
            }
            else // Đăng nhập 
            {
                try
                {
                    Object[] Object_TaiKhoan = logic_TaiKhoan.KiemTraDangNhap(textBox_TaiKhoan.Text, textBox_MatKhau.Text);
                    // đk ok
                    if ((bool)Object_TaiKhoan[0] == true)
                    {
                        TrangChu trangChu = new TrangChu();
                        this.Hide();
                        trangChu.Show();
                    }
                    else // Sai tk, mk hoặc TK chưa kích hoạt
                    {
                        label4_SaiTK.Text = (String)Object_TaiKhoan[1];
                        label4_SaiTK.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }     
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            this.Hide();
            dangKy.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //DialogResult result Application.Exit();
            DialogResult result = MessageBox.Show("Bạn chắn chắn muốn thoát ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_DangNhap_Enter(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

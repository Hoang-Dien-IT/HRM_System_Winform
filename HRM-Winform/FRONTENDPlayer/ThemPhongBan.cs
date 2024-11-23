using DATAPlayer;
using DevExpress.XtraEditors;
using LOGICPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRONTENDPlayer
{
    public partial class ThemPhongBan : DevExpress.XtraEditors.XtraForm
    {
        public ThemPhongBan()
        {
            InitializeComponent();
            this.AcceptButton = this.simpleButton2_XacNhan;
        }

        private void ThemPhongBan_Load(object sender, EventArgs e)
        {
            textBox_MaPhongBan.Focus();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_MaPhongBan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng ban !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_MaPhongBan.Focus();
            }
            else if (textBox_MaPhongBan.Text.Trim().Length < 2)
            {
                MessageBox.Show("Vui lòng nhập mã phòng ban nhiều hơn 2 ký tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_MaPhongBan.Focus();
            }
            else if (textBox2_TenPhongBan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên phòng ban !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2_TenPhongBan.Focus();
            }
            else if (textBox3_TenVanPhong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên văn phòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3_TenVanPhong.Focus();
            }
            else
            {
                try
                {
                    PhongBanBackEnd phongBanBackEnd = new PhongBanBackEnd();

                    PhongBan phongBan = new PhongBan();
                    phongBan.MaPhongBan = textBox_MaPhongBan.Text.Trim();
                    phongBan.TenPhongBan = textBox2_TenPhongBan.Text.Trim();
                    phongBan.VanPhong = textBox3_TenVanPhong.Text.Trim();
                    phongBanBackEnd.Add(phongBan);
                    MessageBox.Show("Thêm phòng ban thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Thêm phòng ban thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void simpleButton2_XacNhan_Click(object sender, EventArgs e)
        {
            if (textBox_MaPhongBan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng ban !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_MaPhongBan.Focus();
            }
            else if (textBox_MaPhongBan.Text.Trim().Length < 2)
            {
                MessageBox.Show("Vui lòng nhập mã phòng ban nhiều hơn 2 ký tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_MaPhongBan.Focus();
            }
            else if (textBox2_TenPhongBan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên phòng ban !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2_TenPhongBan.Focus();
            }
            else if (textBox3_TenVanPhong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên văn phòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3_TenVanPhong.Focus();
            }
            else
            {
                try
                {
                    PhongBanBackEnd phongBanBackEnd = new PhongBanBackEnd();

                    PhongBan phongBan = new PhongBan();
                    phongBan.MaPhongBan = textBox_MaPhongBan.Text.Trim();
                    phongBan.TenPhongBan = textBox2_TenPhongBan.Text.Trim();
                    phongBan.VanPhong = textBox3_TenVanPhong.Text.Trim();
                    phongBanBackEnd.Add(phongBan);
                    MessageBox.Show("Thêm phòng ban thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Thêm phòng ban thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void simpleButton1_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
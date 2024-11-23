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
    public partial class SuaPhongBan : DevExpress.XtraEditors.XtraForm
    {
        public SuaPhongBan(string cot1, string cot2, string cot3)
        {
            InitializeComponent();
            textBox_MaPhongBan.Text = cot1;
            textBox2_TenPhongBan.Text = cot2;
            textBox3_TenVanPhong.Text = cot3;

            this.AcceptButton = this.simpleButton2_XacNhan;
        }

        private void simpleButton1_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_XacNhan_Click(object sender, EventArgs e)
        {
            if (textBox2_TenPhongBan.Text.Trim() == "")
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
                    phongBanBackEnd.Update(phongBan);

                    MessageBox.Show("Sửa phòng ban thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Sửa phòng ban thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
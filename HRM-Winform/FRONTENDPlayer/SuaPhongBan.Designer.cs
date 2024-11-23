namespace FRONTENDPlayer
{
    partial class SuaPhongBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox3_TenVanPhong = new System.Windows.Forms.TextBox();
            this.textBox2_TenPhongBan = new System.Windows.Forms.TextBox();
            this.textBox_MaPhongBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2_XacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // textBox3_TenVanPhong
            // 
            this.textBox3_TenVanPhong.Location = new System.Drawing.Point(181, 116);
            this.textBox3_TenVanPhong.Multiline = true;
            this.textBox3_TenVanPhong.Name = "textBox3_TenVanPhong";
            this.textBox3_TenVanPhong.Size = new System.Drawing.Size(233, 33);
            this.textBox3_TenVanPhong.TabIndex = 2;
            // 
            // textBox2_TenPhongBan
            // 
            this.textBox2_TenPhongBan.Location = new System.Drawing.Point(181, 71);
            this.textBox2_TenPhongBan.Multiline = true;
            this.textBox2_TenPhongBan.Name = "textBox2_TenPhongBan";
            this.textBox2_TenPhongBan.Size = new System.Drawing.Size(233, 33);
            this.textBox2_TenPhongBan.TabIndex = 1;
            // 
            // textBox_MaPhongBan
            // 
            this.textBox_MaPhongBan.Location = new System.Drawing.Point(181, 27);
            this.textBox_MaPhongBan.Multiline = true;
            this.textBox_MaPhongBan.Name = "textBox_MaPhongBan";
            this.textBox_MaPhongBan.ReadOnly = true;
            this.textBox_MaPhongBan.Size = new System.Drawing.Size(233, 33);
            this.textBox_MaPhongBan.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(61, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên Văn Phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(61, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Phòng Ban:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(64, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Phòng Ban:";
            // 
            // simpleButton1_Huy
            // 
            this.simpleButton1_Huy.Location = new System.Drawing.Point(340, 170);
            this.simpleButton1_Huy.Name = "simpleButton1_Huy";
            this.simpleButton1_Huy.Size = new System.Drawing.Size(86, 35);
            this.simpleButton1_Huy.TabIndex = 11;
            this.simpleButton1_Huy.Text = "Hủy";
            this.simpleButton1_Huy.Click += new System.EventHandler(this.simpleButton1_Huy_Click);
            // 
            // simpleButton2_XacNhan
            // 
            this.simpleButton2_XacNhan.Location = new System.Drawing.Point(447, 170);
            this.simpleButton2_XacNhan.Name = "simpleButton2_XacNhan";
            this.simpleButton2_XacNhan.Size = new System.Drawing.Size(86, 35);
            this.simpleButton2_XacNhan.TabIndex = 12;
            this.simpleButton2_XacNhan.Text = "Xác nhận";
            this.simpleButton2_XacNhan.Click += new System.EventHandler(this.simpleButton2_XacNhan_Click);
            // 
            // SuaPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 228);
            this.Controls.Add(this.simpleButton2_XacNhan);
            this.Controls.Add(this.simpleButton1_Huy);
            this.Controls.Add(this.textBox3_TenVanPhong);
            this.Controls.Add(this.textBox2_TenPhongBan);
            this.Controls.Add(this.textBox_MaPhongBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuaPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa phòng ban";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3_TenVanPhong;
        private System.Windows.Forms.TextBox textBox2_TenPhongBan;
        private System.Windows.Forms.TextBox textBox_MaPhongBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1_Huy;
        private DevExpress.XtraEditors.SimpleButton simpleButton2_XacNhan;
    }
}
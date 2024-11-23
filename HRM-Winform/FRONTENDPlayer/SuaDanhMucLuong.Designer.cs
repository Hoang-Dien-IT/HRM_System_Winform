namespace FRONTENDPlayer
{
    partial class SuaDanhMucLuong
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.dMLuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRMDataSet = new FRONTENDPlayer.HRMDataSet();
            this.dMChucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_ChucVuTableAdapter = new FRONTENDPlayer.HRMDataSetTableAdapters.DM_ChucVuTableAdapter();
            this.dM_LuongTableAdapter = new FRONTENDPlayer.HRMDataSetTableAdapters.DM_LuongTableAdapter();
            this.textBox_LuongCoBan = new System.Windows.Forms.TextBox();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.textBox_PhuCap = new System.Windows.Forms.TextBox();
            this.textBox_KhauTruThue = new System.Windows.Forms.TextBox();
            this.textBox_MaNhanVien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dMLuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMChucVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Khấu Trừ Thuế";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phụ Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lương Cơ Bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // simpleButton_Huy
            // 
            this.simpleButton_Huy.Location = new System.Drawing.Point(369, 200);
            this.simpleButton_Huy.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton_Huy.Name = "simpleButton_Huy";
            this.simpleButton_Huy.Size = new System.Drawing.Size(88, 28);
            this.simpleButton_Huy.TabIndex = 15;
            this.simpleButton_Huy.Text = "Hủy";
            this.simpleButton_Huy.Click += new System.EventHandler(this.simpleButton_Huy_Click);
            // 
            // simpleButton_Luu
            // 
            this.simpleButton_Luu.Location = new System.Drawing.Point(259, 200);
            this.simpleButton_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton_Luu.Name = "simpleButton_Luu";
            this.simpleButton_Luu.Size = new System.Drawing.Size(88, 28);
            this.simpleButton_Luu.TabIndex = 14;
            this.simpleButton_Luu.Text = "Lưu";
            this.simpleButton_Luu.Click += new System.EventHandler(this.simpleButton_Luu_Click);
            // 
            // dMLuongBindingSource
            // 
            this.dMLuongBindingSource.DataMember = "DM_Luong";
            this.dMLuongBindingSource.DataSource = this.hRMDataSetBindingSource;
            // 
            // hRMDataSetBindingSource
            // 
            this.hRMDataSetBindingSource.DataSource = this.hRMDataSet;
            this.hRMDataSetBindingSource.Position = 0;
            // 
            // hRMDataSet
            // 
            this.hRMDataSet.DataSetName = "HRMDataSet";
            this.hRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMChucVuBindingSource
            // 
            this.dMChucVuBindingSource.DataMember = "DM_ChucVu";
            this.dMChucVuBindingSource.DataSource = this.hRMDataSetBindingSource;
            // 
            // dM_ChucVuTableAdapter
            // 
            this.dM_ChucVuTableAdapter.ClearBeforeFill = true;
            // 
            // dM_LuongTableAdapter
            // 
            this.dM_LuongTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_LuongCoBan
            // 
            this.textBox_LuongCoBan.Location = new System.Drawing.Point(135, 70);
            this.textBox_LuongCoBan.Name = "textBox_LuongCoBan";
            this.textBox_LuongCoBan.Size = new System.Drawing.Size(158, 23);
            this.textBox_LuongCoBan.TabIndex = 23;
            // 
            // textBox_PhuCap
            // 
            this.textBox_PhuCap.Location = new System.Drawing.Point(135, 111);
            this.textBox_PhuCap.Name = "textBox_PhuCap";
            this.textBox_PhuCap.Size = new System.Drawing.Size(158, 23);
            this.textBox_PhuCap.TabIndex = 24;
            // 
            // textBox_KhauTruThue
            // 
            this.textBox_KhauTruThue.Location = new System.Drawing.Point(135, 152);
            this.textBox_KhauTruThue.Name = "textBox_KhauTruThue";
            this.textBox_KhauTruThue.Size = new System.Drawing.Size(158, 23);
            this.textBox_KhauTruThue.TabIndex = 25;
            // 
            // textBox_MaNhanVien
            // 
            this.textBox_MaNhanVien.Location = new System.Drawing.Point(135, 26);
            this.textBox_MaNhanVien.Name = "textBox_MaNhanVien";
            this.textBox_MaNhanVien.Size = new System.Drawing.Size(158, 23);
            this.textBox_MaNhanVien.TabIndex = 26;
            this.textBox_MaNhanVien.Enabled = false;
            this.textBox_MaNhanVien.ReadOnly = true;
            // 
            // SuaDanhMucLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 250);
            this.Controls.Add(this.textBox_MaNhanVien);
            this.Controls.Add(this.textBox_KhauTruThue);
            this.Controls.Add(this.textBox_PhuCap);
            this.Controls.Add(this.textBox_LuongCoBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton_Huy);
            this.Controls.Add(this.simpleButton_Luu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SuaDanhMucLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Danh Mục Lương";
            ((System.ComponentModel.ISupportInitialize)(this.dMLuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMChucVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Huy;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Luu;
        private System.Windows.Forms.BindingSource hRMDataSetBindingSource;
        private HRMDataSet hRMDataSet;
        private System.Windows.Forms.BindingSource dMChucVuBindingSource;
        private HRMDataSetTableAdapters.DM_ChucVuTableAdapter dM_ChucVuTableAdapter;
        private System.Windows.Forms.BindingSource dMLuongBindingSource;
        private HRMDataSetTableAdapters.DM_LuongTableAdapter dM_LuongTableAdapter;
        private System.Windows.Forms.TextBox textBox_LuongCoBan;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.TextBox textBox_PhuCap;
        private System.Windows.Forms.TextBox textBox_KhauTruThue;
        private System.Windows.Forms.TextBox textBox_MaNhanVien;
    }
}
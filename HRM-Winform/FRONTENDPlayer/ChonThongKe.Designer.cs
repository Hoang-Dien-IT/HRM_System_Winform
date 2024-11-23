namespace FRONTENDPlayer
{
    partial class ChonThongKe
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.label3_TongLuong = new System.Windows.Forms.Label();
            this.label3_CanhBao = new System.Windows.Forms.Label();
            this.simpleButton2_XacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEdit2_DateKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dateEdit1_DateBatDau = new DevExpress.XtraEditors.DateEdit();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.hRMDataSet = new FRONTENDPlayer.HRMDataSet();
            this.luongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.luongTableAdapter = new FRONTENDPlayer.HRMDataSetTableAdapters.LuongTableAdapter();
            this.label3_tbLuongThang = new System.Windows.Forms.Label();
            this.label4_LuongTBNV = new System.Windows.Forms.Label();
            this.label5_LuongNVCaoNhat = new System.Windows.Forms.Label();
            this.label6_LuongNVThapNhat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2_DateKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2_DateKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1_DateBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1_DateBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel1.Controls.Add(this.label6_LuongNVThapNhat);
            this.splitContainerControl1.Panel1.Controls.Add(this.label5_LuongNVCaoNhat);
            this.splitContainerControl1.Panel1.Controls.Add(this.label4_LuongTBNV);
            this.splitContainerControl1.Panel1.Controls.Add(this.label3_tbLuongThang);
            this.splitContainerControl1.Panel1.Controls.Add(this.label3_TongLuong);
            this.splitContainerControl1.Panel1.Controls.Add(this.label3_CanhBao);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton2_XacNhan);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton1_Huy);
            this.splitContainerControl1.Panel1.Controls.Add(this.label2);
            this.splitContainerControl1.Panel1.Controls.Add(this.dateEdit2_DateKetThuc);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Controls.Add(this.dateEdit1_DateBatDau);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.chartControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1033, 637);
            this.splitContainerControl1.SplitterPosition = 329;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // label3_TongLuong
            // 
            this.label3_TongLuong.AutoSize = true;
            this.label3_TongLuong.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3_TongLuong.Location = new System.Drawing.Point(8, 243);
            this.label3_TongLuong.Name = "label3_TongLuong";
            this.label3_TongLuong.Size = new System.Drawing.Size(108, 19);
            this.label3_TongLuong.TabIndex = 25;
            this.label3_TongLuong.Text = "Tổng lương:";
            this.label3_TongLuong.Visible = false;
            // 
            // label3_CanhBao
            // 
            this.label3_CanhBao.AutoSize = true;
            this.label3_CanhBao.ForeColor = System.Drawing.Color.Red;
            this.label3_CanhBao.Location = new System.Drawing.Point(31, 77);
            this.label3_CanhBao.Name = "label3_CanhBao";
            this.label3_CanhBao.Size = new System.Drawing.Size(246, 16);
            this.label3_CanhBao.TabIndex = 24;
            this.label3_CanhBao.Text = "Tháng kết thúc phải bé hơn tháng bắt đầu";
            this.label3_CanhBao.Visible = false;
            // 
            // simpleButton2_XacNhan
            // 
            this.simpleButton2_XacNhan.Appearance.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton2_XacNhan.Appearance.Options.UseFont = true;
            this.simpleButton2_XacNhan.Location = new System.Drawing.Point(171, 165);
            this.simpleButton2_XacNhan.Name = "simpleButton2_XacNhan";
            this.simpleButton2_XacNhan.Size = new System.Drawing.Size(87, 36);
            this.simpleButton2_XacNhan.TabIndex = 23;
            this.simpleButton2_XacNhan.Text = "Xác nhận";
            this.simpleButton2_XacNhan.Click += new System.EventHandler(this.simpleButton2_XacNhan_Click_1);
            // 
            // simpleButton1_Huy
            // 
            this.simpleButton1_Huy.Appearance.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton1_Huy.Appearance.Options.UseFont = true;
            this.simpleButton1_Huy.Location = new System.Drawing.Point(65, 165);
            this.simpleButton1_Huy.Name = "simpleButton1_Huy";
            this.simpleButton1_Huy.Size = new System.Drawing.Size(87, 36);
            this.simpleButton1_Huy.TabIndex = 22;
            this.simpleButton1_Huy.Text = "Hủy";
            this.simpleButton1_Huy.Click += new System.EventHandler(this.simpleButton1_Huy_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Đến:";
            // 
            // dateEdit2_DateKetThuc
            // 
            this.dateEdit2_DateKetThuc.EditValue = null;
            this.dateEdit2_DateKetThuc.Location = new System.Drawing.Point(72, 96);
            this.dateEdit2_DateKetThuc.Name = "dateEdit2_DateKetThuc";
            this.dateEdit2_DateKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2_DateKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2_DateKetThuc.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dateEdit2_DateKetThuc.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.dateEdit2_DateKetThuc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit2_DateKetThuc.Properties.EditFormat.FormatString = "MM/yyyy";
            this.dateEdit2_DateKetThuc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit2_DateKetThuc.Properties.MaskSettings.Set("mask", "MM/yyyy");
            this.dateEdit2_DateKetThuc.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit2_DateKetThuc.Size = new System.Drawing.Size(170, 34);
            this.dateEdit2_DateKetThuc.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Từ:";
            // 
            // dateEdit1_DateBatDau
            // 
            this.dateEdit1_DateBatDau.EditValue = null;
            this.dateEdit1_DateBatDau.Location = new System.Drawing.Point(72, 33);
            this.dateEdit1_DateBatDau.Name = "dateEdit1_DateBatDau";
            this.dateEdit1_DateBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1_DateBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1_DateBatDau.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dateEdit1_DateBatDau.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.dateEdit1_DateBatDau.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1_DateBatDau.Properties.EditFormat.FormatString = "MM/yyyy";
            this.dateEdit1_DateBatDau.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1_DateBatDau.Properties.MaskSettings.Set("mask", "MM/yyyy");
            this.dateEdit1_DateBatDau.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit1_DateBatDau.Size = new System.Drawing.Size(170, 34);
            this.dateEdit1_DateBatDau.TabIndex = 18;
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(684, 637);
            this.chartControl1.TabIndex = 0;
            // 
            // hRMDataSet
            // 
            this.hRMDataSet.DataSetName = "HRMDataSet";
            this.hRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // luongBindingSource
            // 
            this.luongBindingSource.DataMember = "Luong";
            this.luongBindingSource.DataSource = this.hRMDataSet;
            // 
            // luongTableAdapter
            // 
            this.luongTableAdapter.ClearBeforeFill = true;
            // 
            // label3_tbLuongThang
            // 
            this.label3_tbLuongThang.AutoSize = true;
            this.label3_tbLuongThang.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3_tbLuongThang.Location = new System.Drawing.Point(8, 296);
            this.label3_tbLuongThang.Name = "label3_tbLuongThang";
            this.label3_tbLuongThang.Size = new System.Drawing.Size(140, 19);
            this.label3_tbLuongThang.TabIndex = 26;
            this.label3_tbLuongThang.Text = "TB tháng lương:";
            this.label3_tbLuongThang.Visible = false;
            this.label3_tbLuongThang.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4_LuongTBNV
            // 
            this.label4_LuongTBNV.AutoSize = true;
            this.label4_LuongTBNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4_LuongTBNV.Location = new System.Drawing.Point(8, 344);
            this.label4_LuongTBNV.Name = "label4_LuongTBNV";
            this.label4_LuongTBNV.Size = new System.Drawing.Size(306, 19);
            this.label4_LuongTBNV.TabIndex = 27;
            this.label4_LuongTBNV.Text = "Lương trung bình: 2.000.000.000 VND";
            this.label4_LuongTBNV.Visible = false;
            this.label4_LuongTBNV.Click += new System.EventHandler(this.label4_LuongTBNV_Click);
            // 
            // label5_LuongNVCaoNhat
            // 
            this.label5_LuongNVCaoNhat.AutoSize = true;
            this.label5_LuongNVCaoNhat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5_LuongNVCaoNhat.Location = new System.Drawing.Point(8, 391);
            this.label5_LuongNVCaoNhat.Name = "label5_LuongNVCaoNhat";
            this.label5_LuongNVCaoNhat.Size = new System.Drawing.Size(142, 19);
            this.label5_LuongNVCaoNhat.TabIndex = 28;
            this.label5_LuongNVCaoNhat.Text = "Lương cao nhất:";
            this.label5_LuongNVCaoNhat.Visible = false;
            // 
            // label6_LuongNVThapNhat
            // 
            this.label6_LuongNVThapNhat.AutoSize = true;
            this.label6_LuongNVThapNhat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6_LuongNVThapNhat.Location = new System.Drawing.Point(8, 439);
            this.label6_LuongNVThapNhat.Name = "label6_LuongNVThapNhat";
            this.label6_LuongNVThapNhat.Size = new System.Drawing.Size(149, 19);
            this.label6_LuongNVThapNhat.TabIndex = 29;
            this.label6_LuongNVThapNhat.Text = "Lương thấp nhất:";
            this.label6_LuongNVThapNhat.Visible = false;
            // 
            // ChonThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 637);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ChonThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Lương";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChonThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2_DateKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2_DateKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1_DateBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1_DateBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.Label label3_CanhBao;
        private DevExpress.XtraEditors.SimpleButton simpleButton2_XacNhan;
        private DevExpress.XtraEditors.SimpleButton simpleButton1_Huy;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dateEdit2_DateKetThuc;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateEdit1_DateBatDau;
        private System.Windows.Forms.Label label3_TongLuong;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private HRMDataSet hRMDataSet;
        private System.Windows.Forms.BindingSource luongBindingSource;
        private HRMDataSetTableAdapters.LuongTableAdapter luongTableAdapter;
        private System.Windows.Forms.Label label4_LuongTBNV;
        private System.Windows.Forms.Label label3_tbLuongThang;
        private System.Windows.Forms.Label label5_LuongNVCaoNhat;
        private System.Windows.Forms.Label label6_LuongNVThapNhat;
    }
}
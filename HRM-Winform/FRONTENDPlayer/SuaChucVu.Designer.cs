namespace FRONTENDPlayer
{
    partial class SuaChucVu
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
            this.textEdit_TenChucVu = new DevExpress.XtraEditors.TextEdit();
            this.label_TenChucVu = new DevExpress.XtraEditors.LabelControl();
            this.dMChucVuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hRMDataSet = new FRONTENDPlayer.HRMDataSet();
            this.dMChucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit_MaChucVu = new DevExpress.XtraEditors.TextEdit();
            this.lable_MaChuVu = new DevExpress.XtraEditors.LabelControl();
            this.label_HeSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dM_ChucVuTableAdapter = new FRONTENDPlayer.HRMDataSetTableAdapters.DM_ChucVuTableAdapter();
            this.simpleButton_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMChucVuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMChucVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit_TenChucVu
            // 
            this.textEdit_TenChucVu.Location = new System.Drawing.Point(112, 68);
            this.textEdit_TenChucVu.Margin = new System.Windows.Forms.Padding(8);
            this.textEdit_TenChucVu.Name = "textEdit_TenChucVu";
            this.textEdit_TenChucVu.Size = new System.Drawing.Size(247, 34);
            this.textEdit_TenChucVu.TabIndex = 14;
            // 
            // label_TenChucVu
            // 
            this.label_TenChucVu.Location = new System.Drawing.Point(22, 77);
            this.label_TenChucVu.Margin = new System.Windows.Forms.Padding(8);
            this.label_TenChucVu.Name = "label_TenChucVu";
            this.label_TenChucVu.Size = new System.Drawing.Size(74, 16);
            this.label_TenChucVu.TabIndex = 11;
            this.label_TenChucVu.Text = "Tên Chức Vụ";
            // 
            // dMChucVuBindingSource1
            // 
            this.dMChucVuBindingSource1.DataMember = "DM_ChucVu";
            this.dMChucVuBindingSource1.DataSource = this.hRMDataSet;
            // 
            // hRMDataSet
            // 
            this.hRMDataSet.DataSetName = "HRMDataSet";
            this.hRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMChucVuBindingSource
            // 
            this.dMChucVuBindingSource.DataMember = "DM_ChucVu";
            this.dMChucVuBindingSource.DataSource = this.hRMDataSet;
            // 
            // textEdit_MaChucVu
            // 
            this.textEdit_MaChucVu.Location = new System.Drawing.Point(112, 17);
            this.textEdit_MaChucVu.Margin = new System.Windows.Forms.Padding(8);
            this.textEdit_MaChucVu.Name = "textEdit_MaChucVu";
            this.textEdit_MaChucVu.Properties.ReadOnly = true;
            this.textEdit_MaChucVu.Size = new System.Drawing.Size(152, 34);
            this.textEdit_MaChucVu.TabIndex = 13;
            // 
            // lable_MaChuVu
            // 
            this.lable_MaChuVu.Location = new System.Drawing.Point(27, 26);
            this.lable_MaChuVu.Margin = new System.Windows.Forms.Padding(8);
            this.lable_MaChuVu.Name = "lable_MaChuVu";
            this.lable_MaChuVu.Size = new System.Drawing.Size(69, 16);
            this.lable_MaChuVu.TabIndex = 10;
            this.lable_MaChuVu.Text = "Mã Chức Vụ";
            // 
            // label_HeSoLuong
            // 
            this.label_HeSoLuong.Location = new System.Drawing.Point(22, 131);
            this.label_HeSoLuong.Margin = new System.Windows.Forms.Padding(8);
            this.label_HeSoLuong.Name = "label_HeSoLuong";
            this.label_HeSoLuong.Size = new System.Drawing.Size(73, 16);
            this.label_HeSoLuong.TabIndex = 12;
            this.label_HeSoLuong.Text = "Hệ Số Lương";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(566, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 189);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(566, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 189);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(566, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 189);
            // 
            // dM_ChucVuTableAdapter
            // 
            this.dM_ChucVuTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton_Luu
            // 
            this.simpleButton_Luu.Location = new System.Drawing.Point(456, 145);
            this.simpleButton_Luu.Name = "simpleButton_Luu";
            this.simpleButton_Luu.Size = new System.Drawing.Size(94, 29);
            this.simpleButton_Luu.TabIndex = 23;
            this.simpleButton_Luu.Text = "Lưu";
            this.simpleButton_Luu.Click += new System.EventHandler(this.simpleButton_Luu_Click);
            // 
            // simpleButton1_Huy
            // 
            this.simpleButton1_Huy.Location = new System.Drawing.Point(356, 145);
            this.simpleButton1_Huy.Name = "simpleButton1_Huy";
            this.simpleButton1_Huy.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1_Huy.TabIndex = 24;
            this.simpleButton1_Huy.Text = "Hủy";
            this.simpleButton1_Huy.Click += new System.EventHandler(this.simpleButton1_Huy_Click);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(112, 122);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HeSoLuong", "Hệ số lương")});
            this.lookUpEdit1.Properties.DataSource = this.dMChucVuBindingSource1;
            this.lookUpEdit1.Properties.DisplayMember = "HeSoLuong";
            this.lookUpEdit1.Properties.NullText = "Hệ số lương";
            this.lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit1.Properties.ValueMember = "HeSoLuong";
            this.lookUpEdit1.Size = new System.Drawing.Size(125, 34);
            this.lookUpEdit1.TabIndex = 12;
            // 
            // SuaChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 189);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.simpleButton1_Huy);
            this.Controls.Add(this.simpleButton_Luu);
            this.Controls.Add(this.textEdit_TenChucVu);
            this.Controls.Add(this.textEdit_MaChucVu);
            this.Controls.Add(this.label_HeSoLuong);
            this.Controls.Add(this.label_TenChucVu);
            this.Controls.Add(this.lable_MaChuVu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SuaChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Chức Vụ";
            this.Load += new System.EventHandler(this.SuaChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMChucVuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMChucVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MaChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit_TenChucVu;
        private DevExpress.XtraEditors.LabelControl label_TenChucVu;
        private DevExpress.XtraEditors.TextEdit textEdit_MaChucVu;
        private DevExpress.XtraEditors.LabelControl lable_MaChuVu;
        private DevExpress.XtraEditors.LabelControl label_HeSoLuong;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private HRMDataSet hRMDataSet;
        private System.Windows.Forms.BindingSource dMChucVuBindingSource;
        private HRMDataSetTableAdapters.DM_ChucVuTableAdapter dM_ChucVuTableAdapter;
        private System.Windows.Forms.BindingSource dMChucVuBindingSource1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1_Huy;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Luu;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}
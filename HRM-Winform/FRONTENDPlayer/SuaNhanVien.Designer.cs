using System.Windows.Forms;

namespace FRONTENDPlayer
{
    partial class SuaNhanVien
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
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtSdt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.cmbPhongBan = new DevExpress.XtraEditors.LookUpEdit();
            this.phongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tKDHRMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HRMDataSet = new FRONTENDPlayer.HRMDataSet();
            this.cmbChucVu = new DevExpress.XtraEditors.LookUpEdit();
            this.dMChucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.phongBanTableAdapter = new FRONTENDPlayer.HRMDataSetTableAdapters.PhongBanTableAdapter();
            this.dM_ChucVuTableAdapter = new FRONTENDPlayer.HRMDataSetTableAdapters.DM_ChucVuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPhongBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKDHRMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMChucVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(143, 36);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Properties.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(156, 34);
            this.txtMaNhanVien.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(60, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã nhân viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(55, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên nhân viên";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(97, 138);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 16);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(61, 185);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 16);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Số điện thoại";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(143, 84);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(156, 34);
            this.txtTenNhanVien.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(143, 131);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(156, 34);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(143, 178);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(156, 34);
            this.txtSdt.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(81, 231);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 16);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Ngày sinh";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(391, 277);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(94, 29);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.Text = "Lưu";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(506, 277);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbPhongBan
            // 
            this.cmbPhongBan.Location = new System.Drawing.Point(360, 36);
            this.cmbPhongBan.Name = "cmbPhongBan";
            this.cmbPhongBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPhongBan.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenPhongBan", "Tên Phòng Ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VanPhong", "Văn Phòng")});
            this.cmbPhongBan.Properties.DataSource = this.phongBanBindingSource;
            this.cmbPhongBan.Properties.DisplayMember = "TenPhongBan";
            this.cmbPhongBan.Properties.NullText = "Phòng Ban";
            this.cmbPhongBan.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbPhongBan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbPhongBan.Properties.ValueMember = "MaPhongBan";
            this.cmbPhongBan.Size = new System.Drawing.Size(125, 34);
            this.cmbPhongBan.TabIndex = 11;
            // 
            // phongBanBindingSource
            // 
            this.phongBanBindingSource.DataMember = "PhongBan";
            this.phongBanBindingSource.DataSource = this.tKDHRMDataSetBindingSource;
            // 
            // tKDHRMDataSetBindingSource
            // 
            this.tKDHRMDataSetBindingSource.DataSource = this.HRMDataSet;
            this.tKDHRMDataSetBindingSource.Position = 0;
            // 
            // HRMDataSet
            // 
            this.HRMDataSet.DataSetName = "TKD_HRMDataSet";
            this.HRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.Location = new System.Drawing.Point(515, 36);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbChucVu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenChucVu", "Tên Chức Vụ")});
            this.cmbChucVu.Properties.DataSource = this.dMChucVuBindingSource;
            this.cmbChucVu.Properties.DisplayMember = "TenChucVu";
            this.cmbChucVu.Properties.NullText = "Chức Vụ";
            this.cmbChucVu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbChucVu.Properties.ValueMember = "MaChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(125, 34);
            this.cmbChucVu.TabIndex = 12;
            // 
            // dMChucVuBindingSource
            // 
            this.dMChucVuBindingSource.DataMember = "DM_ChucVu";
            this.dMChucVuBindingSource.DataSource = this.tKDHRMDataSetBindingSource;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.EditValue = new System.DateTime(2024, 10, 19, 0, 0, 0, 0);
            this.dateNgaySinh.Location = new System.Drawing.Point(142, 224);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dateNgaySinh.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dateNgaySinh.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.dateNgaySinh.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.dateNgaySinh.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateNgaySinh.Size = new System.Drawing.Size(156, 34);
            this.dateNgaySinh.TabIndex = 10;
            this.dateNgaySinh.EditValueChanged += new System.EventHandler(this.dateNgaySinh_EditValueChanged);
            // 
            // phongBanTableAdapter
            // 
            this.phongBanTableAdapter.ClearBeforeFill = true;
            // 
            // dM_ChucVuTableAdapter
            // 
            this.dM_ChucVuTableAdapter.ClearBeforeFill = true;
            // 
            // SuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 355);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.cmbChucVu);
            this.Controls.Add(this.cmbPhongBan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtMaNhanVien);
            this.Name = "SuaNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Thông Tin Nhân Viên";
            this.Load += new System.EventHandler(this.frmSuaNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPhongBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKDHRMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMChucVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTenNhanVien;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtSdt;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.LookUpEdit cmbPhongBan;
        private DevExpress.XtraEditors.LookUpEdit cmbChucVu;
        private DevExpress.XtraEditors.DateEdit dateNgaySinh;
        private BindingSource tKDHRMDataSetBindingSource;

        private HRMDataSet HRMDataSet;

        private BindingSource phongBanBindingSource;
        private HRMDataSetTableAdapters.PhongBanTableAdapter phongBanTableAdapter;
        private BindingSource dMChucVuBindingSource;
        private HRMDataSetTableAdapters.DM_ChucVuTableAdapter dM_ChucVuTableAdapter;
    }
}


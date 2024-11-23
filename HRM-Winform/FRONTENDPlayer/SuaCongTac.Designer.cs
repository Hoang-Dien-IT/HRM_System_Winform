using System.Data;
using System;
using System.Windows.Forms;
using DevExpress.Data.Helpers;

namespace FRONTENDPlayer
{
    partial class SuaCongTac
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.NgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.NgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.cmbNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRMDataSet = new FRONTENDPlayer.HRMDataSet();
            this.GhiChu = new DevExpress.XtraEditors.LabelControl();
            this.nhanVienTableAdapter = new FRONTENDPlayer.HRMDataSetTableAdapters.NhanVienTableAdapter();
            this.cmbMaCT = new DevExpress.XtraEditors.LookUpEdit();
            this.qTCongTacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qT_CongTacTableAdapter = new FRONTENDPlayer.HRMDataSetTableAdapters.QT_CongTacTableAdapter();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qTCongTacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(41, 99);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã nhân viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(47, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mã công tác";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(362, 46);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 16);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Ngày bắt đầu";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(360, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 16);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Ngày kết thúc";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(401, 264);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(517, 264);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.EditValue = new System.DateTime(2024, 10, 28, 0, 0, 0, 0);
            this.NgayBatDau.Location = new System.Drawing.Point(455, 36);
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgayBatDau.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.NgayBatDau.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.NgayBatDau.Properties.MaskSettings.Set("useAdvancingCaret", null);
            this.NgayBatDau.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.NgayBatDau.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.NgayBatDau.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.NgayBatDau.Size = new System.Drawing.Size(156, 34);
            this.NgayBatDau.TabIndex = 10;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.EditValue = new System.DateTime(2024, 10, 28, 0, 0, 0, 0);
            this.NgayKetThuc.Location = new System.Drawing.Point(455, 89);
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgayKetThuc.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.NgayKetThuc.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.NgayKetThuc.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.NgayKetThuc.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.NgayKetThuc.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.NgayKetThuc.Size = new System.Drawing.Size(156, 34);
            this.NgayKetThuc.TabIndex = 15;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.Enabled = false;
            this.cmbNhanVien.Location = new System.Drawing.Point(142, 89);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNhanVien.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNhanVien", "Mã chức vụ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNhanVien", "Tên nhân viên")});
            this.cmbNhanVien.Properties.DataSource = this.nhanVienBindingSource;
            this.cmbNhanVien.Properties.DisplayMember = "MaNhanVien";
            this.cmbNhanVien.Properties.NullText = "Nhân Viên";
            this.cmbNhanVien.Properties.ReadOnly = true;
            this.cmbNhanVien.Properties.ValueMember = "MaNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(156, 34);
            this.cmbNhanVien.TabIndex = 12;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.hRMDataSet;
            // 
            // hRMDataSet
            // 
            this.hRMDataSet.DataSetName = "HRMDataSet";
            this.hRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GhiChu
            // 
            this.GhiChu.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GhiChu.Appearance.Options.UseFont = true;
            this.GhiChu.Location = new System.Drawing.Point(74, 186);
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Size = new System.Drawing.Size(42, 16);
            this.GhiChu.TabIndex = 16;
            this.GhiChu.Text = "Ghi chú";
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // cmbMaCT
            // 
            this.cmbMaCT.Enabled = false;
            this.cmbMaCT.Location = new System.Drawing.Point(142, 28);
            this.cmbMaCT.Name = "cmbMaCT";
            this.cmbMaCT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMaCT.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaCT", "Mã công tác")});
            this.cmbMaCT.Properties.DataSource = this.qTCongTacBindingSource;
            this.cmbMaCT.Properties.DisplayMember = "MaCT";
            this.cmbMaCT.Properties.NullText = "Mã công tác";
            this.cmbMaCT.Properties.ReadOnly = true;
            this.cmbMaCT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbMaCT.Properties.ValueMember = "MaCT";
            this.cmbMaCT.Size = new System.Drawing.Size(156, 34);
            this.cmbMaCT.TabIndex = 17;
            // 
            // qTCongTacBindingSource
            // 
            this.qTCongTacBindingSource.DataMember = "QT_CongTac";
            this.qTCongTacBindingSource.DataSource = this.hRMDataSet;
            // 
            // qT_CongTacTableAdapter
            // 
            this.qT_CongTacTableAdapter.ClearBeforeFill = true;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(142, 139);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(469, 104);
            this.txtGhiChu.TabIndex = 18;
            // 
            // SuaCongTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 326);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.cmbMaCT);
            this.Controls.Add(this.GhiChu);
            this.Controls.Add(this.NgayKetThuc);
            this.Controls.Add(this.NgayBatDau);
            this.Controls.Add(this.cmbNhanVien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "SuaCongTac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa công tác";
            this.Load += new System.EventHandler(this.SuaCongTac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qTCongTacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.DateEdit NgayBatDau;
        private DevExpress.XtraEditors.DateEdit NgayKetThuc;
        private DevExpress.XtraEditors.LookUpEdit cmbNhanVien;
        private DevExpress.XtraEditors.LabelControl GhiChu;
        private HRMDataSet hRMDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private HRMDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit cmbMaCT;
        private System.Windows.Forms.BindingSource qTCongTacBindingSource;
        private HRMDataSetTableAdapters.QT_CongTacTableAdapter qT_CongTacTableAdapter;
        private TextBox txtGhiChu;
    }

}
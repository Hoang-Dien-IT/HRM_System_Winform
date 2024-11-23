namespace FRONTENDPlayer
{
    partial class InLuong
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
            this.ThangNamIn = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Huy = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_In = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ThangNamIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThangNamIn.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ThangNamIn
            // 
            this.ThangNamIn.EditValue = null;
            this.ThangNamIn.Location = new System.Drawing.Point(123, 36);
            this.ThangNamIn.Name = "ThangNamIn";
            this.ThangNamIn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ThangNamIn.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ThangNamIn.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.ThangNamIn.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.ThangNamIn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ThangNamIn.Properties.EditFormat.FormatString = "MM/yyyy";
            this.ThangNamIn.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ThangNamIn.Properties.MaskSettings.Set("mask", "MM/yyyy");
            this.ThangNamIn.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.ThangNamIn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ThangNamIn.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.ThangNamIn.Size = new System.Drawing.Size(125, 34);
            this.ThangNamIn.TabIndex = 0;
            this.ThangNamIn.EditValueChanged += new System.EventHandler(this.ThangNamIn_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tháng Năm";
            // 
            // Huy
            // 
            this.Huy.Location = new System.Drawing.Point(227, 112);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(94, 29);
            this.Huy.TabIndex = 2;
            this.Huy.Text = "Hủy";
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // simpleButton_In
            // 
            this.simpleButton_In.Location = new System.Drawing.Point(327, 112);
            this.simpleButton_In.Name = "simpleButton_In";
            this.simpleButton_In.Size = new System.Drawing.Size(94, 29);
            this.simpleButton_In.TabIndex = 3;
            this.simpleButton_In.Text = "In";
            this.simpleButton_In.Click += new System.EventHandler(this.simpleButton_In_Click);
            // 
            // InLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 156);
            this.Controls.Add(this.simpleButton_In);
            this.Controls.Add(this.Huy);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ThangNamIn);
            this.Name = "InLuong";
            this.Text = "InLuong";
            ((System.ComponentModel.ISupportInitialize)(this.ThangNamIn.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThangNamIn.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit ThangNamIn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton Huy;
        private DevExpress.XtraEditors.SimpleButton simpleButton_In;
    }
}
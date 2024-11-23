namespace FRONTENDPlayer
{
    partial class frmPhongBan1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongBan1));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.gridControl1_PhongBan = new DevExpress.XtraGrid.GridControl();
            this.phongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRMDataSet = new FRONTENDPlayer.HRMDataSet();
            this.gridView1_PhongBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhongBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenPhongBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVanPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phongBanTableAdapter = new FRONTENDPlayer.HRMDataSetTableAdapters.PhongBanTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1_PhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1_PhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3_Xoa,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3_Xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3_Xoa
            // 
            this.barButtonItem3_Xoa.Caption = "Xóa";
            this.barButtonItem3_Xoa.Id = 8;
            this.barButtonItem3_Xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3_Xoa.ImageOptions.SvgImage")));
            this.barButtonItem3_Xoa.Name = "barButtonItem3_Xoa";
            this.barButtonItem3_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_Xoa_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Đóng";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(911, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 501);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(911, 29);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 454);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(911, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 454);
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // gridControl1_PhongBan
            // 
            this.gridControl1_PhongBan.DataSource = this.phongBanBindingSource;
            this.gridControl1_PhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1_PhongBan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1_PhongBan.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridControl1_PhongBan.Location = new System.Drawing.Point(0, 47);
            this.gridControl1_PhongBan.MainView = this.gridView1_PhongBan;
            this.gridControl1_PhongBan.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1_PhongBan.MenuManager = this.barManager1;
            this.gridControl1_PhongBan.Name = "gridControl1_PhongBan";
            this.gridControl1_PhongBan.Size = new System.Drawing.Size(911, 454);
            this.gridControl1_PhongBan.TabIndex = 4;
            this.gridControl1_PhongBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1_PhongBan});
            this.gridControl1_PhongBan.Click += new System.EventHandler(this.gridControl1_PhongBan_Click);
            // 
            // phongBanBindingSource
            // 
            this.phongBanBindingSource.DataMember = "PhongBan";
            this.phongBanBindingSource.DataSource = this.hRMDataSet;
            // 
            // hRMDataSet
            // 
            this.hRMDataSet.DataSetName = "HRMDataSet";
            this.hRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1_PhongBan
            // 
            this.gridView1_PhongBan.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 7.8F);
            this.gridView1_PhongBan.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1_PhongBan.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 7.8F);
            this.gridView1_PhongBan.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1_PhongBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhongBan,
            this.colTenPhongBan,
            this.colVanPhong});
            this.gridView1_PhongBan.DetailHeight = 546;
            this.gridView1_PhongBan.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1_PhongBan.GridControl = this.gridControl1_PhongBan;
            this.gridView1_PhongBan.Name = "gridView1_PhongBan";
            this.gridView1_PhongBan.OptionsBehavior.Editable = false;
            this.gridView1_PhongBan.OptionsBehavior.ReadOnly = true;
            this.gridView1_PhongBan.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1_PhongBan.OptionsEditForm.PopupEditFormWidth = 1250;
            this.gridView1_PhongBan.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1_PhongBan.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView1_PhongBan.OptionsFind.AlwaysVisible = true;
            this.gridView1_PhongBan.OptionsFind.FindDelay = 100;
            this.gridView1_PhongBan.OptionsFind.SearchInPreview = true;
            this.gridView1_PhongBan.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTenPhongBan, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMaPhongBan
            // 
            this.colMaPhongBan.AppearanceCell.Font = new System.Drawing.Font("Arial", 7.8F);
            this.colMaPhongBan.AppearanceCell.Options.UseFont = true;
            this.colMaPhongBan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colMaPhongBan.AppearanceHeader.Options.UseFont = true;
            this.colMaPhongBan.Caption = "Mã Phòng Ban";
            this.colMaPhongBan.FieldName = "MaPhongBan";
            this.colMaPhongBan.MinWidth = 39;
            this.colMaPhongBan.Name = "colMaPhongBan";
            this.colMaPhongBan.Visible = true;
            this.colMaPhongBan.VisibleIndex = 0;
            this.colMaPhongBan.Width = 146;
            // 
            // colTenPhongBan
            // 
            this.colTenPhongBan.AppearanceCell.Font = new System.Drawing.Font("Arial", 7.8F);
            this.colTenPhongBan.AppearanceCell.Options.UseFont = true;
            this.colTenPhongBan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colTenPhongBan.AppearanceHeader.Options.UseFont = true;
            this.colTenPhongBan.Caption = "Tên Phòng Ban";
            this.colTenPhongBan.FieldName = "TenPhongBan";
            this.colTenPhongBan.MinWidth = 39;
            this.colTenPhongBan.Name = "colTenPhongBan";
            this.colTenPhongBan.Visible = true;
            this.colTenPhongBan.VisibleIndex = 1;
            this.colTenPhongBan.Width = 146;
            // 
            // colVanPhong
            // 
            this.colVanPhong.AppearanceCell.Font = new System.Drawing.Font("Arial", 7.8F);
            this.colVanPhong.AppearanceCell.Options.UseFont = true;
            this.colVanPhong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colVanPhong.AppearanceHeader.Options.UseFont = true;
            this.colVanPhong.Caption = "Văn Phòng";
            this.colVanPhong.FieldName = "VanPhong";
            this.colVanPhong.MinWidth = 39;
            this.colVanPhong.Name = "colVanPhong";
            this.colVanPhong.Visible = true;
            this.colVanPhong.VisibleIndex = 2;
            this.colVanPhong.Width = 146;
            // 
            // phongBanTableAdapter
            // 
            this.phongBanTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhongBan1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 530);
            this.Controls.Add(this.gridControl1_PhongBan);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhongBan1";
            this.Text = "Phòng Ban";
            this.Load += new System.EventHandler(this.frmPhongBan1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1_PhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1_PhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1_PhongBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1_PhongBan;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3_Xoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private HRMDataSet hRMDataSet;
        private System.Windows.Forms.BindingSource phongBanBindingSource;
        private HRMDataSetTableAdapters.PhongBanTableAdapter phongBanTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhongBan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenPhongBan;
        private DevExpress.XtraGrid.Columns.GridColumn colVanPhong;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
namespace QLDSV
{
    partial class frmHocPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocPhi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbkSinhVien = new System.Windows.Forms.ComboBox();
            this.sPDANHSACHSINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.sP_THONGTINDONGHOCPHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.bsdHocphi = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.malop = new System.Windows.Forms.Label();
            this.hovaten = new System.Windows.Forms.Label();
            this.sP_DANHSACHSINHVIENTableAdapter = new QLDSV.DSTableAdapters.SP_DANHSACHSINHVIENTableAdapter();
            this.HocphiTableAdapter = new QLDSV.DSTableAdapters.SP_THONGTINDONGHOCPHITableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHSINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_THONGTINDONGHOCPHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsdHocphi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnGhi,
            this.btnHuy,
            this.btnDong,
            this.barButtonItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thoát";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 1;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Hủy";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(865, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 570);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(865, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 515);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(865, 55);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 515);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 2;
            this.btnHuy.Name = "btnHuy";
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng học phí";
            this.btnDong.Id = 3;
            this.btnDong.Name = "btnDong";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.cbkSinhVien);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 55);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(865, 100);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(716, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "TÌM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbkSinhVien
            // 
            this.cbkSinhVien.DataSource = this.sPDANHSACHSINHVIENBindingSource;
            this.cbkSinhVien.DisplayMember = "MASV";
            this.cbkSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkSinhVien.FormattingEnabled = true;
            this.cbkSinhVien.Location = new System.Drawing.Point(235, 45);
            this.cbkSinhVien.Name = "cbkSinhVien";
            this.cbkSinhVien.Size = new System.Drawing.Size(273, 27);
            this.cbkSinhVien.TabIndex = 1;
            this.cbkSinhVien.ValueMember = "MASV";
            this.cbkSinhVien.SelectedIndexChanged += new System.EventHandler(this.cbkSinhVien_SelectedIndexChanged);
            // 
            // sPDANHSACHSINHVIENBindingSource
            // 
            this.sPDANHSACHSINHVIENBindingSource.DataMember = "SP_DANHSACHSINHVIEN";
            this.sPDANHSACHSINHVIENBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 155);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(865, 415);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "HỌC PHÍ";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.sP_THONGTINDONGHOCPHIGridControl);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(2, 134);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(861, 279);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "CHI TIẾT ĐÓNG HỌC PHÍ";
            // 
            // sP_THONGTINDONGHOCPHIGridControl
            // 
            this.sP_THONGTINDONGHOCPHIGridControl.DataSource = this.bsdHocphi;
            this.sP_THONGTINDONGHOCPHIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_THONGTINDONGHOCPHIGridControl.Location = new System.Drawing.Point(2, 34);
            this.sP_THONGTINDONGHOCPHIGridControl.MainView = this.gridView1;
            this.sP_THONGTINDONGHOCPHIGridControl.MenuManager = this.barManager1;
            this.sP_THONGTINDONGHOCPHIGridControl.Name = "sP_THONGTINDONGHOCPHIGridControl";
            this.sP_THONGTINDONGHOCPHIGridControl.Size = new System.Drawing.Size(857, 243);
            this.sP_THONGTINDONGHOCPHIGridControl.TabIndex = 0;
            this.sP_THONGTINDONGHOCPHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
          
            // 
            // bsdHocphi
            // 
            this.bsdHocphi.DataMember = "SP_THONGTINDONGHOCPHI";
            this.bsdHocphi.DataSource = this.dS;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSOTIENDADONG,
            this.colSOTIENDONG});
            this.gridView1.GridControl = this.sP_THONGTINDONGHOCPHIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 30;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.OptionsColumn.ReadOnly = true;
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 112;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 30;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.OptionsColumn.ReadOnly = true;
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 112;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 30;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.OptionsColumn.ReadOnly = true;
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            this.colHOCPHI.Width = 112;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.MinWidth = 30;
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.OptionsColumn.ReadOnly = true;
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 3;
            this.colSOTIENDADONG.Width = 112;
            // 
            // colSOTIENDONG
            // 
            this.colSOTIENDONG.FieldName = "SOTIENDONG";
            this.colSOTIENDONG.MinWidth = 30;
            this.colSOTIENDONG.Name = "colSOTIENDONG";
            this.colSOTIENDONG.Visible = true;
            this.colSOTIENDONG.VisibleIndex = 4;
            this.colSOTIENDONG.Width = 112;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.malop);
            this.groupControl3.Controls.Add(this.hovaten);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(2, 34);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(861, 100);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "THÔNG TIN SINH VIÊN";
            // 
            // malop
            // 
            this.malop.AutoSize = true;
            this.malop.Location = new System.Drawing.Point(402, 53);
            this.malop.Name = "malop";
            this.malop.Size = new System.Drawing.Size(0, 19);
            this.malop.TabIndex = 1;
            // 
            // hovaten
            // 
            this.hovaten.AutoSize = true;
            this.hovaten.Location = new System.Drawing.Point(99, 53);
            this.hovaten.Name = "hovaten";
            this.hovaten.Size = new System.Drawing.Size(0, 19);
            this.hovaten.TabIndex = 0;
            // 
            // sP_DANHSACHSINHVIENTableAdapter
            // 
            this.sP_DANHSACHSINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // HocphiTableAdapter
            // 
            this.HocphiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 590);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmHocPhi";
            this.Text = "HỌC PHÍ";
            this.Load += new System.EventHandler(this.frmHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHSINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_THONGTINDONGHOCPHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsdHocphi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbkSinhVien;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.BindingSource sPDANHSACHSINHVIENBindingSource;
        private DSTableAdapters.SP_DANHSACHSINHVIENTableAdapter sP_DANHSACHSINHVIENTableAdapter;
        private System.Windows.Forms.Label malop;
        private System.Windows.Forms.Label hovaten;
        private System.Windows.Forms.BindingSource bsdHocphi;
        private DSTableAdapters.SP_THONGTINDONGHOCPHITableAdapter HocphiTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_THONGTINDONGHOCPHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDONG;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.Label label2;
    }
}
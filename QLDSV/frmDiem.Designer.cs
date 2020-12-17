namespace QLDSV
{
    partial class frmDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiem));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBatDau = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonHoc = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KHOA = new System.Windows.Forms.Label();
            this.cbkMon = new System.Windows.Forms.ComboBox();
            this.sPLAYMONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.cbkLop = new System.Windows.Forms.ComboBox();
            this.sPDANHSACHLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbkLan = new System.Windows.Forms.ComboBox();
            this.cbkSite = new System.Windows.Forms.ComboBox();
            this.sPLAYLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.sP_LAYDIEMSINHVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsSPDIEMSV = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_LAYLOPTableAdapter = new QLDSV.DSTableAdapters.SP_LAYLOPTableAdapter();
            this.sP_LAYMONHOCTableAdapter = new QLDSV.DSTableAdapters.SP_LAYMONHOCTableAdapter();
            this.sP_LAYDIEMSINHVIENTableAdapter = new QLDSV.DSTableAdapters.SP_LAYDIEMSINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.sP_DANHSACHLOPTableAdapter = new QLDSV.DSTableAdapters.SP_DANHSACHLOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPLAYMONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLAYLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYDIEMSINHVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSPDIEMSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.btnBatDau,
            this.btnGhi,
            this.btnCapNhat,
            this.btnThoat,
            this.btnHuy});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBatDau, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCapNhat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBatDau
            // 
            this.btnBatDau.Caption = "Bắt đầu";
            this.btnBatDau.Id = 0;
            this.btnBatDau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBatDau.ImageOptions.Image")));
            this.btnBatDau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBatDau.ImageOptions.LargeImage")));
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            // btnCapNhat
            // 
            this.btnCapNhat.Caption = "Cập nhật";
            this.btnCapNhat.Id = 2;
            this.btnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.Image")));
            this.btnCapNhat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.LargeImage")));
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 3;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(957, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 644);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(957, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 589);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(957, 55);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 589);
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.label5);
            this.GroupControl1.Controls.Add(this.txtMonHoc);
            this.GroupControl1.Controls.Add(this.txtLop);
            this.GroupControl1.Controls.Add(this.label4);
            this.GroupControl1.Controls.Add(this.label3);
            this.GroupControl1.Controls.Add(this.label2);
            this.GroupControl1.Controls.Add(this.label1);
            this.GroupControl1.Controls.Add(this.KHOA);
            this.GroupControl1.Controls.Add(this.cbkMon);
            this.GroupControl1.Controls.Add(this.cbkLop);
            this.GroupControl1.Controls.Add(this.cbkLan);
            this.GroupControl1.Controls.Add(this.cbkSite);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupControl1.Location = new System.Drawing.Point(0, 55);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(957, 264);
            this.GroupControl1.TabIndex = 4;
            this.GroupControl1.Text = "THÔNG TIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "MÃ MÔN HỌC";
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.Enabled = false;
            this.txtMonHoc.Location = new System.Drawing.Point(591, 203);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Size = new System.Drawing.Size(283, 27);
            this.txtMonHoc.TabIndex = 10;
            // 
            // txtLop
            // 
            this.txtLop.Enabled = false;
            this.txtLop.Location = new System.Drawing.Point(591, 133);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(283, 27);
            this.txtLop.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "MÃ LỚP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "LẦN THI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "TÊN MÔN HỌC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "TÊN LỚP";
            // 
            // KHOA
            // 
            this.KHOA.AutoSize = true;
            this.KHOA.Location = new System.Drawing.Point(30, 55);
            this.KHOA.Name = "KHOA";
            this.KHOA.Size = new System.Drawing.Size(52, 19);
            this.KHOA.TabIndex = 4;
            this.KHOA.Text = "KHOA";
            // 
            // cbkMon
            // 
            this.cbkMon.DataSource = this.sPLAYMONHOCBindingSource;
            this.cbkMon.DisplayMember = "TENMH";
            this.cbkMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkMon.FormattingEnabled = true;
            this.cbkMon.Location = new System.Drawing.Point(135, 208);
            this.cbkMon.Name = "cbkMon";
            this.cbkMon.Size = new System.Drawing.Size(287, 27);
            this.cbkMon.TabIndex = 3;
            this.cbkMon.ValueMember = "MAMH";
            this.cbkMon.SelectedIndexChanged += new System.EventHandler(this.cbkMon_SelectedIndexChanged);
            // 
            // sPLAYMONHOCBindingSource
            // 
            this.sPLAYMONHOCBindingSource.DataMember = "SP_LAYMONHOC";
            this.sPLAYMONHOCBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbkLop
            // 
            this.cbkLop.DataSource = this.sPDANHSACHLOPBindingSource;
            this.cbkLop.DisplayMember = "TENLOP";
            this.cbkLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkLop.FormattingEnabled = true;
            this.cbkLop.Location = new System.Drawing.Point(135, 125);
            this.cbkLop.Name = "cbkLop";
            this.cbkLop.Size = new System.Drawing.Size(287, 27);
            this.cbkLop.TabIndex = 2;
            this.cbkLop.ValueMember = "MALOP";
            this.cbkLop.SelectedIndexChanged += new System.EventHandler(this.cbkLop_SelectedIndexChanged);
            // 
            // sPDANHSACHLOPBindingSource
            // 
            this.sPDANHSACHLOPBindingSource.DataMember = "SP_DANHSACHLOP";
            this.sPDANHSACHLOPBindingSource.DataSource = this.dS;
            // 
            // cbkLan
            // 
            this.cbkLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkLan.FormattingEnabled = true;
            this.cbkLan.Location = new System.Drawing.Point(591, 55);
            this.cbkLan.Name = "cbkLan";
            this.cbkLan.Size = new System.Drawing.Size(283, 27);
            this.cbkLan.TabIndex = 1;
            this.cbkLan.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbkSite
            // 
            this.cbkSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkSite.FormattingEnabled = true;
            this.cbkSite.Location = new System.Drawing.Point(135, 58);
            this.cbkSite.Name = "cbkSite";
            this.cbkSite.Size = new System.Drawing.Size(287, 27);
            this.cbkSite.TabIndex = 0;
            this.cbkSite.SelectedIndexChanged += new System.EventHandler(this.cbkSite_SelectedIndexChanged);
            // 
            // sPLAYLOPBindingSource
            // 
            this.sPLAYLOPBindingSource.DataMember = "SP_LAYLOP";
            this.sPLAYLOPBindingSource.DataSource = this.dS;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.sP_LAYDIEMSINHVIENGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 319);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(957, 325);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "BẢNG ĐIỂM";
            // 
            // sP_LAYDIEMSINHVIENGridControl
            // 
            this.sP_LAYDIEMSINHVIENGridControl.DataSource = this.bdsSPDIEMSV;
            this.sP_LAYDIEMSINHVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_LAYDIEMSINHVIENGridControl.Location = new System.Drawing.Point(2, 34);
            this.sP_LAYDIEMSINHVIENGridControl.MainView = this.gridView1;
            this.sP_LAYDIEMSINHVIENGridControl.MenuManager = this.barManager1;
            this.sP_LAYDIEMSINHVIENGridControl.Name = "sP_LAYDIEMSINHVIENGridControl";
            this.sP_LAYDIEMSINHVIENGridControl.Size = new System.Drawing.Size(953, 289);
            this.sP_LAYDIEMSINHVIENGridControl.TabIndex = 0;
            this.sP_LAYDIEMSINHVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsSPDIEMSV
            // 
            this.bdsSPDIEMSV.DataMember = "SP_LAYDIEMSINHVIEN";
            this.bdsSPDIEMSV.DataSource = this.dS;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHOTEN,
            this.colDIEM});
            this.gridView1.GridControl = this.sP_LAYDIEMSINHVIENGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 30;
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 112;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 30;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.ReadOnly = true;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            this.colHOTEN.Width = 112;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.MinWidth = 30;
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 2;
            this.colDIEM.Width = 112;
            // 
            // sP_LAYLOPTableAdapter
            // 
            this.sP_LAYLOPTableAdapter.ClearBeforeFill = true;
            // 
            // sP_LAYMONHOCTableAdapter
            // 
            this.sP_LAYMONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // sP_LAYDIEMSINHVIENTableAdapter
            // 
            this.sP_LAYDIEMSINHVIENTableAdapter.ClearBeforeFill = true;
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
            // sP_DANHSACHLOPTableAdapter
            // 
            this.sP_DANHSACHLOPTableAdapter.ClearBeforeFill = true;
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 664);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.GroupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDiem";
            this.Text = "ĐIỂM";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            this.GroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPLAYMONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLAYLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAYDIEMSINHVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSPDIEMSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnBatDau;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnCapNhat;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl GroupControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label KHOA;
        private System.Windows.Forms.ComboBox cbkMon;
        private System.Windows.Forms.ComboBox cbkLop;
        private System.Windows.Forms.ComboBox cbkLan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMonHoc;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbkSite;
        private DS dS;
        private System.Windows.Forms.BindingSource sPLAYLOPBindingSource;
        private DSTableAdapters.SP_LAYLOPTableAdapter sP_LAYLOPTableAdapter;
        private DSTableAdapters.SP_LAYMONHOCTableAdapter sP_LAYMONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsSPDIEMSV;
        private DSTableAdapters.SP_LAYDIEMSINHVIENTableAdapter sP_LAYDIEMSINHVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_LAYDIEMSINHVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private System.Windows.Forms.BindingSource sPLAYMONHOCBindingSource;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private System.Windows.Forms.BindingSource sPDANHSACHLOPBindingSource;
        private DSTableAdapters.SP_DANHSACHLOPTableAdapter sP_DANHSACHLOPTableAdapter;
    }
}
namespace QLDSV
{
    partial class frmChuyenLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenLop));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textMalop = new System.Windows.Forms.TextBox();
            this.textTen = new System.Windows.Forms.TextBox();
            this.textHo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbkMasv = new System.Windows.Forms.ComboBox();
            this.sPDANHSACHSINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.button3 = new System.Windows.Forms.Button();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbkLop = new System.Windows.Forms.ComboBox();
            this.sPDANHSACHLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbkKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sP_DANHSACHSINHVIENTableAdapter = new QLDSV.DSTableAdapters.SP_DANHSACHSINHVIENTableAdapter();
            this.sP_DANHSACHLOPTableAdapter = new QLDSV.DSTableAdapters.SP_DANHSACHLOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHSINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHLOPBindingSource)).BeginInit();
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
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Chuyển lớp";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Làm mới";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1027, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 521);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1027, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 466);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1027, 55);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 466);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.textMalop);
            this.groupControl1.Controls.Add(this.textTen);
            this.groupControl1.Controls.Add(this.textHo);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.cbkMasv);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 55);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1027, 114);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "THÔNG TIN SINH VIÊN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(744, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "MALOP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "TEN";
            // 
            // textMalop
            // 
            this.textMalop.Enabled = false;
            this.textMalop.Location = new System.Drawing.Point(821, 42);
            this.textMalop.Name = "textMalop";
            this.textMalop.Size = new System.Drawing.Size(163, 27);
            this.textMalop.TabIndex = 5;
            this.textMalop.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textTen
            // 
            this.textTen.Enabled = false;
            this.textTen.Location = new System.Drawing.Point(563, 47);
            this.textTen.Name = "textTen";
            this.textTen.Size = new System.Drawing.Size(143, 27);
            this.textTen.TabIndex = 4;
            // 
            // textHo
            // 
            this.textHo.Enabled = false;
            this.textHo.Location = new System.Drawing.Point(318, 47);
            this.textHo.Name = "textHo";
            this.textHo.Size = new System.Drawing.Size(182, 27);
            this.textHo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "HO";
            // 
            // cbkMasv
            // 
            this.cbkMasv.DataSource = this.sPDANHSACHSINHVIENBindingSource;
            this.cbkMasv.DisplayMember = "MASV";
            this.cbkMasv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkMasv.FormattingEnabled = true;
            this.cbkMasv.Location = new System.Drawing.Point(86, 47);
            this.cbkMasv.Name = "cbkMasv";
            this.cbkMasv.Size = new System.Drawing.Size(162, 27);
            this.cbkMasv.TabIndex = 1;
            this.cbkMasv.ValueMember = "MASV";
            this.cbkMasv.SelectedIndexChanged += new System.EventHandler(this.cbkMasv_SelectedIndexChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "MASV";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.button3);
            this.groupControl2.Controls.Add(this.btnChuyen);
            this.groupControl2.Controls.Add(this.button1);
            this.groupControl2.Controls.Add(this.textBox1);
            this.groupControl2.Controls.Add(this.cbkLop);
            this.groupControl2.Controls.Add(this.cbkKhoa);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 169);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1027, 352);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "THÔNG TIN LỚP CHUYỂN ĐẾN";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(522, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "HỦY";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnChuyen
            // 
            this.btnChuyen.Location = new System.Drawing.Point(369, 244);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(86, 40);
            this.btnChuyen.TabIndex = 7;
            this.btnChuyen.Text = "CHUYỂN";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "CHECK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(369, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 27);
            this.textBox1.TabIndex = 5;
            // 
            // cbkLop
            // 
            this.cbkLop.DataSource = this.sPDANHSACHLOPBindingSource;
            this.cbkLop.DisplayMember = "MALOP";
            this.cbkLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkLop.FormattingEnabled = true;
            this.cbkLop.Location = new System.Drawing.Point(369, 117);
            this.cbkLop.Name = "cbkLop";
            this.cbkLop.Size = new System.Drawing.Size(261, 27);
            this.cbkLop.TabIndex = 4;
            this.cbkLop.ValueMember = "MALOP";
            this.cbkLop.SelectedIndexChanged += new System.EventHandler(this.cbkLop_SelectedIndexChanged);
            // 
            // sPDANHSACHLOPBindingSource
            // 
            this.sPDANHSACHLOPBindingSource.DataMember = "SP_DANHSACHLOP";
            this.sPDANHSACHLOPBindingSource.DataSource = this.dS;
            // 
            // cbkKhoa
            // 
            this.cbkKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkKhoa.FormattingEnabled = true;
            this.cbkKhoa.Location = new System.Drawing.Point(369, 59);
            this.cbkKhoa.Name = "cbkKhoa";
            this.cbkKhoa.Size = new System.Drawing.Size(261, 27);
            this.cbkKhoa.TabIndex = 3;
            this.cbkKhoa.SelectedIndexChanged += new System.EventHandler(this.cbkKhoa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "MÃ SINH VIÊN MỚI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "LỚP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA";
            // 
            // sP_DANHSACHSINHVIENTableAdapter
            // 
            this.sP_DANHSACHSINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // sP_DANHSACHLOPTableAdapter
            // 
            this.sP_DANHSACHLOPTableAdapter.ClearBeforeFill = true;
            // 
            // frmChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 541);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmChuyenLop";
            this.Text = "CHUYỂN LỚP";
            this.Load += new System.EventHandler(this.frmChuyenLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHSINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHLOPBindingSource)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbkLop;
        private System.Windows.Forms.ComboBox cbkKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textMalop;
        private System.Windows.Forms.TextBox textTen;
        private System.Windows.Forms.TextBox textHo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbkMasv;
        private System.Windows.Forms.Label label4;
        private DS dS;
        private System.Windows.Forms.BindingSource sPDANHSACHSINHVIENBindingSource;
        private DSTableAdapters.SP_DANHSACHSINHVIENTableAdapter sP_DANHSACHSINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource sPDANHSACHLOPBindingSource;
        private DSTableAdapters.SP_DANHSACHLOPTableAdapter sP_DANHSACHLOPTableAdapter;
    }
}
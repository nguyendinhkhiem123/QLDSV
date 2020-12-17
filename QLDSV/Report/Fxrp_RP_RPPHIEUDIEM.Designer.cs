namespace QLDSV.Report
{
    partial class cbkLop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbkSite = new System.Windows.Forms.ComboBox();
            this.cbkL = new System.Windows.Forms.ComboBox();
            this.sPDANHSACHLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.cbkSV = new System.Windows.Forms.ComboBox();
            this.sPDANHSACHSINHVIENTHEOLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DANHSACHLOPTableAdapter = new QLDSV.DSTableAdapters.SP_DANHSACHLOPTableAdapter();
            this.sP_DANHSACHSINHVIENTHEOLOPTableAdapter = new QLDSV.DSTableAdapters.SP_DANHSACHSINHVIENTHEOLOPTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHSINHVIENTHEOLOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "LỚP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "TÊN SINH VIÊN";
            // 
            // cbkSite
            // 
            this.cbkSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkSite.FormattingEnabled = true;
            this.cbkSite.Location = new System.Drawing.Point(299, 130);
            this.cbkSite.Name = "cbkSite";
            this.cbkSite.Size = new System.Drawing.Size(376, 28);
            this.cbkSite.TabIndex = 3;
            this.cbkSite.SelectedIndexChanged += new System.EventHandler(this.cbkSite_SelectedIndexChanged);
            // 
            // cbkL
            // 
            this.cbkL.DataSource = this.sPDANHSACHLOPBindingSource;
            this.cbkL.DisplayMember = "TENLOP";
            this.cbkL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkL.FormattingEnabled = true;
            this.cbkL.Location = new System.Drawing.Point(299, 201);
            this.cbkL.Name = "cbkL";
            this.cbkL.Size = new System.Drawing.Size(376, 28);
            this.cbkL.TabIndex = 4;
            this.cbkL.ValueMember = "MALOP";
            this.cbkL.SelectedIndexChanged += new System.EventHandler(this.cbkL_SelectedIndexChanged);
            // 
            // sPDANHSACHLOPBindingSource
            // 
            this.sPDANHSACHLOPBindingSource.DataMember = "SP_DANHSACHLOP";
            this.sPDANHSACHLOPBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbkSV
            // 
            this.cbkSV.DataSource = this.sPDANHSACHSINHVIENTHEOLOPBindingSource;
            this.cbkSV.DisplayMember = "HOTEN";
            this.cbkSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkSV.FormattingEnabled = true;
            this.cbkSV.Location = new System.Drawing.Point(299, 269);
            this.cbkSV.Name = "cbkSV";
            this.cbkSV.Size = new System.Drawing.Size(376, 28);
            this.cbkSV.TabIndex = 5;
            this.cbkSV.ValueMember = "MASV";
            this.cbkSV.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // sPDANHSACHSINHVIENTHEOLOPBindingSource
            // 
            this.sPDANHSACHSINHVIENTHEOLOPBindingSource.DataMember = "SP_DANHSACHSINHVIENTHEOLOP";
            this.sPDANHSACHSINHVIENTHEOLOPBindingSource.DataSource = this.dS;
            // 
            // sP_DANHSACHLOPTableAdapter
            // 
            this.sP_DANHSACHLOPTableAdapter.ClearBeforeFill = true;
            // 
            // sP_DANHSACHSINHVIENTHEOLOPTableAdapter
            // 
            this.sP_DANHSACHSINHVIENTHEOLOPTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "IN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "QUAY LẠI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbkLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbkSV);
            this.Controls.Add(this.cbkL);
            this.Controls.Add(this.cbkSite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cbkLop";
            this.Text = "PHIẾU ĐIỂM";
            this.Load += new System.EventHandler(this.cbkLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHSINHVIENTHEOLOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbkSite;
        private System.Windows.Forms.ComboBox cbkL;
        private System.Windows.Forms.ComboBox cbkSV;
        private DS dS;
        private System.Windows.Forms.BindingSource sPDANHSACHLOPBindingSource;
        private DSTableAdapters.SP_DANHSACHLOPTableAdapter sP_DANHSACHLOPTableAdapter;
        private System.Windows.Forms.BindingSource sPDANHSACHSINHVIENTHEOLOPBindingSource;
        private DSTableAdapters.SP_DANHSACHSINHVIENTHEOLOPTableAdapter sP_DANHSACHSINHVIENTHEOLOPTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
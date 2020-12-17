namespace QLDSV.Report
{
    partial class cbkMon
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbkSite = new System.Windows.Forms.ComboBox();
            this.cbkLop = new System.Windows.Forms.ComboBox();
            this.cbkMH = new System.Windows.Forms.ComboBox();
            this.cbkLan = new System.Windows.Forms.ComboBox();
            this.date = new DevExpress.XtraEditors.DateEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dS = new QLDSV.DS();
            this.sPDANHSACHLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DANHSACHLOPTableAdapter = new QLDSV.DSTableAdapters.SP_DANHSACHLOPTableAdapter();
            this.sPLAYMONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAYMONHOCTableAdapter = new QLDSV.DSTableAdapters.SP_LAYMONHOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLAYMONHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "KHOA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "LỚP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "MÔN HỌC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "LẦN THI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "NGÀY THI";
            // 
            // cbkSite
            // 
            this.cbkSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkSite.FormattingEnabled = true;
            this.cbkSite.Location = new System.Drawing.Point(292, 59);
            this.cbkSite.Name = "cbkSite";
            this.cbkSite.Size = new System.Drawing.Size(333, 28);
            this.cbkSite.TabIndex = 6;
            this.cbkSite.SelectedIndexChanged += new System.EventHandler(this.cbkSite_SelectedIndexChanged);
            // 
            // cbkLop
            // 
            this.cbkLop.DataSource = this.sPDANHSACHLOPBindingSource;
            this.cbkLop.DisplayMember = "TENLOP";
            this.cbkLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkLop.FormattingEnabled = true;
            this.cbkLop.Location = new System.Drawing.Point(292, 127);
            this.cbkLop.Name = "cbkLop";
            this.cbkLop.Size = new System.Drawing.Size(333, 28);
            this.cbkLop.TabIndex = 7;
            this.cbkLop.ValueMember = "MALOP";
            this.cbkLop.SelectedIndexChanged += new System.EventHandler(this.cbkLop_SelectedIndexChanged);
            // 
            // cbkMH
            // 
            this.cbkMH.DataSource = this.sPLAYMONHOCBindingSource;
            this.cbkMH.DisplayMember = "TENMH";
            this.cbkMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkMH.FormattingEnabled = true;
            this.cbkMH.Location = new System.Drawing.Point(292, 203);
            this.cbkMH.Name = "cbkMH";
            this.cbkMH.Size = new System.Drawing.Size(333, 28);
            this.cbkMH.TabIndex = 8;
            this.cbkMH.ValueMember = "MAMH";
            this.cbkMH.SelectedIndexChanged += new System.EventHandler(this.cbkMH_SelectedIndexChanged);
            // 
            // cbkLan
            // 
            this.cbkLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkLan.FormattingEnabled = true;
            this.cbkLan.Location = new System.Drawing.Point(292, 287);
            this.cbkLan.Name = "cbkLan";
            this.cbkLan.Size = new System.Drawing.Size(333, 28);
            this.cbkLan.TabIndex = 9;
            this.cbkLan.SelectedIndexChanged += new System.EventHandler(this.cbkLan_SelectedIndexChanged);
            // 
            // date
            // 
            this.date.EditValue = null;
            this.date.Location = new System.Drawing.Point(292, 359);
            this.date.Name = "date";
            this.date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Size = new System.Drawing.Size(333, 28);
            this.date.TabIndex = 10;
            this.date.EditValueChanged += new System.EventHandler(this.date_EditValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "IN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "QUAY LẠI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPDANHSACHLOPBindingSource
            // 
            this.sPDANHSACHLOPBindingSource.DataMember = "SP_DANHSACHLOP";
            this.sPDANHSACHLOPBindingSource.DataSource = this.dS;
            // 
            // sP_DANHSACHLOPTableAdapter
            // 
            this.sP_DANHSACHLOPTableAdapter.ClearBeforeFill = true;
            // 
            // sPLAYMONHOCBindingSource
            // 
            this.sPLAYMONHOCBindingSource.DataMember = "SP_LAYMONHOC";
            this.sPLAYMONHOCBindingSource.DataSource = this.dS;
            // 
            // sP_LAYMONHOCTableAdapter
            // 
            this.sP_LAYMONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // cbkMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbkLan);
            this.Controls.Add(this.cbkMH);
            this.Controls.Add(this.cbkLop);
            this.Controls.Add(this.cbkSite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Name = "cbkMon";
            this.Text = "BẢNG ĐIỂM THI";
            this.Load += new System.EventHandler(this.Fxrp_SP_RPBANGDIEMTHI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLAYMONHOCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbkSite;
        private System.Windows.Forms.ComboBox cbkLop;
        private System.Windows.Forms.ComboBox cbkMH;
        private System.Windows.Forms.ComboBox cbkLan;
        private DevExpress.XtraEditors.DateEdit date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DS dS;
        private System.Windows.Forms.BindingSource sPDANHSACHLOPBindingSource;
        private DSTableAdapters.SP_DANHSACHLOPTableAdapter sP_DANHSACHLOPTableAdapter;
        private System.Windows.Forms.BindingSource sPLAYMONHOCBindingSource;
        private DSTableAdapters.SP_LAYMONHOCTableAdapter sP_LAYMONHOCTableAdapter;
    }
}
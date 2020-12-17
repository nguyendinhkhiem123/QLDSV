namespace QLDSV.Report
{
    partial class Fxrp_SP_RPDONGHOCPHI
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
            this.cbkMalop = new System.Windows.Forms.ComboBox();
            this.cbkNienkhoa = new System.Windows.Forms.ComboBox();
            this.cbkHocky = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dS = new QLDSV.DS();
            this.sPDANHSACHLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DANHSACHLOPTableAdapter = new QLDSV.DSTableAdapters.SP_DANHSACHLOPTableAdapter();
            this.sPLAYNIENKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAYNIENKHOATableAdapter = new QLDSV.DSTableAdapters.SP_LAYNIENKHOATableAdapter();
            this.sPLAYHOCKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAYHOCKYTableAdapter = new QLDSV.DSTableAdapters.SP_LAYHOCKYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLAYNIENKHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLAYHOCKYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ LỚP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIÊN KHÓA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "HỌC KỲ";
            // 
            // cbkMalop
            // 
            this.cbkMalop.DataSource = this.sPDANHSACHLOPBindingSource;
            this.cbkMalop.DisplayMember = "TENLOP";
            this.cbkMalop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkMalop.FormattingEnabled = true;
            this.cbkMalop.Location = new System.Drawing.Point(325, 101);
            this.cbkMalop.Name = "cbkMalop";
            this.cbkMalop.Size = new System.Drawing.Size(324, 28);
            this.cbkMalop.TabIndex = 3;
            this.cbkMalop.ValueMember = "MALOP";
            this.cbkMalop.SelectedIndexChanged += new System.EventHandler(this.cbkMalop_SelectedIndexChanged);
            // 
            // cbkNienkhoa
            // 
            this.cbkNienkhoa.DataSource = this.sPLAYNIENKHOABindingSource;
            this.cbkNienkhoa.DisplayMember = "NIENKHOA";
            this.cbkNienkhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkNienkhoa.FormattingEnabled = true;
            this.cbkNienkhoa.Location = new System.Drawing.Point(325, 180);
            this.cbkNienkhoa.Name = "cbkNienkhoa";
            this.cbkNienkhoa.Size = new System.Drawing.Size(324, 28);
            this.cbkNienkhoa.TabIndex = 4;
            this.cbkNienkhoa.ValueMember = "NIENKHOA";
            this.cbkNienkhoa.SelectedIndexChanged += new System.EventHandler(this.cbkNienkhoa_SelectedIndexChanged);
            // 
            // cbkHocky
            // 
            this.cbkHocky.DataSource = this.sPLAYHOCKYBindingSource;
            this.cbkHocky.DisplayMember = "HOCKY";
            this.cbkHocky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkHocky.FormattingEnabled = true;
            this.cbkHocky.Location = new System.Drawing.Point(325, 263);
            this.cbkHocky.Name = "cbkHocky";
            this.cbkHocky.Size = new System.Drawing.Size(324, 28);
            this.cbkHocky.TabIndex = 5;
            this.cbkHocky.ValueMember = "HOCKY";
            this.cbkHocky.SelectedIndexChanged += new System.EventHandler(this.cbkHocky_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "IN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 40);
            this.button2.TabIndex = 7;
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
            // sPLAYNIENKHOABindingSource
            // 
            this.sPLAYNIENKHOABindingSource.DataMember = "SP_LAYNIENKHOA";
            this.sPLAYNIENKHOABindingSource.DataSource = this.dS;
            // 
            // sP_LAYNIENKHOATableAdapter
            // 
            this.sP_LAYNIENKHOATableAdapter.ClearBeforeFill = true;
            // 
            // sPLAYHOCKYBindingSource
            // 
            this.sPLAYHOCKYBindingSource.DataMember = "SP_LAYHOCKY";
            this.sPLAYHOCKYBindingSource.DataSource = this.dS;
            // 
            // sP_LAYHOCKYTableAdapter
            // 
            this.sP_LAYHOCKYTableAdapter.ClearBeforeFill = true;
            // 
            // Fxrp_SP_RPDONGHOCPHI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbkHocky);
            this.Controls.Add(this.cbkNienkhoa);
            this.Controls.Add(this.cbkMalop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fxrp_SP_RPDONGHOCPHI";
            this.Text = "DANH SÁCH ĐÓNG HỌC PHÍ";
            this.Load += new System.EventHandler(this.Fxrp_SP_RPDONGHOCPHI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLAYNIENKHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLAYHOCKYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbkMalop;
        private System.Windows.Forms.ComboBox cbkNienkhoa;
        private System.Windows.Forms.ComboBox cbkHocky;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DS dS;
        private System.Windows.Forms.BindingSource sPDANHSACHLOPBindingSource;
        private DSTableAdapters.SP_DANHSACHLOPTableAdapter sP_DANHSACHLOPTableAdapter;
        private System.Windows.Forms.BindingSource sPLAYNIENKHOABindingSource;
        private System.Windows.Forms.BindingSource sPLAYHOCKYBindingSource;
        private DSTableAdapters.SP_LAYNIENKHOATableAdapter sP_LAYNIENKHOATableAdapter;
        private DSTableAdapters.SP_LAYHOCKYTableAdapter sP_LAYHOCKYTableAdapter;
    }
}
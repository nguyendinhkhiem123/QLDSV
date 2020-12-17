namespace QLDSV.Report
{
    partial class Fxrp_SP_RPBANGDIEMTONGKET
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
            this.cbkSite = new System.Windows.Forms.ComboBox();
            this.cbkLop = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dS = new QLDSV.DS();
            this.sPDANHSACHLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DANHSACHLOPTableAdapter = new QLDSV.DSTableAdapters.SP_DANHSACHLOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHLOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "LỚP";
            // 
            // cbkSite
            // 
            this.cbkSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkSite.FormattingEnabled = true;
            this.cbkSite.Location = new System.Drawing.Point(251, 119);
            this.cbkSite.Name = "cbkSite";
            this.cbkSite.Size = new System.Drawing.Size(351, 28);
            this.cbkSite.TabIndex = 2;
            this.cbkSite.SelectedIndexChanged += new System.EventHandler(this.cbkSite_SelectedIndexChanged);
            // 
            // cbkLop
            // 
            this.cbkLop.DataSource = this.sPDANHSACHLOPBindingSource;
            this.cbkLop.DisplayMember = "TENLOP";
            this.cbkLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkLop.FormattingEnabled = true;
            this.cbkLop.Location = new System.Drawing.Point(251, 200);
            this.cbkLop.Name = "cbkLop";
            this.cbkLop.Size = new System.Drawing.Size(351, 28);
            this.cbkLop.TabIndex = 3;
            this.cbkLop.ValueMember = "MALOP";
            this.cbkLop.SelectedIndexChanged += new System.EventHandler(this.cbkLop_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "IN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "THOÁT";
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
            // Fxrp_SP_RPBANGDIEMTONGKET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbkLop);
            this.Controls.Add(this.cbkSite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fxrp_SP_RPBANGDIEMTONGKET";
            this.Text = "BẢNG ĐIỂM TỔNG KẾT MÔN HỌC";
            this.Load += new System.EventHandler(this.Fxrp_SP_RPBANGDIEMTONGKET_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANHSACHLOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbkSite;
        private System.Windows.Forms.ComboBox cbkLop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DS dS;
        private System.Windows.Forms.BindingSource sPDANHSACHLOPBindingSource;
        private DSTableAdapters.SP_DANHSACHLOPTableAdapter sP_DANHSACHLOPTableAdapter;
    }
}
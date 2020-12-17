namespace QLDSV
{
    partial class frmDangNhap
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
            this.comboxSite = new System.Windows.Forms.ComboBox();
            this.vIEWSDANHSACHSERVERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.ckbShowPass = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vIEWS_DANHSACHSERVERTableAdapter = new QLDSV.DSTableAdapters.VIEWS_DANHSACHSERVERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWSDANHSACHSERVERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SITE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOGIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // comboxSite
            // 
            this.comboxSite.DataSource = this.vIEWSDANHSACHSERVERBindingSource;
            this.comboxSite.DisplayMember = "description";
            this.comboxSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxSite.FormattingEnabled = true;
            this.comboxSite.Location = new System.Drawing.Point(241, 117);
            this.comboxSite.Name = "comboxSite";
            this.comboxSite.Size = new System.Drawing.Size(345, 28);
            this.comboxSite.TabIndex = 3;
            this.comboxSite.ValueMember = "TENSERVER";
            this.comboxSite.SelectedIndexChanged += new System.EventHandler(this.comboxSite_SelectedIndexChanged);
            // 
            // vIEWSDANHSACHSERVERBindingSource
            // 
            this.vIEWSDANHSACHSERVERBindingSource.DataMember = "VIEWS_DANHSACHSERVER";
            this.vIEWSDANHSACHSERVERBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(241, 179);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(345, 26);
            this.textLogin.TabIndex = 4;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(241, 243);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(345, 26);
            this.textPass.TabIndex = 5;
            // 
            // ckbShowPass
            // 
            this.ckbShowPass.AutoSize = true;
            this.ckbShowPass.Location = new System.Drawing.Point(546, 298);
            this.ckbShowPass.Name = "ckbShowPass";
            this.ckbShowPass.Size = new System.Drawing.Size(190, 24);
            this.ckbShowPass.TabIndex = 6;
            this.ckbShowPass.Text = "HIỆN THỊ MẬT KHẨU";
            this.ckbShowPass.UseVisualStyleBackColor = true;
            this.ckbShowPass.CheckedChanged += new System.EventHandler(this.ckbShowPass_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(250, 338);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(123, 43);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "THOÁT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vIEWS_DANHSACHSERVERTableAdapter
            // 
            this.vIEWS_DANHSACHSERVERTableAdapter.ClearBeforeFill = true;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.ckbShowPass);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.comboxSite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangNhap";
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vIEWSDANHSACHSERVERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboxSite;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.CheckBox ckbShowPass;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button button2;
        private DS dS;
        private System.Windows.Forms.BindingSource vIEWSDANHSACHSERVERBindingSource;
        private DSTableAdapters.VIEWS_DANHSACHSERVERTableAdapter vIEWS_DANHSACHSERVERTableAdapter;
    }
}
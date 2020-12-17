namespace QLDSV
{
    partial class frmTaoTaiKhoang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbkSite = new System.Windows.Forms.ComboBox();
            this.cbkRole = new System.Windows.Forms.ComboBox();
            this.cbkUser = new System.Windows.Forms.ComboBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SITE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOGIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "PASSWORD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ROLE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "XÁC NHẬN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "QUAY LẠI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbkSite
            // 
            this.cbkSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkSite.FormattingEnabled = true;
            this.cbkSite.Location = new System.Drawing.Point(320, 60);
            this.cbkSite.Name = "cbkSite";
            this.cbkSite.Size = new System.Drawing.Size(327, 28);
            this.cbkSite.TabIndex = 7;
            this.cbkSite.SelectedIndexChanged += new System.EventHandler(this.cbkSite_SelectedIndexChanged);
            // 
            // cbkRole
            // 
            this.cbkRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkRole.FormattingEnabled = true;
            this.cbkRole.Location = new System.Drawing.Point(320, 314);
            this.cbkRole.Name = "cbkRole";
            this.cbkRole.Size = new System.Drawing.Size(327, 28);
            this.cbkRole.TabIndex = 8;
            this.cbkRole.SelectedIndexChanged += new System.EventHandler(this.cbkRole_SelectedIndexChanged);
            // 
            // cbkUser
            // 
            this.cbkUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkUser.FormattingEnabled = true;
            this.cbkUser.Location = new System.Drawing.Point(320, 109);
            this.cbkUser.Name = "cbkUser";
            this.cbkUser.Size = new System.Drawing.Size(327, 28);
            this.cbkUser.TabIndex = 9;
            this.cbkUser.SelectedIndexChanged += new System.EventHandler(this.cbkUser_SelectedIndexChanged);
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(320, 215);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(327, 26);
            this.textLogin.TabIndex = 10;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(320, 265);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(327, 26);
            this.textPass.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "HỌ VÀ TÊN";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(320, 159);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(327, 26);
            this.txtName.TabIndex = 13;
            this.txtName.WordWrap = false;
            // 
            // frmTaoTaiKhoang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.cbkUser);
            this.Controls.Add(this.cbkRole);
            this.Controls.Add(this.cbkSite);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTaoTaiKhoang";
            this.Text = "TẠO TÀI KHOẢN";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbkSite;
        private System.Windows.Forms.ComboBox cbkRole;
        private System.Windows.Forms.ComboBox cbkUser;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
    }
}
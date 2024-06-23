namespace SLIIT_Prep_Final_Project
{
    partial class frmLoginPage
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
            this.chbForget_P = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblULogin = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chbForget_P
            // 
            this.chbForget_P.AutoSize = true;
            this.chbForget_P.BackColor = System.Drawing.Color.Transparent;
            this.chbForget_P.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbForget_P.Location = new System.Drawing.Point(61, 359);
            this.chbForget_P.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chbForget_P.Name = "chbForget_P";
            this.chbForget_P.Size = new System.Drawing.Size(292, 36);
            this.chbForget_P.TabIndex = 17;
            this.chbForget_P.Text = "Forget Password ";
            this.chbForget_P.UseVisualStyleBackColor = false;
            this.chbForget_P.CheckedChanged += new System.EventHandler(this.chbForget_P_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(297, 243);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(226, 22);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(297, 163);
            this.txtUname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(226, 22);
            this.txtUname.TabIndex = 14;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(40, 153);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(188, 36);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(40, 233);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(167, 36);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // lblULogin
            // 
            this.lblULogin.AutoSize = true;
            this.lblULogin.BackColor = System.Drawing.Color.Transparent;
            this.lblULogin.Font = new System.Drawing.Font("Lucida Fax", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblULogin.Location = new System.Drawing.Point(156, 41);
            this.lblULogin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblULogin.Name = "lblULogin";
            this.lblULogin.Size = new System.Drawing.Size(291, 54);
            this.lblULogin.TabIndex = 10;
            this.lblULogin.Text = "User Login";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Cyan;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(183, 511);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(202, 62);
            this.btnlogin.TabIndex = 9;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // frmLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SLIIT_Prep_Final_Project.Properties.Resources.istockphoto_610761340_170667a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 666);
            this.Controls.Add(this.chbForget_P);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblULogin);
            this.Controls.Add(this.btnlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmLoginPage";
            this.Text = "Login page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbForget_P;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblULogin;
        private System.Windows.Forms.Button btnlogin;
    }
}
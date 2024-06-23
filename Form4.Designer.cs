namespace SLIIT_Prep_Final_Project
{
    partial class frmForgotPasswprd
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
            this.LblForgotPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnGetYourPassword = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblForgotPassword
            // 
            this.LblForgotPassword.AutoSize = true;
            this.LblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblForgotPassword.Font = new System.Drawing.Font("Lucida Fax", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblForgotPassword.Location = new System.Drawing.Point(194, 60);
            this.LblForgotPassword.Name = "LblForgotPassword";
            this.LblForgotPassword.Size = new System.Drawing.Size(590, 60);
            this.LblForgotPassword.TabIndex = 0;
            this.LblForgotPassword.Text = "FORGOT PASSWORD";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(256, 218);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(205, 38);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name";
            // 
            // btnGetYourPassword
            // 
            this.btnGetYourPassword.BackColor = System.Drawing.Color.Cyan;
            this.btnGetYourPassword.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetYourPassword.Location = new System.Drawing.Point(431, 377);
            this.btnGetYourPassword.Name = "btnGetYourPassword";
            this.btnGetYourPassword.Size = new System.Drawing.Size(417, 57);
            this.btnGetYourPassword.TabIndex = 2;
            this.btnGetYourPassword.Text = "Get Your Password";
            this.btnGetYourPassword.UseVisualStyleBackColor = false;
            this.btnGetYourPassword.Click += new System.EventHandler(this.btnGetYourPassword_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.Cyan;
            this.btnBackToLogin.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.Location = new System.Drawing.Point(470, 486);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(364, 45);
            this.btnBackToLogin.TabIndex = 3;
            this.btnBackToLogin.Text = "Back To Login";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(491, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 45);
            this.textBox1.TabIndex = 4;
            // 
            // frmForgotPasswprd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SLIIT_Prep_Final_Project.Properties.Resources.istockphoto_1252566645_170667a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 670);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.btnGetYourPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.LblForgotPassword);
            this.Name = "frmForgotPasswprd";
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblForgotPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnGetYourPassword;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.TextBox textBox1;
    }
}
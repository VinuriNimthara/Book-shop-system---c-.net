namespace SLIIT_Prep_Final_Project
{
    partial class frmWelcomePage
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Lucida Fax", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(416, 40);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(648, 284);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "       WELCOME \r\n             TO \r\n            THE\r\n VINU\'S BOOK SHOP";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(802, 585);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(223, 65);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(562, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "    Let\'s Read Our Future !";
            // 
            // frmWelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SLIIT_Prep_Final_Project.Properties.Resources.books_external_blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 666);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Lucida Fax", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "frmWelcomePage";
            this.Text = "Welcome page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
    }
}


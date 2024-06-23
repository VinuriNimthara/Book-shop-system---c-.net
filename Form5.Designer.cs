namespace SLIIT_Prep_Final_Project
{
    partial class frmDelete
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
            this.lblCusName = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.BackColor = System.Drawing.Color.Transparent;
            this.lblCusName.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusName.ForeColor = System.Drawing.Color.Black;
            this.lblCusName.Location = new System.Drawing.Point(97, 235);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(297, 36);
            this.lblCusName.TabIndex = 0;
            this.lblCusName.Text = "Customer\'s Name";
            // 
            // txtCusName
            // 
            this.txtCusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.Location = new System.Drawing.Point(481, 242);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(356, 34);
            this.txtCusName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 65);
            this.label3.TabIndex = 4;
            this.label3.Text = "Let\'s delete !!";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Aqua;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(419, 510);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 58);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Aqua;
            this.btnBack.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(839, 600);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(171, 58);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SLIIT_Prep_Final_Project.Properties.Resources.pile_of_books_with_pages_open_by_wind_royalty_free_image_16007859941;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 670);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.lblCusName);
            this.Name = "frmDelete";
            this.Text = "Delete Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
    }
}
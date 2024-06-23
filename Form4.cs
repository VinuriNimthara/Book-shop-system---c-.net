using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLIIT_Prep_Final_Project
{
    public partial class frmForgotPasswprd : Form
    {
        public frmForgotPasswprd()
        {
            InitializeComponent();
        }

        private void btnGetYourPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password=1234");
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLoginPage = new frmLoginPage();
            frmLoginPage.Show();
            this.Hide();
        }
    }
}

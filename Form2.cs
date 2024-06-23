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
    public partial class frmLoginPage : Form
    {
        public frmLoginPage()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUname.Text;
            password = txtPassword.Text;

            if (username == "Vinu" && password == "1234")
            {
                frmRegistration fRegis1 = new frmRegistration();
                this.Hide();
                MessageBox.Show("You have logged in successfully!!", "Logged In Message!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fRegis1.Show();
            }
            else
            {
                MessageBox.Show("Password or Userame is incorrect !!\n Try again!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUname.Clear();
                txtPassword.Clear();
                txtUname.Focus();
            }

        }
        


        
        
        private void chbForget_P_CheckedChanged(object sender, EventArgs e)
        {
            frmForgotPasswprd fForgot1 = new frmForgotPasswprd();
            this.Hide();
            fForgot1.Show();
        }
    }
}

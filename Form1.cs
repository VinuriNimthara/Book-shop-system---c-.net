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
    public partial class frmWelcomePage : Form
    {
        public frmWelcomePage()
        {
            InitializeComponent();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLoginPage = new frmLoginPage();
            frmLoginPage.Show();
            this.Hide();
        }
    }
}

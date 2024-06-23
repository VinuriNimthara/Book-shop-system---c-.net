using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLIIT_Prep_Final_Project
{
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = Book_Store; Integrated Security = True;");
            con1.Open();
            MessageBox.Show("Do you want to delete this permenetly?","Confimation message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            SqlCommand cmd = new SqlCommand("DELETE FROM USERS WHERE Customer_Name=('"+ txtCusName.Text + "')",con1);
            cmd.ExecuteNonQuery();
            txtCusName.Clear();
            txtCusName.Focus();
            con1.Close();
            MessageBox.Show("Deleted successfully!!");
                
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmRegistration frmRegistration = new frmRegistration();
            this.Hide();
            frmRegistration.Show();
        }
    }
}

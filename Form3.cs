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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

       

       

       

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = Book_Store; Integrated Security = True;");
            con1.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Users(Customer_Name, NIC_No, Contact_No, Email, Book_Name, ISBN_No, Book_No, Book_Type) VALUES('" + txtCustomerName.Text + "', '" + txtNICNo.Text + "', '"+ txtContactNo.Text + "', '"+ txtEmail.Text + "', '"+ txtBookName.Text + "', '"+ txtISBNNo.Text + "', '"+ txtBookNo.Text + "', '"+ txtBookType.Text + "')",con1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("You have registered sucsessfully!!", "Registered !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con1.Close(); 

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtNICNo.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtBookName.Clear();
            txtISBNNo.Clear();
            txtBookNo.Clear();
            txtBookType.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete frmDelete = new frmDelete();
            frmDelete.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLogin1 = new frmLoginPage();
            this.Hide();
            frmLogin1.Show();
        }
    }
}

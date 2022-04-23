using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elite_ATM_Class_Library;
using System.Data.SqlClient;

namespace Elite_ATM_Software
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                if (txtFirstname.Text == "" || txtLastname.Text == "" || txtEmail.Text == "" || txtCreatePassword.Text == "")
                {
                    throw new Exception("Please enter a value in all fields");
                }
                user.FirstName = txtFirstname.Text;
                user.LastName = txtLastname.Text;
                user.Email = txtEmail.Text;
                if (txtCreatePassword.Text == txtReEnterPassword.Text)
                {
                    user.Password = txtReEnterPassword.Text;
                }
                else
                {
                    throw new Exception("Passwords Dont Match");
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlConnection connection = new SqlConnection(Utilities.GetConnectionString());
            connection.Open();
            SqlCommand command = new SqlCommand($"INSERT INTO [User] (FirstName, LastName, Email, Password) VALUES ('{user.FirstName}', '{user.LastName}', '{user.Email}', '{user.Password }')", connection);
            int i = command.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("User Created Successfully!");
                connection.Close();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.MdiParent = this.MdiParent;
                frmLogin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Something Went Wrong, Please Contact Administrator");
            }
        }
    }
}

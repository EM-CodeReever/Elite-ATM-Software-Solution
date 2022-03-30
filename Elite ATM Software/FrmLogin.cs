using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Elite_ATM_Class_Library;

namespace Elite_ATM_Software
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                SqlConnection connection = new SqlConnection(Utilities.GetConnectionString());
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE ID = '" + txtUserID.Text + "' OR Email = '" + txtEmail.Text + "'",connection);
            
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (!sqlDataReader.Read()) { throw new Exception("User Does Not Exist"); }
            sqlDataReader.Close();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if(!(txtPassword.Text == reader["Password"].ToString())) { throw new Exception("Incorrect Login Credentials"); } 
                user.Id = (int)reader["ID"];
                user.FirstName = reader["Firstname"].ToString();
                user.LastName = reader["Lastname"].ToString();
                user.Email = reader["Email"].ToString();
                FrmHome home = new FrmHome(user);
                home.Show();
            }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

;        }

        private void lnkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignUp signUp = new FrmSignUp();
            signUp.Show();
        }
    }
}

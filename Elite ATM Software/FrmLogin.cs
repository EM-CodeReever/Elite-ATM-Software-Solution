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
            UserTracker.currentUser = new User();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Utilities.GetConnectionString());
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM [User] WHERE ID = '" + txtUserID.Text + "' OR Email = '" + txtEmail.Text + "'",connection);
            
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (!sqlDataReader.Read()) { throw new Exception("User Does Not Exist"); }
            sqlDataReader.Close();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if(!(txtPassword.Text == reader["Password"].ToString())) { throw new Exception("Incorrect Login Credentials"); } 
                UserTracker.currentUser.Id = (int)reader["ID"];
                UserTracker.currentUser.FirstName = reader["Firstname"].ToString();
                UserTracker.currentUser.LastName = reader["Lastname"].ToString();
                UserTracker.currentUser.Email = reader["Email"].ToString();
                
            }
                FrmHome home = new FrmHome();
                home.MdiParent = this.MdiParent;
                home.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

;        }

        private void lnkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignUp signUp = new FrmSignUp();
            signUp.MdiParent = this.MdiParent;
            signUp.Show();
            this.Close();
        }
    }
}

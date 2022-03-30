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
    public partial class FrmHome : Form
    {
        User user = new User();   
        public FrmHome()
        {
            InitializeComponent();
        }
        public FrmHome(User u)
        {
            user = u;
            InitializeComponent();
            SqlConnection connection = new SqlConnection(Utilities.GetConnectionString());
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Accounts WHERE UserID = '" + user.Id + "'",connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            txtUserID.Text = user.Id.ToString();
            if (!reader.Read())
            {
                lblNoAccountOpen.Visible = true;
                btnOpenAccount.Visible = true;
            }
            else
            {
                if(reader["Type"].ToString() == "Savings")
                {
                    user.UserAccount = new Savings();
                }else if(reader["Type"].ToString() == "Chequing")
                {
                    user.UserAccount = new Chequing();
                }else if(reader["Type"].ToString() == "Business")
                {
                    user.UserAccount = new Business();
                }

                pnlAccountInfo.Visible = true;
                user.UserAccount.GetBalanceAndCurrency(float.Parse(reader["Balance"].ToString()), reader["Currency"].ToString());
                txtAccountHolder.Text = user.GetFullName();
                txtAccountType.Text = user.UserAccount.GetType().Name;
                txtCurrency.Text = user.UserAccount.Currency;
                txtBalance.Text = "$" + user.UserAccount.Balance;
            }
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            FrmCreateAccount frmCreateAccount = new FrmCreateAccount(user);
            frmCreateAccount.Show();
        }
    }
}

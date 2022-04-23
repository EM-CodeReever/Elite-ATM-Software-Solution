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
        public FrmHome()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(Utilities.GetConnectionString());
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Account] WHERE UserID = '" + UserTracker.currentUser.Id + "'",connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            txtUserID.Text = UserTracker.currentUser.Id.ToString();
            if (!reader.Read())
            {
                lblNoAccountOpen.Visible = true;
                btnOpenAccount.Visible = true;
            }
            else
            {
                if(reader["Type"].ToString() == "Savings")
                {
                    UserTracker.currentUser.UserAccount = new Savings();
                }else if(reader["Type"].ToString() == "Chequing")
                {
                    UserTracker.currentUser.UserAccount = new Chequing();
                }else if(reader["Type"].ToString() == "Business")
                {
                    UserTracker.currentUser.UserAccount = new Business();
                }

                pnlAccountInfo.Visible = true;
                UserTracker.currentUser.UserAccount.GetBalanceAndCurrency(float.Parse(reader["Balance"].ToString()), reader["Currency"].ToString());
                txtAccountHolder.Text = UserTracker.currentUser.GetFullName();
                txtAccountType.Text = UserTracker.currentUser.UserAccount.GetType().Name;
                txtCurrency.Text = UserTracker.currentUser.UserAccount.Currency;
                txtBalance.Text = "$" + UserTracker.currentUser.UserAccount.Balance;
            }
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            FrmCreateAccount frmCreateAccount = new FrmCreateAccount();
            frmCreateAccount.MdiParent = this.MdiParent;
            frmCreateAccount.Show();
            this.Close();
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frmlogin = new FrmLogin();
            frmlogin.MdiParent = this.MdiParent;
            frmlogin.Show();
            this.Close();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            FrmWithdraw frmWithdraw = new FrmWithdraw();
            frmWithdraw.Show();
            frmWithdraw.MdiParent = this.MdiParent;
            this.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            FrmDeposit frmDeposit = new FrmDeposit();
            frmDeposit.Show();
            frmDeposit.MdiParent = this.MdiParent;
            this.Close();
        }
    }
}

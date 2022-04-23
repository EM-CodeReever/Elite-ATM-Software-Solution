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
    public partial class FrmWithdraw : Form
    {
        public FrmWithdraw()
        {
            InitializeComponent();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbWithdrawAmount.Text == "OTHER")
                {
                    if (txtOtherAmount.Text != "")
                    {
                        UserTracker.currentUser.UserAccount.Withdraw(float.Parse(txtOtherAmount.Text));
                        if (!Utilities.UpdateBalance(UserTracker.currentUser.Id, UserTracker.currentUser.UserAccount.Balance))
                        {
                            throw new Exception("UPDATE_STATMENT_FAILED");
                        }
                        MessageBox.Show("Withdrawl Succesful!");
                        FrmHome home = new FrmHome();
                        home.MdiParent = this.MdiParent;
                        home.Show();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Please Enter Other Amount");
                    }

                }
                else
                {
                    if (cbWithdrawAmount.Text != "")
                    {
                        UserTracker.currentUser.UserAccount.Withdraw(float.Parse(cbWithdrawAmount.Text));
                        if (!Utilities.UpdateBalance(UserTracker.currentUser.Id, UserTracker.currentUser.UserAccount.Balance))
                        {
                            throw new Exception("UPDATE_STATMENT_FAILED");
                        }
                        MessageBox.Show("Withdrawl Succesful!");
                        FrmHome home = new FrmHome();
                        home.MdiParent = this.MdiParent;
                        home.Show();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Please Select Amount");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cbWithdrawAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbWithdrawAmount.Text == "OTHER")
            {
                lblOther.Visible = true;
                txtOtherAmount.Visible = true;
            }
            else
            {
                lblOther.Visible = false;
                txtOtherAmount.Visible = false;
            }
        }
    }
}

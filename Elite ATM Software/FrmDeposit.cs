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

namespace Elite_ATM_Software
{
    public partial class FrmDeposit : Form
    {
        public FrmDeposit()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbDepositAmount.Text == "OTHER")
                {
                    if (txtOtherAmount.Text != "")
                    {
                        UserTracker.currentUser.UserAccount.Deposit(float.Parse(txtOtherAmount.Text));
                        if (!Utilities.UpdateBalance(UserTracker.currentUser.Id, UserTracker.currentUser.UserAccount.Balance))
                        {
                            throw new Exception("UPDATE_STATMENT_FAILED");
                        }
                        MessageBox.Show("Deposit Succesful!");
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
                    if (cbDepositAmount.Text != "")
                    {
                        UserTracker.currentUser.UserAccount.Deposit(float.Parse(cbDepositAmount.Text));
                        if (!Utilities.UpdateBalance(UserTracker.currentUser.Id, UserTracker.currentUser.UserAccount.Balance))
                        {
                            throw new Exception("UPDATE_STATMENT_FAILED");
                        }
                        MessageBox.Show("Deposit Succesful!");
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

        private void cbDepositAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepositAmount.Text == "OTHER")
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

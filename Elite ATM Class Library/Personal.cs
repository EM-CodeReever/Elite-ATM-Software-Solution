using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_ATM_Class_Library
{
    public class Personal : Account
    {
        private int MaxDeposit = 100000;
        private int MinDeposit = 0;
        private int AccountLimit = 500000;
        private int WithdrawFee = 250;
       
        override public void Withdraw(float Amt)
        {
            if (Balance > 0 && Balance > (WithdrawFee + Amt))
            {
                Balance -= WithdrawFee;
                Balance -= Amt;
            }
            else
            {
                throw new Exception("INSUFFIECIENT_FUNDS");
            }
            
        }
        override public void Deposit(float Amt)
        {
            if(Amt < MaxDeposit && Amt > MinDeposit && BalanceLimitCheck())
            {
                Balance += Amt;
            }else if(Amt < MaxDeposit && Amt > MinDeposit && !BalanceLimitCheck())
            {
                throw new Exception("EXCEEDS_ACCOUNT_TYPE_LIMIT");

            }
            else
            {
                throw new Exception("DEPOSIT_EXCEEDS_LIMIT_OR_FALLS_BELOW_MINIMUM");
            }
        }
        public bool BalanceLimitCheck()
        {
            return (this.Balance < AccountLimit);
            
        }
    }
}

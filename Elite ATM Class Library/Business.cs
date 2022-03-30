using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_ATM_Class_Library
{
    public class Business : Account
    {
        
        private int MinDeposit { get; } = 1000;
        private int MaxDeposit { get; } = 1000000;
        private int WithdrawFee { get; } = 1500;

     
        public override void Withdraw(float Amt)
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
        public override void Deposit(float Amt)
        {
            if(Amt < MaxDeposit && Amt > MinDeposit)
            {
                Balance += Amt;
            }
            else
            {
                throw new Exception("DEPOSIT_EXCEEDS_LIMIT_OR_FALLS_BELOW_MINIMUM");
            }
        }
    }
}

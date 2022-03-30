using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_ATM_Class_Library
{
    abstract public class Account
    {
        public int UserID { get; set; }
        public float Balance { get; set; }
        public string Currency { get; set; }

        public abstract void Deposit(float Amt);
        public abstract void Withdraw(float Amt);

        public void GetBalanceAndCurrency(float b, string cur)
        {
            Balance = b;
            Currency = cur;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_ATM_Class_Library
{
    public class Savings : Personal
    {
        
        public override void Withdraw(float Amt)
        {
            throw new Exception("CANNOT_WITHDRAW_FROM_ACCOUNT_TYPE_SAVINGS");
        }
    }
}

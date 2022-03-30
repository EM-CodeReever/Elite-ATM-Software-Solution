using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_ATM_Class_Library
{
    public static class Utilities
    {
        public static string DatabaseConnectionString = "Data Source=eliteatmdatabase.mssql.somee.com;Initial Catalog=eliteatmdatabase;Persist Security Info=True;User ID=Svengali_SQLLogin_1;Password=tocx9tglx2";
        public static string GetConnectionString()
        {
            return DatabaseConnectionString;
        }
    }
}

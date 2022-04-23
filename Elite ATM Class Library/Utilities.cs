using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Elite_ATM_Class_Library
{
    public static class Utilities
    {
        public static string DatabaseConnectionString = "Data Source=eliteatmdatabase.mssql.somee.com;Initial Catalog=eliteatmdatabase;Persist Security Info=True;User ID=Svengali_SQLLogin_1;Password=tocx9tglx2";
        public static string GetConnectionString()
        {
            return DatabaseConnectionString;
        }
        public static bool UpdateBalance(int userID, float newBalance)
        {
            SqlConnection connection = new SqlConnection(Utilities.GetConnectionString());
            connection.Open();
            SqlCommand command = new SqlCommand($"UPDATE [Account] SET Balance = {newBalance} WHERE UserID = {userID}",connection);
            int i = command.ExecuteNonQuery();
            if (i > 0)
            {
                connection.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

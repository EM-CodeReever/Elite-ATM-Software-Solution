using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_ATM_Class_Library
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public Account UserAccount { get; set; }

        
        public User()
        {
            FirstName = "";
            LastName = "";
            Password = "";
            Email = "";
            Password = "";
            Id = 0;
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asg03
{
    public class BankUser
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public BankUser(long userID, string firstName, string lastName, string login, string password)
        {
            this.UserId = userID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Login = login;
            this.Password = password;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}", LastName, FirstName);
        }
    }
}

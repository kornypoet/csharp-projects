using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asg04
{
    public class Account
    {
        private int accountID;
        private int customerID;
        private string accountType;
        private decimal accountBalance;
        private bool isAccountOpen;

        public int AccountID { get; set; }
        public int CustomerID { get; set; }
        public string AccountType { get; set; }
        public decimal AccountBalance
        {
            get { return accountBalance; }
            set
            {
                if (value > 0)
                    accountBalance = value;
                else
                    throw new Exception("Account Balance must be positive!");
            }
        }
        public bool IsAccountOpen { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1:C}", AccountType, AccountBalance);
        }
    }
}

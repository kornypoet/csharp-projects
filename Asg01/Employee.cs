using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asg01
{
    class Employee : Person , IPayable
    {
        //Private member variables
        private decimal salary;
        private string mailingAddress;

        //Public property accessors
        public decimal Salary { get; set; }
        public string MailingAddress { get; set; }

        //IPayable interface implemented
        public decimal AmountDue { get; set; }
        public string PaymentAddress
        {
            get { return MailingAddress; }
        }
        public void AmountDueIncrease(decimal increase) {}    
    
        //Blank constructor
        public Employee()
            : base()
        {
            AmountDue = 0m;
            Salary = 49500m;            
        }
    }
}

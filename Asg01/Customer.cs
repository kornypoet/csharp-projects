using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asg01
{
    class Customer : Person , IPayable
    {
        //Private member variables
        private DateTime creationDate;
        private string mailingAddress;

        //Public property accessors
        public DateTime CreationDate { get; set; }
        public string MailingAddress { get; set; }

        //IPayable interface implemented
        public decimal AmountDue { get; set; }
        public string PaymentAddress
        {
            get { return MailingAddress; }
        }              
        public void AmountDueIncrease( decimal increaseBy ) {}

        //Blank constructor
        public Customer()
            : base()
        {
            AmountDue = 795m;
            CreationDate = DateTime.Today;            
        }
    }
}

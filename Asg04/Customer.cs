using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asg04
{
    public class Customer
    {
        private int customerID;
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zipCode;
        private string telephoneNumber;
        private string emailAddress;
        private bool isCustomerActive;
        public List<Account> AccountList = new List<Account>();

        public int CustomerID { get; set; }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value != "")
                    firstName = value;
                else
                    throw new Exception("First Name field is not filled out!");
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value != "")
                    lastName = value;
                else
                    throw new Exception("Last Name field is not filled out!");
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                if (value != "")
                    address = value;
                else
                    throw new Exception("Address field is not filled out!");
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (value != "")
                    city = value;
                else
                    throw new Exception("City field is not filled out!");
            }
        }
        public string State
        {
            get { return state; }
            set
            {
                if (value != "")
                    state = value;
                else
                    throw new Exception("State field is not filled out!");
            }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set
            {
                if (value != "")
                    zipCode = value;
                else
                    throw new Exception("Zip Code field is not filled out!");
            }
        }
        public string TelephoneNumber
        {
            get { return telephoneNumber; }
            set
            {
                if (value != "")
                    telephoneNumber = value;
                else
                    throw new Exception("Telephone field is not filled out!");
            }
        }
        public string EmailAddress
        {
            get { return emailAddress; }
            set
            {
                if (value != "")
                    emailAddress = value;
                else
                    throw new Exception("Email Address field is not filled out!");
            }
        }
        public bool IsCustomerActive { get; set; }        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asg01
{
    class Person
    {
        //Private member variables
        private string firstName;
        private string lastName;
        private string emailAddress;
        private DateTime dateOfBirth;

        //Public property accessors
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        //Constructors
        public Person() { }
        public Person(string first, string last, string email, DateTime birth) { }
        public Person(string first, string last, string email) { }
        public Person(string first, string last, DateTime birthday) { }

        //Read-only properties
        public bool IsAdult
        {
            get
            {
                TimeSpan difference = DateTime.Today - DateOfBirth;
                const int LEGAL_AGE_IN_DAYS = 365 * 18;
                if (difference.Days >= LEGAL_AGE_IN_DAYS)
                    return true;
                else
                    return false;
            }
        }
        public bool IsBirthday
        {
            get
            {
                return (DateTime.Equals(DateOfBirth.Month, DateTime.Today.Month) &&
                        DateTime.Equals(DateOfBirth.Day, DateTime.Today.Day));                 
            }
        }
        public string ScreenName
        {
            get
            {
                return DateOfBirth.Month + LastName + FirstName + DateOfBirth.Year;
            }
        }

        //Override ToString() for listbox display
        public override string ToString()
        {
            return LastName + ", " + FirstName;
        }
    }
}

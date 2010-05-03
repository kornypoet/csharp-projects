using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Asg04
{
    class DatabaseService
    {
        public static OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Asg04.accdb;");

        //No exceptions needed; all error checking is done by the form
        //and Customer and Account classes
        public static void AddCustomer(Customer cust)
        {
            myConnection.Open();
            string commandString = string.Format
                ("INSERT INTO Customers (FirstName, LastName, Address, City, State, Zipcode, TelephoneNumber, IsCustomerActive, EmailAddress) VALUES (@FirstName, @LastName, @Address, @City, @State, @ZipCode, @TelephoneNumber, @IsCustomerActive, @EmailAddress)");
            OleDbCommand myCommand = new OleDbCommand(commandString, myConnection);
            
            myCommand.Parameters.AddWithValue("@FirstName", cust.FirstName);
            myCommand.Parameters.AddWithValue("@LastName", cust.LastName);
            myCommand.Parameters.AddWithValue("@Address", cust.Address);
            myCommand.Parameters.AddWithValue("@City", cust.City);
            myCommand.Parameters.AddWithValue("@State", cust.State);
            myCommand.Parameters.AddWithValue("@ZipCode", cust.ZipCode);
            myCommand.Parameters.AddWithValue("@TelephoneNumber", cust.TelephoneNumber);
            myCommand.Parameters.AddWithValue("@IsCustomerActive", cust.IsCustomerActive);
            myCommand.Parameters.AddWithValue("@EmailAddress", cust.EmailAddress);
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
        public static void EditCustomer(Customer cust)
        {
            myConnection.Open();
            string commandString = string.Format
                ("UPDATE Customers Set FirstName=@FirstName, LastName=@LastName, Address=@Address, City=@City, State=@State, ZipCode=@ZipCode, TelephoneNumber=@TelephoneNumber, IsCustomeractive=@IsCustomerActive, EmailAddress=@EmailAddress WHERE CustomerID = {0}", cust.CustomerID);
            OleDbCommand myCommand = new OleDbCommand(commandString, myConnection);

            myCommand.Parameters.AddWithValue("@FirstName", cust.FirstName);
            myCommand.Parameters.AddWithValue("@LastName", cust.LastName);
            myCommand.Parameters.AddWithValue("@Address", cust.Address);
            myCommand.Parameters.AddWithValue("@City", cust.City);
            myCommand.Parameters.AddWithValue("@State", cust.State);
            myCommand.Parameters.AddWithValue("@ZipCode", cust.ZipCode);
            myCommand.Parameters.AddWithValue("@TelephoneNumber", cust.TelephoneNumber);
            myCommand.Parameters.AddWithValue("@IsCustomerActive", cust.IsCustomerActive);
            myCommand.Parameters.AddWithValue("@EmailAddress", cust.EmailAddress);
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
        public static void RemoveCustomer(Customer cust)
        {
            foreach (Account acc in cust.AccountList)
            {
                DatabaseService.RemoveAccount(acc);
            }
            myConnection.Open();
            string commandString = string.Format
                ("DELETE FROM Customers WHERE CustomerID = {0}", cust.CustomerID);
            OleDbCommand myCommand = new OleDbCommand(commandString, myConnection);
            myCommand.ExecuteNonQuery();

            myConnection.Close();
        }
        public static Customer RetrieveCustomer(string email)
        {
            myConnection.Open();
            string commandString = string.Format
                ("SELECT * FROM Customers WHERE EmailAddress = '{0}'", email);
            OleDbCommand myCommand = new OleDbCommand(commandString, myConnection);
            OleDbDataReader myReader = myCommand.ExecuteReader();
            if (myReader.Read())
            {
                Customer cust = new Customer();
                cust.CustomerID = myReader.GetInt32(0);
                cust.FirstName = myReader.GetString(1);
                cust.LastName = myReader.GetString(2);
                cust.Address = myReader.GetString(3);
                cust.City = myReader.GetString(4);
                cust.State = myReader.GetString(5);
                cust.ZipCode = myReader.GetString(6);
                cust.TelephoneNumber = myReader.GetString(7);
                cust.IsCustomerActive = myReader.GetBoolean(8);
                cust.EmailAddress = myReader.GetString(9);

                myReader.Close();
                myConnection.Close();
                return cust;
            }
            else
            {
                myReader.Close();
                myConnection.Close();
                Customer cust = null;
                return cust;
            }
        }
        public static void AddAccount(Account acc, Customer cust)
        {
            myConnection.Open();
            string commandString = string.Format
                ("INSERT INTO Accounts (CustomerID, AccountType, AccountBalance, IsAccountOpen) VALUES (@CustomerID, @AccountType, @AccountBalance, @IsAccountOpen)");
            OleDbCommand myCommand = new OleDbCommand(commandString, myConnection);
            myCommand.Parameters.AddWithValue("@CustomerID", cust.CustomerID);
            myCommand.Parameters.AddWithValue("@AccountType", acc.AccountType);
            myCommand.Parameters.AddWithValue("@AccountBalance", acc.AccountBalance);
            myCommand.Parameters.AddWithValue("@IsAccountOpen", acc.IsAccountOpen);
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
        public static void EditAccount(Account acc)
        {
            myConnection.Open();
            string commandString = string.Format
                ("UPDATE Accounts Set AccountType=@AccountType, AccountBalance=@AccountBalance, IsAccountOpen=@IsAccountOpen WHERE AccountID = {0}", acc.AccountID);
            OleDbCommand myCommand = new OleDbCommand(commandString, myConnection);
            myCommand.Parameters.AddWithValue("@AccountType", acc.AccountType);
            myCommand.Parameters.AddWithValue("@AccountBalance", acc.AccountBalance);
            myCommand.Parameters.AddWithValue("@IsAccountOpen", acc.IsAccountOpen);
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
        public static void RemoveAccount(Account acc)
        {
            myConnection.Open();
            string commandString = string.Format
                ("DELETE FROM Accounts WHERE AccountID = {0}", acc.AccountID);
            OleDbCommand myCommand = new OleDbCommand(commandString, myConnection);
            myCommand.ExecuteNonQuery();

            myConnection.Close();
        }
        public static List<Account> RetrieveAccounts(Customer cust)
        {
            myConnection.Open();
            string commandString = string.Format
                ("SELECT * FROM Accounts WHERE CustomerID = {0}", cust.CustomerID);
            OleDbCommand myCommand = new OleDbCommand(commandString, myConnection);
            OleDbDataReader myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                Account acc = new Account();
                acc.AccountID = myReader.GetInt32(0);
                acc.CustomerID = myReader.GetInt32(1);
                acc.AccountType = myReader.GetString(2);
                acc.AccountBalance = myReader.GetDecimal(3);
                acc.IsAccountOpen = myReader.GetBoolean(4);
                
                cust.AccountList.Add(acc);
            }
            myReader.Close();
            myConnection.Close();
            return cust.AccountList;
        }
    }
}

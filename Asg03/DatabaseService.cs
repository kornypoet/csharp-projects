using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Asg03
{
    class DatabaseService
    {
        public static OleDbConnection myConnection = new OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Asg03.accdb;");

        public static BankUser RetrieveUser(string login, string password)
        {
            myConnection.Open();
            string commandString = String.Format("SELECT * FROM BankUsers WHERE Login = '{0}'", login);
            OleDbCommand myCommand = new OleDbCommand(commandString, myConnection);
            OleDbDataReader myReader = myCommand.ExecuteReader();

            if (myReader.Read())
            {
                if (password == (string)myReader["Password"])
                {
                    BankUser bankUser = new BankUser(
                        myReader.GetInt32(0),
                        myReader.GetString(1),
                        myReader.GetString(2),
                        myReader.GetString(3),
                        myReader.GetString(4));
                    myReader.Close();
                    myConnection.Close();
                    return bankUser;
                }
                else
                {
                    myReader.Close();
                    myConnection.Close();
                    throw new Exception();
                }
            }
            else
            {
                myReader.Close();
                myConnection.Close();
                throw new Exception();
            }
        }        
    }
}

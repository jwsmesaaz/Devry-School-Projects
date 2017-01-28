using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Pulls in extra libraries
using System.Data.OleDb;
using System.Net;
using System.Data;

namespace CIS407Project
{
    public class clsDataLayer
    {        
        public static dsPersonnel GetPersonnel(string Database, string strSearch)
        {
            //Initializes the dataset and Set to look at the dataset
            dsPersonnel DS = new dsPersonnel();
            //Initializes the SQL connection and Sets the connection so it will look at the correct database
            OleDbConnection sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Database);
            //Initializes the adapter
            OleDbDataAdapter sqlDA;

            //If statment for if there is information in the strSearch
            if (strSearch == null || strSearch.Trim() == "")
            {
                //Sets the SQL be be using the connection
                sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
            }
            else
            {
                //Sets the SQL be be using the connection
                sqlDA = new OleDbDataAdapter("select * from tblPersonnel where " + strSearch, sqlConn);
            }

            //Gets the information from the dataset
            sqlDA.Fill(DS.tblPersonnel);

            //Returns what is in the dataset
            return DS;
        }

        //This function gets the user activity from the tblUserActivity
        public static dsUserActivity GetUserActivity (string Database)
        {
            //Initializes the dataset 
            dsUserActivity DS;
            //Initializes the SQL connection
            OleDbConnection sqlConn;
            //Initializes the adapter
            OleDbDataAdapter sqlDA;

            //Sets the connection so it will look at the correct database
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Database);

            //Sets the SQL be be using the connection
            sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);

            //Set to look at the dataset
            DS = new dsUserActivity();

            //Gets the information from the dataset
            sqlDA.Fill(DS.tblUserActivity);

            //Returns what is in the dataset
            return DS;
        }

        //This function saves the user activity
        public static void SaveUserActivity(string Database, string FormAccessed)
        {
            //Initializes and declares the connection to look at the database passed to this function
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Database);
            //Opens the connection
            conn.Open();
            //Initializes and sets the create command
            OleDbCommand command = conn.CreateCommand();
            //Initializes the SQL string
            string strSQL;

            //Creates the SQL statment for the data
            strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" + GetIP4Address() + "', '" + FormAccessed + "')";

            //Sets the command type
            command.CommandType = CommandType.Text;
            //Prepares the string to be executed
            command.CommandText = strSQL;
            //Exicutes command to put the information into the database
            command.ExecuteNonQuery();
            //Closes the connection
            conn.Close();
        }

        //This function gets the IP Address
        public static string GetIP4Address()
        {
            //Initializes the variable and sets it to empty
            string IP4Address = string.Empty;

            //loop that will get the IP
            foreach (IPAddress IPA in Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    //Sets the IP address to the Variable
                    IP4Address = IPA.ToString();
                    //Removes from loop
                    break;
                }
            }
            //If the IP is not empty then it will return the IP address otherwise it wull try to find it
            if (IP4Address != string.Empty)
            {
                //Returns the IP address
                return IP4Address;
            }
            //Loop to grab the Host Address
            foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                //Finds and returns Host
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    //Sets variable to the IP address
                    IP4Address = IPA.ToString();
                    //Removes from the loop
                    break;
                }
            }
            //Returns the IP address
            return IP4Address;
        }

        // This function saves the personnel data
        public static bool SavePersonnel(string Database, string FirstName, string LastName, string PayRate, string StartDate, string EndDate)
        {
            //This initializes the variable for if the record was saved or not
            bool recordSaved;

            //Begins a transaction request
            OleDbTransaction myTransaction = null;

            //This will try to add the information into the database. If it doesn't get added then it will throw the exception
            try
            {
                //Created connection to the database scource
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                                                           "Data Source=" + Database);
                //Opens the connection
                conn.Open();
                //Creates the command for the connection
                OleDbCommand command = conn.CreateCommand();
                //initializes the string for the SQL statment
                string strSQL;

                //Creates connection for the transaction
                myTransaction = conn.BeginTransaction();
                //Command for the transaction
                command.Transaction = myTransaction;

                //Created the SQL statment
                strSQL = "Insert into tblPersonnel " +
                         "(FirstName, LastName) values ('" +
                         FirstName + "', '" + LastName + "')";

                //Sets the type of command to the database
                command.CommandType = CommandType.Text;
                //Sets the SQL statment for the command
                command.CommandText = strSQL;

                //Actually inserts the rows into the database
                command.ExecuteNonQuery();

                // Add your comments here
                strSQL = "Update tblPersonnel " +
                         "Set PayRate=" + PayRate + ", " +
                         "StartDate='" + StartDate + "', " +
                         "EndDate='" + EndDate + "' " +
                         "Where ID=(Select Max(ID) From tblPersonnel)";

                //Sets the type of command to the database
                command.CommandType = CommandType.Text;
                //Sets the SQL statment for the command
                command.CommandText = strSQL;

                //Actually inserts the rows into the database
                command.ExecuteNonQuery();

                //Commits the transaction if it validates the information.
                myTransaction.Commit();

                //Closes the connection
                conn.Close();
                //Says the record was saved correctly
                recordSaved = true;
            }
            catch (Exception ex)
            {
                //Rolls back the transaction if it fails
                myTransaction.Rollback();
                
                //Says that the record wasn't saved correctly
                recordSaved = false;
            }
            //Returns to the code that called if it was saved correctly or not
            return recordSaved;
        }
        //This function verifies a user in the tblUser table
        public static dsUser VerifyUser(string Database, string UserName, string UserPassword)
        {
            //Initializes the datasheet
            dsUser DS;
            //Initializes the Connection
            OleDbConnection sqlConn;
            //Initializes the Adapter
            OleDbDataAdapter sqlDA;

            //sets the Connection
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                                          "Data Source=" + Database);

            //Prepares the adapter
            sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserLogin " +
                                          "where UserName like '" + UserName + "' " +
                                          "and UserPassword like '" + UserPassword + "'", sqlConn);

            //Sets the data set equal to the User table
            DS = new dsUser();

            //Fills the Adapter
            sqlDA.Fill(DS.tblUserLogin);

            //Returns the information about the user permission level
            return DS;

        }

        public static bool SaveUser(string Database, string UserName, string Password, string Permission)
        {
            //This initializes the variable for if the record was saved or not
            bool recordSaved;

            //Begins a transaction request
            OleDbTransaction myTransaction = null;

            //This will try to add the information into the database. If it doesn't get added then it will throw the exception
            try
            {
                //Created connection to the database scource
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                                                           "Data Source=" + Database);
                //Opens the connection
                conn.Open();
                //Creates the command for the connection
                OleDbCommand command = conn.CreateCommand();
                //initializes the string for the SQL statment
                string strSQL;

                //Creates connection for the transaction
                myTransaction = conn.BeginTransaction();
                //Command for the transaction
                command.Transaction = myTransaction;

                //Created the SQL statment
                strSQL = "Insert into tblUserLogin " +
                         "(UserName, UserPassword, SecurityLevel) values ('" +
                         UserName + "', '" + Password + "', '" + Permission + "')";

                //Sets the type of command to the database
                command.CommandType = CommandType.Text;
                //Sets the SQL statment for the command
                command.CommandText = strSQL;

                //Actually inserts the rows into the database
                command.ExecuteNonQuery();

                //Commits the transaction if it validates the information.
                myTransaction.Commit();

                //Closes the connection
                conn.Close();
                //Says the record was saved correctly
                recordSaved = true;
            }
            catch (Exception ex)
            {
                //Rolls back the transaction if it fails
                myTransaction.Rollback();

                //Says that the record wasn't saved correctly
                recordSaved = false;
            }
            //Returns to the code that called if it was saved correctly or not
            return recordSaved;
        }
    }
}
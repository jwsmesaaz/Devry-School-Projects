using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Add your comments here
using System.Data.OleDb;
using System.Net;
using System.Data;

namespace CIS407Project
{
    public class clsDataLayer
    {
        public static dsUserActivity GetUserActivity (string Database)
        // This function gets the user activity from the tblUserActivity
        //public static dsUserActivity GetUserActivity(string Database)
        {
            // Add your comments here
            dsUserActivity DS;
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;

            // Add your comments here
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                "Data Source=" + Database);

            // Add your comments here
            sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);

            // Add your comments here
            DS = new dsUserActivity();

            // Add your comments here
            sqlDA.Fill(DS.tblUserActivity);

            // Add your comments here
            return DS;
        }

        // This function saves the user activity
        public static void SaveUserActivity(string Database, string FormAccessed)
        {
            // Add your comments here
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;

            strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" +
                GetIP4Address() + "', '" + FormAccessed + "')";

            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            command.ExecuteNonQuery();
            conn.Close();
        }

        // This function gets the IP Address
        public static string GetIP4Address()
        {
            string IP4Address = string.Empty;

            foreach (IPAddress IPA in
                        Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }

            if (IP4Address != string.Empty)
            {
                return IP4Address;
            }

            foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }

            return IP4Address;
        }
    }
}
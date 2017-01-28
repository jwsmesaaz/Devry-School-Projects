using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace CIS407Project
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Code to remove the session cookie            
            Session.Remove("SecurityLevel");
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
        //Initializes the UserLoging
        dsUser dsUserLogin;

        //Initializes the security level
        string SecurityLevel;

        //Sets the User Login information
        dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.mdb"),
                         Login1.UserName, Login1.Password);

        //Confirms if they are a user or not. If not they they are not verified
        if (dsUserLogin.tblUserLogin.Count < 1)
        {
            //Displays that there was an error
            linkError.Visible = true;
            //Doesn't Authenticate
            e.Authenticated = false;

            //If the login failed then an email is sent off
            if (clsBusinessLayer.SendEmail("jonsmithschool@gmail.com",
                "jwsmesaaz@gmail.com", "", "", "Login Incorrect",
                "The login failed for UserName: " + Login1.UserName +
                " Password: " + Login1.Password))
            {
                //If the email is successful then it lets the hacker know.
                Login1.FailureText = Login1.FailureText +
                    " Your incorrect login information was sent to receiver@receiverdomain.com";

            }
            return;
        }

        //Figures out the security level
        SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();

        //Switch to find the Security Level
        switch (SecurityLevel)
        {
            //If they are an Admin
            case "Admin":
                linkError.Visible = false;
                //Authenticates the user
                e.Authenticated = true;
                //Creates the cookie
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                //Sets a session as Admin
                Session["SecurityLevel"] = "Admin";
                //Stops the switch
                break;
            //If they are a User
            case "User":
                linkError.Visible = false;
                // Add your comments here
                e.Authenticated = true;
                //Creates the cookie
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                //Sets the session as User
                Session["SecurityLevel"] = "User";
                //Stops the switch
                break;
            //Handles everything else
            default:
                linkError.Visible = true;
                //Doesn't authenticate
                e.Authenticated = false;
                //Stops the switch
                break;
        }
        }
    }
}
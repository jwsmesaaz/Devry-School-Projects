using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407Project
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Creates an entry into the database for this page when the user lands on it.
            clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.mdb"), "frmManageUsers");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Initializes variable and sets it to true
            Boolean blnReadyToSave = true;
            
            //If statement for confirming that there is something inside of the Password field
            if (txtPassword.Text == null || txtPassword.Text == "")
            {
                //Sets the Label for the person to enter a password
                lblMessage.Text = "You must enter a password or they can't get in.";
                //Puts the curser into the password field
                txtPassword.Focus();
                //Sets variable to false because it isn't ready to be submitted
                blnReadyToSave = false;
            }
            else
            {
                
            }
            //If statement for confirming that there is something inside of the user name field
            if (txtUserName.Text == null || txtUserName.Text == "")
            {
                //Sets the Label for the person to enter a user name
                lblMessage.Text = "You must enter a User Name or they can't get in.";
                //Puts the curser into the user name field
                txtUserName.Focus();
                //Sets variable to false because it isn't ready to be submitted
                blnReadyToSave = false;
            }
            else
            {
                
            }
            //If statement for if everything is good or not
            if (blnReadyToSave == true)
            {
                //Initializes username variable
                String strUserName;
                //Initializes password variable
                String strPassword;
                //Initializes permissions variable
                String strPermission;

                //sets the user name
                strUserName = txtUserName.Text;
                //sets the password
                strPassword = txtPassword.Text;
                //sets the permissions
                strPermission = ddlUserPermissions.SelectedValue.ToString();

                //If statement for saving the user or erroring out
                if (clsDataLayer.SaveUser(Server.MapPath("PayrollSystem_DB.mdb"),
                                               strUserName,
                                               strPassword,
                                               strPermission))
                {
                    //Displays the information was saved correctly
                    lblMessage.Text = "The User was successfully saved!";
                    //This refreshes the gridview
                    grdCurrentUsers.DataBind();
                }
                else
                {
                    //Displays that the information was not saved correctly
                    lblMessage.Text = "The User was NOT saved.";
                }
            }
            else
            {

            }
            
        }
    }
}
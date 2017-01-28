using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407Project
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Creates an entry into the database for this page when the user lands on it.
            clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.mdb"), "frmPersonnelVerified");

            //Writes information into the text box
            txtVerifiedInfo.Text = Session["txtFirstName"].ToString() +
                //Return then Last Name
                "\n" + Session["txtLastName"].ToString() +
                //Return then Pay Rate
                "\n" + Session["txtPayRate"].ToString() +
                //Return then Start Date
                "\n" + Session["txtStartDate"].ToString() +
                //Return then End Date
                "\n" + Session["txtEndDate"].ToString();

            if (!Page.IsPostBack)
            {
                //Sends information to the database to be saved
                if (clsDataLayer.SavePersonnel(Server.MapPath("PayrollSystem_DB.mdb"),
                                               Session["txtFirstName"].ToString(),
                                               Session["txtLastName"].ToString(),
                                               Session["txtPayRate"].ToString(),
                                               Session["txtStartDate"].ToString(),
                                               Session["txtEndDate"].ToString()))
                {
                    //Displays the information was saved correctly
                    txtVerifiedInfo.Text = txtVerifiedInfo.Text + "\nThe information was successfully saved!";
                }
                else
                {
                    //Displays that the information was not saved correctly
                    txtVerifiedInfo.Text = txtVerifiedInfo.Text + "\nThe information was NOT saved.";
                }
            }
            else
            {

            }
            
        }

        protected void btnViewPersonnel_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmViewPersonnel.aspx");
        }
    }
}
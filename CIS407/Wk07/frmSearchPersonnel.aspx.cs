using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407Project
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Displays who has been looking at the search personnel page
            clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.mdb"), "frmSearchPersonnel");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //Initializes the variable and declares it equal to the textbox
            if (txtSearchName.Text == "" || txtSearchName.Text == null)
            {
                Session["txtLastNameSearch"] = null;
            }
            else
            {
                if (rbtFirstLast.Checked == true)
                {
                    Session["txtLastNameSearch"] = "FirstName = '" + txtSearchName.Text + "' or LastName = '" + txtSearchName.Text + "'";
                }
                if (rbtFirst.Checked == true)
                {
                    Session["txtLastNameSearch"] = "FirstName = '" + txtSearchName.Text + "'";
                }
                if (rbtLast.Checked == true)
                {
                    Session["txtLastNameSearch"] = "LastName = '" + txtSearchName.Text + "'";
                }                
            }

            //Sends the user to view the personnel
            Response.Redirect("frmViewPersonnel.aspx");
        }
    }
}
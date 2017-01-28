using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407Project
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Displays who has been looking at the user activity page
            clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.mdb"), "frmUserActivity");

            //If this is a Post back event then it will do the following
            if (!Page.IsPostBack)
            {
                //Initializes and Declares the DataSet
                dsUserActivity myDataSet = new dsUserActivity();

                //Fills the data set from the payroll database using the function that was built
                myDataSet = clsDataLayer.GetUserActivity(Server.MapPath("PayrollSystem_DB.mdb"));

                //Writes the Database to to the Grid based on what is returned above
                grdUserActivity.DataSource = myDataSet.Tables["tblUserActivity"];

                //Committs it to the page
                grdUserActivity.DataBind();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407Project
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Displays who has been looking at the View Personnel page
            clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.mdb"), "frmViewPersonnel");

            //If this isn't a postback then do the following
            if (!Page.IsPostBack)
            {
                //Initializes and declares dataset
                dsPersonnel myDataSet = new dsPersonnel();
                string strString = null;
                if (Session["txtLastNameSearch"] != null)
                {
                    strString = Session["txtLastNameSearch"].ToString();
                }
                
                if (strString == null)
                {
                    //Calls the information
                    myDataSet = clsDataLayer.GetPersonnel(Server.MapPath("PayrollSystem_DB.mdb"), strString);
                }
                else
                {
                    //Calls the information
                    myDataSet = clsDataLayer.GetPersonnel(Server.MapPath("PayrollSystem_DB.mdb"), strString);
                }

                //Populates the datagrid area on this page
                grdViewPersonnel.DataSource = myDataSet.Tables["tblPersonnel"];

                //Committs the information to the grid
                grdViewPersonnel.DataBind();

                //Sets to null after being used
                Session["txtLastNameSearch"] = null;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407Project
{
    public partial class CoolBizMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string strSecurityLevel = Session["SecurityLevel"].ToString();
                switch (strSecurityLevel)
                {
                    case "Admin":
                        break;
                    case "User":
                        break;
                    default:
                        Response.Redirect("frmLogin.aspx");
                        break;
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("frmLogin.aspx");
            }
        }

        protected void btnLogOff_Click(object sender, EventArgs e)
        {
            Session["SecurityLevel"] = null;
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }
    }
}
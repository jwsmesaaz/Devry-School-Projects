using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace a2zinvitations
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (pnlwebsite.Visible == true)
            {
                pnlwebsite.Visible = false;
                pnl01.Visible = true;
                pnl02.Visible = false;
                pnl03.Visible = false;
                pnl04.Visible = false;
                Timer1.Interval = 2000;
            }
            else if (pnl01.Visible == true)
            {
                pnlwebsite.Visible = false;
                pnl01.Visible = false;
                pnl02.Visible = true;
                pnl03.Visible = false;
                pnl04.Visible = false;
            }
            else if (pnl02.Visible == true)
            {
                pnlwebsite.Visible = false;
                pnl01.Visible = false;
                pnl02.Visible = false;
                pnl03.Visible = true;
                pnl04.Visible = false;
            }
            else if (pnl03.Visible == true)
            {
                pnlwebsite.Visible = false;
                pnl01.Visible = false;
                pnl02.Visible = false;
                pnl03.Visible = false;
                pnl04.Visible = true;
            }
            else
            {
                pnlwebsite.Visible = true;
                pnl01.Visible = false;
                pnl02.Visible = false;
                pnl03.Visible = false;
                pnl04.Visible = false;
                Timer1.Interval = 20000;
            }
        }
    }
}
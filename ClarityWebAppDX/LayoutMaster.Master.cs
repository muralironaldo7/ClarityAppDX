using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClarityWebAppDX
{
    public partial class LayoutMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Session["LoginID"] != null)
                {
                    Response.Redirect("Dashboard.aspx");
                }
            }
        }
    }
}
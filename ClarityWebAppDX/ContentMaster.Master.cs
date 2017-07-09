using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClarityWebAppDX
{
    public partial class ContentMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LeftMenuBar_ItemClick(object source, DevExpress.Web.NavBarItemEventArgs e)
        {
            switch(e.Item.Name.ToLower())
            {
                case "newquestionnaire":
                    Response.Redirect("NewQuestionnaire.aspx", true);
                    break;

                case "editquestionnaire":
                    Response.Redirect("EditQuestionnaire.aspx", true);
                    break;
                case "viewquestionnaire":
                    Response.Redirect("ViewQuestionnaire.aspx", true);
                    break;
                case "dashboard":
                    Response.Redirect("Dashboard.aspx", true);
                    break;
            }
        }
    }
}
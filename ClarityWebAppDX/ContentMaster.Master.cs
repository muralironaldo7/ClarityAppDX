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
            if(!IsPostBack)
            {
                if(Session["LoginID"] != null)
                {
                    lblFullName.Text = Session["FullName"].ToString();
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
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
                case "logout":
                    Response.Redirect("Logout.aspx", true);
                    break;
                case "usermanagement":
                    Response.Redirect("UserManagement.aspx", true);
                    break;
                case "physicianmanagement":
                    Response.Redirect("Physicians.aspx", true);
                    break;
                case "patientschedule":
                    Response.Redirect("PatientList.aspx", true);
                    break;
            }
        }

        protected void cmdLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Logout.aspx");
        }
    }
}
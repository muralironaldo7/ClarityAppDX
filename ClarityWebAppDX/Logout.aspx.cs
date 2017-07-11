using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clarity.DataAccess;
using System.Configuration;
using System.Data;

namespace ClarityWebAppDX
{
    public partial class LogoutPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["LoginID"] != null)
            {
                DataAccessProvider DBAgent = null;
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamRefID", Session["LoginID"]);
                DBAgent.AddParameter("@ParamRefType", "Users");
                DBAgent.AddParameter("@ParamAction", "LO");
                DBAgent.ExecuteNonQuery("dbo.spAddUserAction");
            }
            
            Session.Clear();
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));

            Response.Redirect("Login.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clarity.CryptoProvider;
using Clarity.DataAccess;
using System.Configuration;
using System.Data;


namespace ClarityWebAppDX
{
    public partial class ResetPasswordPage : System.Web.UI.Page
    {
        CryptoProvider securityAgent = null;
        DataAccessProvider DBAgent = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack && !IsCallback)
                {
                    securityAgent = new CryptoProvider();
                    if (Request.QueryString["UID"] != null && Request.QueryString["UN"] != null)
                    {
                        txtUserName.Text = securityAgent.decryptText(Request.QueryString["UN"].Replace(" ", "+"));
                        txtPassword.Focus();
                    }
                    else
                    {
                        Response.Redirect("Logout.aspx");
                    }
                }
            }
            catch(Exception ex)
            {
                lblErr.Text = "There was a problem processing your request. Please contact IT.";
                lblErr.Visible = true;
                CommonHelpers.writeLogToFile("Page_Load: ResetPassword.aspx.aspx", ex.Message);
            }
            
        }

        protected void cmdSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPassword.Text.Equals(txtConfirm.Text))
                {
                    securityAgent = new CryptoProvider();
                    DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                    DBAgent.AddParameter("@ParamLoginID", securityAgent.decryptText(Request.QueryString["UID"].Replace(" ", "+")));
                    DBAgent.AddParameter("@ParamNewPassword", securityAgent.EncryptText(txtNewPassword.Text));
                    DBAgent.AddParameter("@ParamIsTempPassword", 0);
                    DBAgent.ExecuteNonQuery("dbo.spUpdatePassword");

                    Session["Username"] = securityAgent.decryptText(Request.QueryString["UN"].Replace(" ", "+"));
                    Session["LoginID"] = securityAgent.decryptText(Request.QueryString["UID"].Replace(" ", "+"));
                    Response.Redirect("Dashboard.aspx");
                }

            }
            catch (Exception ex)
            {
                lblErr.Text = "There was a problem processing your request. Please contact IT.";
                lblErr.Visible = true;
                CommonHelpers.writeLogToFile("cmdSubmit_Click: ResetPassword.aspx.aspx", ex.Message);
            }
        }
    }
}
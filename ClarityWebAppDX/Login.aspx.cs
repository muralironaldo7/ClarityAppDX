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
    public partial class LoginPage : System.Web.UI.Page
    {

        CryptoProvider securityAgent = null;
        DataAccessProvider DBAgent = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }

        protected void cmdLogin_Click(object sender, EventArgs e)
        {
            try
            {
                lblErr.Text = "";
                bool ValidUser = false;
                bool TempPassword = false;
                securityAgent = new CryptoProvider();
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamUserName", txtUserName.Value);
                string data = DBAgent.ExecuteStoredProcedure("dbo.spGetUserDetails");
                if (string.IsNullOrEmpty(data))
                {
                    ValidUser = false;
                    lblErr.Text = "Invalid Username/Password conbination. Please try again";

                    DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                    DBAgent.AddParameter("@ParamRefID", 0);
                    DBAgent.AddParameter("@ParamRefType", "Users");
                    DBAgent.AddParameter("@ParamAction", "FL");
                    DBAgent.AddParameter("@ParamComment", "Login Failed - " + txtUserName.Value);
                    DBAgent.ExecuteNonQuery("dbo.spAddUserAction");

                }
                else
                {
                    DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                    if (ds.Tables.Count > 0)
                    {
                        DataRow dRow = ds.Tables[0].Rows[0];
                        string upassword = "";
                        if ((bool.Parse(dRow["IsTempPassword"].ToString())))
                        {
                            upassword = dRow["Password"].ToString();
                            TempPassword = true;
                        }
                        else
                        {
                            TempPassword = false;
                            string test = securityAgent.EncryptText("ClarityApp");
                            upassword = securityAgent.decryptText(dRow["Password"].ToString().Replace(" ", "+"));
                        }

                        if (upassword.Equals(txtPassword.Value))
                        {

                            DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                            DBAgent.AddParameter("@ParamRefID", dRow["LoginID"].ToString());
                            DBAgent.AddParameter("@ParamRefType", "Users");
                            DBAgent.AddParameter("@ParamAction", "LI");
                            DBAgent.ExecuteNonQuery("dbo.spAddUserAction");

                            ValidUser = true;
                            
                            Session["FullName"] = String.Format("{0}, {1}", dRow["LastName"], dRow["FirstName"]);
                            if (!TempPassword)
                            {
                                Session["LoginID"] = dRow["LoginID"].ToString();
                                Session["UserName"] = dRow["Username"].ToString();
                                Response.Redirect("Dashboard.aspx", true);
                            }
                            else
                            {
                                Response.Redirect(String.Format("ResetPassword.aspx?UN={0}&UID={1}", securityAgent.EncryptText(txtUserName.Text), securityAgent.EncryptText(dRow["LoginID"].ToString())), true);
                            }
                        }
                        else
                        {
                            ValidUser = false;
                            lblErr.Text = "Invalid Username/Password conbination. Please try again";

                            DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                            DBAgent.AddParameter("@ParamRefID", 0);
                            DBAgent.AddParameter("@ParamRefType", "Users");
                            DBAgent.AddParameter("@ParamAction", "FL");
                            DBAgent.AddParameter("@ParamComment", "Login Failed - " + txtUserName.Value);
                            DBAgent.ExecuteNonQuery("dbo.spAddUserAction");


                        }
                    }
                }
            }
            catch(Exception ex)
            {
                lblErr.Text = "There was a problem processing your request. Please contact IT.";
                lblErr.Visible = true;
                CommonHelpers.writeLogToFile("cmdLogin_Click: Login.aspx", ex.Message);
            }
        }
    }
}
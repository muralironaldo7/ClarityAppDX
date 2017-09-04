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
    public partial class UserManagement : System.Web.UI.Page
    {
        CryptoProvider securityAgent = null;
        DataAccessProvider DBAgent = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && !IsCallback)
            {
                UserGridView.DataBind();
            }

        }

        protected void UserGridView_DataBinding(object sender, EventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                string data = DBAgent.ExecuteStoredProcedure("dbo.spGetAllUsers");
                DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                if (ds.Tables.Count > 0)
                {
                    UserGridView.DataSource = ds.Tables[0];
                }
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("UserGridView_DataBinding: UserManagement.aspx", ex.Message);
            }
            
        }

        protected void UserGridView_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamLoginID", e.Keys[0]);
                DBAgent.AddParameter("@ParamUpdatedBy", Session["LoginID"]);
                DBAgent.ExecuteNonQuery("dbo.spDeleteUser");
                e.Cancel = true;
                UserGridView.DataBind();
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("UserGridView_RowDeleting: UserManagement.aspx", ex.Message);
            }
        }

        protected void UserGridView_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            try
            {
                securityAgent = new CryptoProvider();
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamUserName", e.NewValues["UserName"]);
                DBAgent.AddParameter("@ParamFirstName", e.NewValues["FirstName"]);
                DBAgent.AddParameter("@ParamLastName", e.NewValues["LastName"]);
                DBAgent.AddParameter("@ParamPassword", securityAgent.GetTemporaryPassword());
                DBAgent.AddParameter("@ParamModifiedBy", Session["LoginID"]);
                DBAgent.ExecuteNonQuery("dbo.spAddUser");
                e.Cancel = true;
                UserGridView.CancelEdit();
                UserGridView.DataBind();
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("UserGridView_RowInserting: UserManagement.aspx", ex.Message);
            }
        }

        protected void UserGridView_CustomButtonCallback(object sender, DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs e)
        {
            try
            {
                securityAgent = new CryptoProvider();
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamLoginID", UserGridView.GetRowValues(e.VisibleIndex, "LoginID"));
                DBAgent.AddParameter("@ParamNewPassword", securityAgent.GetTemporaryPassword());
                DBAgent.AddParameter("@ParamIsTempPassword", 1);
                DBAgent.AddParameter("@ParamComment", "Password reset by Admin");
                DBAgent.ExecuteNonQuery("dbo.spUpdatePassword");

                UserGridView.DataBind();
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("UserGridView_CustomButtonCallback: UserManagement.aspx", ex.Message);
            }
        }
    }
}
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
            DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
            string data = DBAgent.ExecuteStoredProcedure("dbo.spGetAllUsers");
            DataSet ds = CommonHelpers.GetDataSetFromXml(data);
            if (ds.Tables.Count > 0)
            {
                UserGridView.DataSource = ds.Tables[0];
            }
        }

        protected void UserGridView_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            
        }

        protected void UserGridView_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {

        }
    }
}
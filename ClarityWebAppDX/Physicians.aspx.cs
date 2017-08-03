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
    public partial class PhysicianManagement : System.Web.UI.Page
    {
        CryptoProvider securityAgent = null;
        DataAccessProvider DBAgent = null;
        DataTable dPhysician = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            PhysicianGridView.ForceDataRowType(typeof(ClarityDBSet.PhysicianDSRow));
            if(!IsPostBack && !IsCallback)
            {
                PhysicianGridView.DataBind();
            }
        }

        protected void PhysicianGridView_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamPhysicianID", e.Keys[0]);
                DBAgent.AddParameter("@ParamUpdatedBy", Session["LoginID"]);
                DBAgent.ExecuteNonQuery("dbo.spDeletePhysician");
                e.Cancel = true;
                PhysicianGridView.DataBind();
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("PhysicianGridView_RowDeleting: Physician.aspx", ex.Message);
            }
        }

        protected void PhysicianGridView_DataBinding(object sender, EventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                string data = DBAgent.ExecuteStoredProcedure("dbo.spGetAllPhysicians");
                DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                if (ds.Tables.Count > 0)
                {
                    PhysicianGridView.DataSource = ds.Tables[0];
                }
                else
                {
                    dPhysician = new ClarityDBSet.PhysicianDSDataTable();
                    PhysicianGridView.DataSource = dPhysician;
                }
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("PhysicianGridView_DataBinding: Physician.aspx", ex.Message);
            }
    }

        protected void PhysicianGridView_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamFirstName", e.NewValues["PhysicianFirstName"]);
                DBAgent.AddParameter("@ParamLastName", e.NewValues["PhysicianLastName"]);
                DBAgent.AddParameter("@ParamModifiedBy", Session["LoginID"]);
                DBAgent.ExecuteNonQuery("dbo.spAddPhysician");
                e.Cancel = true;
                PhysicianGridView.CancelEdit();
                PhysicianGridView.DataBind();
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("PhysicianGridView_RowInserting: Physician.aspx", ex.Message);
            }
        }

        protected void PhysicianGridView_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e)
        {
            e.Editor.ReadOnly = false;
        }
    }
}
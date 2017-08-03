using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clarity.DataAccess;
using System.Configuration;
using System.Data;
using DevExpress.Web;

namespace ClarityWebAppDX
{
    public partial class PatientList : System.Web.UI.Page
    {
        DataAccessProvider DBAgent = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PatientListGridView.ForceDataRowType(typeof(ClarityDBSet.PatientDSRow));
                gvAssignedQuestionnaire.ForceDataRowType(typeof(ClarityDBSet.PatientAssignedQuestionnaireRow));
                if (!IsPostBack && !IsCallback)
                {
                    PatientListGridView.DataBind();
                }
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("Page_Load: PatientList.aspx", ex.Message);
            }
        }

        protected void PatientListGridView_DataBinding(object sender, EventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                string data = DBAgent.ExecuteStoredProcedure("dbo.spGetAllPatients");
                if(!String.IsNullOrEmpty(data))
                {
                    DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                    if(ds.Tables.Count > 0)
                    {
                        PatientListGridView.DataSource = ds.Tables[0];
                    }
                }
                GetPhysicianList();
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("PatientListGridView_DataBinding: PatientList.aspx", ex.Message);
            }
        }

        private void GetPhysicianList()
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.ClearParams();
                DBAgent.AddParameter("@ParamShowDeleted", 1);
                string data = DBAgent.ExecuteStoredProcedure("dbo.spGetallPhysicians");
                if (!String.IsNullOrEmpty(data))
                {
                    DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                    if (ds.Tables.Count > 0)
                    {
                        Session["PhysicianDS"] = ds.Tables[0];
                    }
                }
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("GetPhysicianList: PatientList.aspx", ex.Message);
            }
        }
        protected void PatientListGridView_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e)
        {
            try
            {
                e.Editor.ReadOnly = false;
                if (e.Column.Name == "colPrimaryPhysician")
                {
                    ASPxComboBox cmb = e.Editor as ASPxComboBox;
                    if (Session["PhysicianDS"] != null)
                    {
                        cmb.DataSource = Session["PhysicianDS"];
                        cmb.DataBindItems();
                    }
                    else
                    {
                        GetPhysicianList();
                        cmb.DataSource = Session["PhysicianDS"];
                        cmb.DataBindItems();
                    }
                }
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("PatientListGridView_CellEditorInitialize: PatientList.aspx", ex.Message);
            }
        }

        protected void PatientListGridView_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamPatientID", 0);
                DBAgent.AddParameter("@ParamFirstName", e.NewValues["PatientFirstName"]);
                DBAgent.AddParameter("@ParamLastName", e.NewValues["PatientLastName"]);
                DBAgent.AddParameter("@ParamAccount", e.NewValues["PatientAccountNumber"]);
                DBAgent.AddParameter("@ParamDOB", e.NewValues["PatientDOB"]);
                DBAgent.AddParameter("@ParamPrimaryPhysicianID", e.NewValues["PhysicianName"]);
                DBAgent.AddParameter("@ParamLoginID", Session["LoginID"]);
                DBAgent.ExecuteNonQuery("spAddEditPatient");
                e.Cancel = true;
                PatientListGridView.CancelEdit();
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("PatientListGridView_RowInserting: PatientList.aspx", ex.Message);
            }
        }

        protected void PatientListGridView_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamPatientID", e.Keys["PatientID"]);
                DBAgent.AddParameter("@ParamFirstName", e.NewValues["PatientFirstName"]);
                DBAgent.AddParameter("@ParamLastName", e.NewValues["PatientLastName"]);
                DBAgent.AddParameter("@ParamAccount", e.NewValues["PatientAccountNumber"]);
                DBAgent.AddParameter("@ParamDOB", e.NewValues["PatientDOB"]);
                if(e.NewValues["PhysicianName"].ToString() != e.OldValues["PhysicianName"].ToString())
                {
                    DBAgent.AddParameter("@ParamPrimaryPhysicianID", e.NewValues["PhysicianName"]);
                }
                DBAgent.AddParameter("@ParamLoginID", Session["LoginID"]);
                DBAgent.ExecuteNonQuery("spAddEditPatient");
                e.Cancel = true;
                PatientListGridView.CancelEdit();
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("PatientListGridView_RowUpdating: PatientList.aspx", ex.Message);
            }
        }

        protected void PatientDetailsPanel_Callback(object sender, CallbackEventArgsBase e)
        {
            try
            {
                gvAssignedQuestionnaire.Enabled = true;
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamPatientID", e.Parameter);
                string data = DBAgent.ExecuteStoredProcedure("dbo.spGetPatientDetails");
                if (!String.IsNullOrEmpty(data))
                {
                    DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                    if (ds.Tables.Count > 0)
                    {
                        txtPatientAccount.Text = ds.Tables[0].Rows[0]["PatientAccountNumber"].ToString();
                        txtPatientName.Text = ds.Tables[0].Rows[0]["PatientFullName"].ToString();
                        Session["CurrentPatientID"] = e.Parameter;
                        gvAssignedQuestionnaire.DataBind();
                        gvQuestionnaireHistory.DataBind();
                    }
                }
                
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("PatientDetailsPanel_Callback: PatientList.aspx", ex.Message);
            }
        }

        protected void gvQuestionnaireHistory_DataBinding(object sender, EventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamPatientID", Session["CurrentPatientID"]);
                DBAgent.AddParameter("@ParamHistoryList", 1);
                string data = DBAgent.ExecuteStoredProcedure("dbo.spGetPatientQuestionnaireList");
                if (!String.IsNullOrEmpty(data))
                {
                    DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                    if (ds.Tables.Count > 0)
                    {
                        gvQuestionnaireHistory.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("gvQuestionnaireHistory_DataBinding: PatientList.aspx", ex.Message);
            }
        }

        protected void gvAssignedQuestionnaire_DataBinding(object sender, EventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamPatientID", Session["CurrentPatientID"]);
                string data = DBAgent.ExecuteStoredProcedure("dbo.spGetPatientQuestionnaireList");
                if (!String.IsNullOrEmpty(data))
                {
                    DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                    if (ds.Tables.Count > 0)
                    {
                        gvAssignedQuestionnaire.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        
                    }
                    GetQuestionnaireList();
                }
                
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("gvAssignedQuestionnaire_DataBinding: PatientList.aspx", ex.Message);
            }
        }

        protected void GetQuestionnaireList()
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.ClearParams();
                DBAgent.AddParameter("@ParamShowDeleted", 1);
                string data = DBAgent.ExecuteStoredProcedure("dbo.spGetQuestionnaierList");
                if (!String.IsNullOrEmpty(data))
                {
                    DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                    if (ds.Tables.Count > 0)
                    {
                        Session["QuestionnaireDS"] = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("GetQuestionnaireList: PatientList.aspx", ex.Message);
            }
        }

        protected void gvAssignedQuestionnaire_CellEditorInitialize(object sender, ASPxGridViewEditorEventArgs e)
        {
            try
            {
                e.Editor.ReadOnly = false;
                if (e.Column.Name == "colQuestionnaireName")
                {
                    ASPxComboBox cmb = e.Editor as ASPxComboBox;
                    if (Session["QuestionnaireDS"] != null)
                    {
                        cmb.DataSource = Session["QuestionnaireDS"];
                        cmb.DataBindItems();
                    }
                    else
                    {
                        GetQuestionnaireList();
                        cmb.DataSource = Session["QuestionnaireDS"];
                        cmb.DataBindItems();
                    }
                }
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("gvAssignedQuestionnaire_CellEditorInitialize: PatientList.aspx", ex.Message);
            }

        }

        protected void gvAssignedQuestionnaire_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamPatientID", Session["CurrentPatientID"]);
                DBAgent.AddParameter("@ParamQuestionnaireID", 0);
                DBAgent.AddParameter("@ParamNewQuestionnaireID", e.NewValues["QuestionnaireName"]);
                DBAgent.AddParameter("@ParamNewAssignedDate", e.NewValues["ScheduledDate"]);
                DBAgent.AddParameter("@ParamAssignedBy", Session["LoginID"]);
                DBAgent.ExecuteNonQuery("dbo.spAddEditPatientQuestionnaire");
                e.Cancel = true;
                gvAssignedQuestionnaire.CancelEdit();
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("gvAssignedQuestionnaire_RowInserting: PatientList.aspx", ex.Message);
            }
        }

        protected void gvAssignedQuestionnaire_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamPQID", e.Keys["PQID"]);
                DBAgent.AddParameter("@ParamLoginID", Session["LoginID"]);
                DBAgent.ExecuteNonQuery("dbo.spDeletePatientQuestionnaire");
                e.Cancel = true;
                gvAssignedQuestionnaire.CancelEdit();
                gvAssignedQuestionnaire.DataBind();
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("gvAssignedQuestionnaire_RowDeleting: PatientList.aspx", ex.Message);
            }
        }

        protected void gvQuestionnaireHistory_HtmlRowPrepared(object sender, ASPxGridViewTableRowEventArgs e)
        {
            if(e != null && e.GetValue("RiskCategory") != null)
            {
                if(e.GetValue("RiskCategory").ToString().Equals("High"))
                {
                    e.Row.BackColor = System.Drawing.Color.FromArgb(255,158,128);
                }
                else if (e.GetValue("RiskCategory").ToString().Equals("Medium"))
                {
                    e.Row.BackColor = System.Drawing.Color.FromArgb(255, 255, 141);
                }
                else if (e.GetValue("RiskCategory").ToString().Equals("Low"))
                {
                    e.Row.BackColor = System.Drawing.Color.FromArgb(204, 255, 144);
                }
            }
        }
    }
}
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
using DevExpress.Web;

namespace ClarityWebAppDX
{
    public partial class EditQuestionnairePage : System.Web.UI.Page
    {
        CryptoProvider securityAgent = null;
        DataAccessProvider DBAgent = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(!IsPostBack && !IsCallback)
                {
                    int QuestionnaireID = 0;
                    securityAgent = new CryptoProvider();
                    if(Request.QueryString.Count > 0 )
                    {
                        QuestionnaireID = int.Parse(securityAgent.decryptText(Request.QueryString["QID"].Replace(' ', '+')));
                        //QuestionnaireID = int.Parse(Request.QueryString["QID"]);
                        ViewState["CurrentQuestionnaire"] = QuestionnaireID;
                        
                    }

                    LoadQuestionnaireList();
                    AnswerListGridView.DataBind();
                    
                    if(QuestionnaireID > 0 )
                    {
                        ConfigGridView.DataBind();
                        QuestionsGridView.DataBind();
                    }
                }
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("Page_Load: EditQuestionnaire.aspx", ex.Message);
            }
        }

        private void LoadQuestionnaireList()
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                string data = DBAgent.ExecuteStoredProcedure("dbo.spGetQuestionnaierList");
                DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                if (ds.Tables.Count > 0)
                {
                    cmbQuestionnaireList.DataSource = ds.Tables[0];
                    cmbQuestionnaireList.TextField = "QuestionnaireName";
                    cmbQuestionnaireList.ValueField = "QuestionnaireID";
                    cmbQuestionnaireList.DataBind();
                }
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("LoadQuestionList: EditQuestionnaire.aspx", ex.Message);
            }
        }

        protected void cmbQuestionnaireList_DataBound(object sender, EventArgs e)
        {
            cmbQuestionnaireList.Value = ViewState["CurrentQuestionnaire"];
        }

        protected void ConfigGridView_CustomCallback(object sender, DevExpress.Web.ASPxGridViewCustomCallbackEventArgs e)
        {
            ListEditItem listItem = cmbQuestionnaireList.SelectedItem;
            txtQuestionnaireName.Text = listItem.Text;
            RefreshForm();
            ConfigGridView.DataBind();
            QuestionsGridView.DataBind();
        }

        protected void ConfigGridView_DataBinding(object sender, EventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                ListEditItem listItem = cmbQuestionnaireList.SelectedItem;
                DBAgent.AddParameter("@ParamQuestionnaireID", listItem.Value);
                string data = DBAgent.ExecuteStoredProcedure("dbo.spGetQuestionnaireConfig");
                DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                if (ds.Tables.Count > 0)
                {
                    ConfigGridView.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("ConfigGridView_DataBinding: EditQuestionnaire.aspx", ex.Message);
            }
        }

        protected void ConfigGridView_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            try
            {
                e.Cancel = true;
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamQuestionnaireID", cmbQuestionnaireList.SelectedItem.Value);
                DBAgent.AddParameter("@ParamConfigID", e.Keys[0]);
                DBAgent.AddParameter("@ParamConfigValue", e.NewValues[1]);
                DBAgent.ExecuteNonQuery("dbo.spEditQuestionnaireConfig");
                ConfigGridView.CancelEdit();
                ConfigGridView.DataBind();
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("ConfigGridView_RowUpdating: EditQuestionnaire.aspx", ex.Message);
            }
            
        }

        protected void cmbQuestionnaireList_Callback(object sender, CallbackEventArgsBase e)
        {

        }

        protected void AnswerListGridView_DataBinding(object sender, EventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                string data = DBAgent.ExecuteStoredProcedure("dbo.spGetAllAnswers");
                DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                if (ds.Tables.Count > 0)
                {
                    AnswerListGridView.DataSource = ds.Tables[0];
                }
                else
                {
                    AnswerListGridView.ForceDataRowType(typeof(AnswerListClass));
                }
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("AnswerListGridView_DataBinding: EditQuestionnaire.aspx", ex.Message);
            }
            
        }

        protected void AnswerListGridView_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            try
            {
                e.Cancel = true;
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamAnswerText", e.NewValues[0]);
                object o = DBAgent.ExecuteScalar("dbo.spAddAnswer");
                if (o != null)
                {
                    ViewState["NewAnswerID"] = o;
                }
                AnswerListGridView.CancelEdit();
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("AnswerListGridView_RowInserting: EditQuestionnaire.aspx", ex.Message);
            }
        }

        protected void AnswerListGridView_RowInserted(object sender, DevExpress.Web.Data.ASPxDataInsertedEventArgs e)
        {
            AnswerListGridView.DataBind();
        }

        protected void cmdSaveQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                int QuestionID = 0;
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamQuestionText", txtQuestion.Text);
                object o = DBAgent.ExecuteScalar("dbo.spAddQuestion");
                if (o != null)
                {
                    QuestionID = int.Parse(o.ToString());
                    if (QuestionID > 0)
                    {
                        int AnswerSortOrder = 1;
                        foreach (ListEditItem li in lbSelectedAnswers.Items)
                        {
                            DBAgent.ClearParams();
                            DBAgent.AddParameter("@ParamQuestionID", QuestionID);
                            DBAgent.AddParameter("@ParamAnswerID", li.Value);
                            DBAgent.AddParameter("@ParamAnswerSortOrder", AnswerSortOrder);
                            DBAgent.ExecuteNonQuery("dbo.spAddQuestionAnswerMapping");
                            AnswerSortOrder++;
                        }

                        DBAgent.ClearParams();
                        DBAgent.AddParameter("@ParamQuestionnaireID", cmbQuestionnaireList.SelectedItem.Value);
                        DBAgent.AddParameter("@ParamQuestionID", QuestionID);
                        DBAgent.ExecuteNonQuery("dbo.spAddQuestionnaireQuestionMapping");
                        QuestionsGridView.DataBind();
                        RefreshForm();
                    }
                }

                QuestionsGridView.DataBind();
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("cmdSaveQuestion_Click: EditQuestionnaire.aspx", ex.Message);
            }
        }

        private void RefreshForm()
        {
            lbSelectedAnswers.Items.Clear();
            AnswerListGridView.Selection.UnselectAll();
            txtQuestion.Text = "";
        }

        protected void QuestionsGridView_DataBinding(object sender, EventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamQuestionnaireID",cmbQuestionnaireList.SelectedItem.Value);
                string data = DBAgent.ExecuteStoredProcedure("dbo.spGetAllQuestionsForQuestionnaire");
                DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                if (ds.Tables.Count > 0)
                {
                    QuestionsGridView.DataSource = ds.Tables[0];
                }
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("QuestionsGridView_DataBinding: EditQuestionnaire.aspx", ex.Message);
            }
        }

        protected void cmbQuestionnaireList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListEditItem listItem = cmbQuestionnaireList.SelectedItem;
            txtQuestionnaireName.Text = listItem.Text;
            RefreshForm();
            ConfigGridView.DataBind();
            QuestionsGridView.DataBind();
        }
    }

    public class AnswerListClass
    {
        public int AnswerID { get; set; }
        public string AnswerText { get; set; }
    }
}
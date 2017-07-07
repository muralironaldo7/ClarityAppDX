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
                        //QuestionnaireID = int.Parse(securityAgent.decryptText(Request.QueryString["QID"].Replace(' ', '+')));
                        QuestionnaireID = int.Parse(Request.QueryString["QID"]);
                        ViewState["CurrentQuestionnaire"] = QuestionnaireID;
                        
                    }
                    LoadQuestionList();
                    ConfigGridView.DataBind();
                }
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("Page_Load: EditQuestionnaire.aspx", ex.Message);
            }
        }

        private void LoadQuestionList()
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                string data = DBAgent.ExecuteStoredProcedure("dbo.spGetLists");
                DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                if (ds.Tables.Count > 0)
                {
                    cmbQuestionnaireList.DataSource = ds.Tables[0];
                    cmbQuestionnaireList.TextField = "QuestionnaireName";
                    cmbQuestionnaireList.ValueField = "QuestionnaireID";
                    cmbQuestionnaireList.DataBind();
                }

                if (ds.Tables.Count > 1)
                {

                }

                if (ds.Tables.Count > 2)
                {

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
            ConfigGridView.DataBind();
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

        }

        protected void ConfigGridView_RowUpdated(object sender, DevExpress.Web.Data.ASPxDataUpdatedEventArgs e)
        {

        }

        protected void cmbQuestionnaireList_Callback(object sender, CallbackEventArgsBase e)
        {

        }
    }
}
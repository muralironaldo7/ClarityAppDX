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
    public partial class ViewQuestionnaire : System.Web.UI.Page
    {
        CryptoProvider securityAgent = null;
        DataAccessProvider DBAgent = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack && !IsCallback)
                {
                    int QuestionnaireID = 0;
                    securityAgent = new CryptoProvider();
                    if (Request.QueryString.Count > 0)
                    {
                        //QuestionnaireID = int.Parse(securityAgent.decryptText(Request.QueryString["QID"].Replace(' ', '+')));
                        QuestionnaireID = int.Parse(Request.QueryString["QID"]);
                        ViewState["CurrentQuestionnaire"] = QuestionnaireID;

                    }

                    LoadQuestionnaireList();

                }
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("Page_Load: ViewQuestionnaire.aspx", ex.Message);
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
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("LoadQuestionList: ViewQuestionnaire.aspx", ex.Message);
            }
        }

        protected void cmbQuestionnaireList_DataBound(object sender, EventArgs e)
        {

        }

        protected void cmbQuestionnaireList_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuestionsGridView.DataBind();
        }

        protected void QuestionsGridView_DataBinding(object sender, EventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamQuestionnaireID", cmbQuestionnaireList.SelectedItem.Value);
                string data = DBAgent.ExecuteStoredProcedure("dbo.spGetAllQuestionsForQuestionnaire");
                DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                if (ds.Tables.Count > 0)
                {
                    QuestionsGridView.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("QuestionsGridView_DataBinding: ViewQuestionnaire.aspx", ex.Message);
            }
        }

        protected void AnswersGridView_Init(object sender, EventArgs e)
        {
            ASPxGridView childGrid = sender as ASPxGridView;
            object key = childGrid.GetMasterRowKeyValue();

            DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
            DBAgent.AddParameter("@ParamQID", key);
            string data = DBAgent.ExecuteStoredProcedure("dbo.spGetQuestionDetails");
            DataSet ds = CommonHelpers.GetDataSetFromXml(data);
            if (ds.Tables.Count > 0)
            {
                childGrid.DataSource = ds.Tables[0];
            }
        }
    }
}
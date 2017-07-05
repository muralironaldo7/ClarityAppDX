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
                    securityAgent = new CryptoProvider();
                    if(Request.QueryString.Count > 0 )
                    {
                        //int QuestionnaireID = int.Parse(securityAgent.decryptText(Request.QueryString["QID"]).Replace(' ', '+'));
                        int QuestionnaireID = int.Parse(Request.QueryString["QID"]);
                        ViewState["CurrentQuestionnaire"] = QuestionnaireID;
                        
                    }
                    LoadQuestionList();
                }
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("Page_Load: EditQuestionnaire.aspx", ex.Message);
            }
        }

        private void LoadQuestionList()
        {
            DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
            string data = DBAgent.ExecuteStoredProcedure("dbo.spGetLists");
            DataSet ds = CommonHelpers.GetDataSetFromXml(data);
            if(ds.Tables.Count > 0 )
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

        protected void cmbQuestionnaireList_DataBound(object sender, EventArgs e)
        {
            cmbQuestionnaireList.Value = ViewState["CurrentQuestionnaire"];
        }
    }
}
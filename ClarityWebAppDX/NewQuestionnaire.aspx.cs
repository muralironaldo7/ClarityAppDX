using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clarity.DataAccess;
using Clarity.CryptoProvider;
using System.Configuration;
using System.Data;
using System.ComponentModel;
using System.Text;

namespace ClarityWebAppDX
{
    public partial class NewQuestionnaire : System.Web.UI.Page
    {
        DataAccessProvider DBAgent = null;
        BindingList<Record> listDataSource = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack && !IsCallback)
                {
                    cmbRiskType.DataBind();
                    listDataSource = new BindingList<Record>();
                    Session["ConfigurationValues"] = null;
                }
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("Page_Load: NewQuestionnaire.aspx", ex.Message);
            }
            
        }

        protected void cmbRiskType_DataBinding(object sender, EventArgs e)
        {
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                ConfigDataSource.DataSourceMode = SqlDataSourceMode.DataSet;
                ConfigDataSource.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
                ConfigDataSource.SelectCommand = "dbo.spGetAllConfigTypes";
                ConfigDataSource.ConnectionString = DBAgent.GetConnectionString();
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("cmbRiskType_DataBinding: NewQuestionnaire.aspx", ex.Message);
            }
            
        }

        protected void gvConfig_DataBinding(object sender, EventArgs e)
        {
            try
            {
                gvConfig.DataSource = Session["ConfigurationValues"];
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("gvConfig_DataBinding: NewQuestionnaire.aspx", ex.Message);
            }

        }

        protected void gvConfig_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            try
            {
                listDataSource = (BindingList<Record>)Session["ConfigurationValues"];
                foreach (Record r in listDataSource)
                {
                    if (r.ConfigName.ToLower().Equals(e.Keys["ConfigName"].ToString().ToLower()))
                    {
                        listDataSource.Remove(r);
                        break;
                    }
                }
                Session["ConfigurationValues"] = listDataSource;
                e.Cancel = true;
            }
            catch(Exception ex)
            {
                lblErr.Text = "There was a problem processing your request. Please contact IT.";
                lblErr.Visible = true;
                CommonHelpers.writeLogToFile("gvConfig_RowDeleting: NewQuestionnaire.aspx", ex.Message);
            }
            
        }

        protected void gvConfig_RowDeleted(object sender, DevExpress.Web.Data.ASPxDataDeletedEventArgs e)
        {
            try
            {
                gvConfig.DataBind();
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("gvConfig_RowDeleted: NewQuestionnaire.aspx", ex.Message);
            }
        }

        protected void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                CryptoProvider securityAgent = new CryptoProvider();
                int QuestionnaireID = 0;
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("ParamQuestionnaireName", txtQuestionnaireName.Value);
                object o = DBAgent.ExecuteScalar("spAddEditQuestionnaire", ConfigurationManager.AppSettings["DBName"]);
                if (o != null)
                {
                    QuestionnaireID = int.Parse(o.ToString());
                }

                listDataSource = (BindingList<Record>)Session["ConfigurationValues"];

                if (QuestionnaireID > 0)
                {
                    foreach (Record r in listDataSource)
                    {
                        DBAgent.AddParameter("ParamQuestionnaireID", QuestionnaireID);
                        DBAgent.AddParameter("ParamConfigID", r.ConfigID);
                        DBAgent.AddParameter("ParamMinValue", r.MinValue);
                        DBAgent.AddParameter("ParamMaxValue", r.MaxValue);
                        DBAgent.ExecuteNonQuery("spAddQuestionnaireConfig", ConfigurationManager.AppSettings["DBName"]);
                    }

                    Session["ConfigurationValues"] = null;
                    Response.Redirect("EditQuestionnaire.aspx?QID=" + securityAgent.EncryptText(QuestionnaireID.ToString()));
                }
            }
            catch(Exception ex)
            {
                lblErr.Text = "There was a problem processing your request. Please contact IT.";
                lblErr.Visible = true;
                CommonHelpers.writeLogToFile("cmdSave_Click: NewQuestionnaire.aspx", ex.Message);
            }
        }

        protected void gvConfig_CustomCallback(object sender, DevExpress.Web.ASPxGridViewCustomCallbackEventArgs e)
        {
            try
            {
                if (Session["ConfigurationValues"] != null)
                {
                    listDataSource = (BindingList<Record>)Session["ConfigurationValues"];
                }
                else
                {
                    listDataSource = new BindingList<Record>();
                }
                Record newRecord = new Record(cmbRiskType.Text, int.Parse(cmbRiskType.Value.ToString()), int.Parse(txtMinValue.Text), int.Parse(txtMaxValue.Text));
                bool ConfigType = false;
                foreach (Record r in listDataSource)
                {
                    if (r.ConfigName.ToLower().Equals(cmbRiskType.Text.ToLower()))
                    {
                        ConfigType = true;
                        break;
                    }
                }

                if (!ConfigType)
                {
                    listDataSource.Add(newRecord);
                    Session["ConfigurationValues"] = listDataSource;
                }

                cmbRiskType.SelectedIndex = -1;
                cmbRiskType.Value = null;
                txtMinValue.Value = "";
                txtMaxValue.Value = "";
                txtMinValue.Text = "";
                txtMaxValue.Text = "";
                gvConfig.DataBind();
            }
            catch (Exception ex)
            {
                CommonHelpers.writeLogToFile("gvConfig_CustomCallback: NewQuestionnaire.aspx", ex.Message);
            }
        }
    }

    [Serializable]
    public class Record
    {
        int TypeID;
        string configName;
        int minValue;
        int maxValue;
        public Record(string name, int id, int minVal, int maxVal)
        {
            this.TypeID = id;
            this.configName = name;
            this.minValue = minVal;
            this.maxValue = maxVal;
        }

        public string ConfigName
        {
            get { return configName; }
            set { configName = value; }
        }
        
        public int ConfigID
        {
            get { return TypeID; }
            set { TypeID = value; }
        }

        public int MinValue
        {
            get { return minValue; }
            set { minValue = value; }
        }

        public int MaxValue
        {
            get { return maxValue; }
            set { maxValue = value; }
        }

    }
}
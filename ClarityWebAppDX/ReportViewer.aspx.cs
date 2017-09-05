using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clarity.CryptoProvider;

namespace ClarityWebAppDX
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        CryptoProvider securityAgent = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(Request.QueryString["Type"]!= null)
                {
                    switch (Request.QueryString["Type"])
                    {
                        case "QuestionnaireResponse":
                            if(Request.QueryString["PQID"] != null)
                            {
                                QuestionnaireResponse report = new QuestionnaireResponse();
                                securityAgent = new CryptoProvider();
                                report.Parameters["PQID"].Value = securityAgent.decryptText(Request.QueryString["PQID"].Replace(" ", "+"));
                                ReportViewerControl.Report = report;
                            }
                            break;
                        case "PatientReport":
                            if (Request.QueryString["PatientID"] != null)
                            {
                                ConsolidatedReport report = new ConsolidatedReport();
                                securityAgent = new CryptoProvider();
                                report.Parameters["@PatientID"].Value = securityAgent.decryptText(Request.QueryString["PatientID"].Replace(" ", "+"));
                                ReportViewerControl.Report = report;
                            }
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                CommonHelpers.writeLogToFile("Page_Load: ReportViewer.aspx", ex.Message);
            }
        }
    }
}


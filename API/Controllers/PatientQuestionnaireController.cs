using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using Clarity.DataAccess;
using Clarity.CryptoProvider;
using System.Xml;
using System.Configuration;
using System.Collections;
using API.Models;



namespace API.Controllers
{
    public class PatientQuestionnaireController : ApiController
    {
        public DataAccessProvider DBAgent = null;
        public CryptoProvider securityAgent = null;

        public IHttpActionResult PostPatientQuestionnaire([FromBody]PatientQuestionnaireRequest request)
        {
            PatientQuestionnaireResponse response = new PatientQuestionnaireResponse();
            try
            {
                if(CommonHelpers.ValidateRequest(request.UserToken))
                {
                    List<QuestionnaireDetails> QuestionnaireList = new List<QuestionnaireDetails>();
                    //Assigned Questionnaires
                    DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                    DBAgent.ClearParams();
                    DBAgent.AddParameter("@ParamPatientID", request.PatientID);
                    DBAgent.AddParameter("@ParamHistoryList", 0);
                    string data = DBAgent.ExecuteStoredProcedure("dbo.spGetPatientQuestionnaireList");
                    if (data.Length > 0)
                    {
                        DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                        if (ds.Tables.Count > 0)
                        {
                            foreach (DataRow dr in ds.Tables[0].Rows)
                            {
                                QuestionnaireDetails qd = new QuestionnaireDetails(dr["QuestionnaireID"].ToString(), dr["QuestionnaireName"].ToString(), dr["ScheduledDate"].ToString(), dr["Score"].ToString(), dr["RiskCategory"].ToString(), dr["PQID"].ToString());
                                QuestionnaireList.Add(qd);
                            }
                        }
                    }

                    //Completed Questionnaires
                    DBAgent.ClearParams();
                    DBAgent.AddParameter("@ParamPatientID", request.PatientID);
                    DBAgent.AddParameter("@ParamHistoryList", 1);
                    data = DBAgent.ExecuteStoredProcedure("dbo.spGetPatientQuestionnaireList");
                    if (data.Length > 0)
                    {
                        DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                        if (ds.Tables.Count > 0)
                        {
                            foreach (DataRow dr in ds.Tables[0].Rows)
                            {
                                QuestionnaireDetails qd = new QuestionnaireDetails(dr["QuestionnaireID"].ToString(), dr["QuestionnaireName"].ToString(), dr["ScheduledDate"].ToString(), dr["Score"].ToString(), dr["RiskCategory"].ToString(), dr["PQID"].ToString());
                                QuestionnaireList.Add(qd);
                            }
                        }
                    }

                    if(QuestionnaireList.Count == 0)
                    {
                        response.ErrorMessage = "No Data";
                    }
                    else
                    {
                        response.QuestionnaireList = QuestionnaireList;
                    }
                }
                else
                {
                    response.ErrorMessage = "Invalid Request";

                    DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                    DBAgent.ClearParams();
                    DBAgent.AddParameter("@ParamRefID", request.PatientID);
                    DBAgent.AddParameter("@ParamRefType", "PatientID");
                    DBAgent.AddParameter("@ParamAction", "IR");
                    DBAgent.AddParameter("@ParamComment", "Invalid Request from Mobile App - PatientQuestionnaire - " + request.UserToken);
                    DBAgent.ExecuteNonQuery("dbo.spAddUserAction");
                }
            }
            catch(Exception ex)
            {
                response.ErrorMessage = ex.StackTrace;
                CommonHelpers.writeLogToFile("API: PostPatientQuestionnaire - PatientQuestionnaireController.cs", ex.Message + Environment.NewLine + ex.StackTrace);
            }

            return Ok(response);
        }
    }
}

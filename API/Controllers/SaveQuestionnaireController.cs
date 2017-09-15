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
    public class SaveQuestionnaireController : ApiController
    {
        public DataAccessProvider DBAgent = null;
        public CryptoProvider securityAgent = null;

        public IHttpActionResult PostSaveQuestionnaire([FromBody]SaveQuestionnaireRequest request)
        {
            SaveQuestionnaireResponse response = new SaveQuestionnaireResponse();
            try
            {
                if(CommonHelpers.ValidateRequest(request.UserToken))
                {
                    DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                    DBAgent.ClearParams();

                    List<QuestionDetail> QuestionAnswerList = request.QuestionAnswerList;

                    int Score = 0;
                    foreach (QuestionDetail Qn in QuestionAnswerList)
                    {
                        DBAgent.ClearParams();
                        DBAgent.AddParameter("@ParamPQID", request.PatientQuestionnaireID);
                        DBAgent.AddParameter("@ParamQuestionID", Qn.QuestionID);

                        int Points = 0;
                        foreach (AnswerDetail An in Qn.QuestionAnswers)
                        {
                            if(An.SelectedAnswer)
                            {
                                Points = An.AnswerPoints;
                                DBAgent.AddParameter("@ParamAnswerID", An.AnswerID);
                                break;
                            }
                        }
                        Score += Points;

                        //Save Answer one by one
                        DBAgent.ExecuteNonQuery("dbo.spAddPatientResponse");
                    }

                    DBAgent.ClearParams();
                    DBAgent.AddParameter("@ParamPQID", request.PatientQuestionnaireID);
                    DBAgent.AddParameter("@ParamStartDate", request.QuestionnaireStartDate);
                    DBAgent.AddParameter("@ParamScore", Score);
                    DBAgent.ExecuteNonQuery("dbo.spUpdatePatientQuestionnare");

                    response.SaveStatus = true;
                }
                else
                {
                    response.ErrorMessage = "Invalid Request";

                    DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                    DBAgent.ClearParams();
                    DBAgent.AddParameter("@ParamRefID", request.PatientQuestionnaireID);
                    DBAgent.AddParameter("@ParamRefType", "PQID");
                    DBAgent.AddParameter("@ParamAction", "IR");
                    DBAgent.AddParameter("@ParamComment", "Invalid Request from Mobile App - SaveQuestionnaire - " + request.UserToken);
                    DBAgent.ExecuteNonQuery("dbo.spAddUserAction");
                }
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.SaveStatus = false;    
                CommonHelpers.writeLogToFile("API: PostSaveQuestionnaire - SaveQuestionnaireController.cs", ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return Ok(response);
        }
    }
}

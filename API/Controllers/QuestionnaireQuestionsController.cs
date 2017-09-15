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
    public class QuestionnaireQuestionsController : ApiController
    {
        public DataAccessProvider DBAgent = null;
        public CryptoProvider securityAgent = null;

        public IHttpActionResult PostQuestionnaireQuestions([FromBody]QuestionnaireQuestionsRequest request)
        {
            QuestionaireQuestionResponse response = new QuestionaireQuestionResponse();
            try
            {
                if (CommonHelpers.ValidateRequest(request.UserToken))
                {
                    List<QuestionDetail> QuestionAnswerList = new List<QuestionDetail>();
                    DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                    DBAgent.ClearParams();
                    DBAgent.AddParameter("@ParamQuestionnaireID", request.QuestionnaireID);
                    DBAgent.AddParameter("@ParamPQID", request.PQID);
                    string data = DBAgent.ExecuteStoredProcedure("dbo.spGetAllQuestionAnswersForQuestionnaire");
                    if (data.Length > 0)
                    {
                        DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                        if (ds.Tables.Count > 0)
                        {
                            int CurrentQuestionID = 0;
                            QuestionDetail qd = null;

                            foreach (DataRow dr in ds.Tables[0].Rows)
                            {
                                if (CurrentQuestionID != int.Parse(dr["QuestionID"].ToString()))
                                {
                                    if (qd != null)
                                    {
                                        //Save Previous Question 
                                        QuestionAnswerList.Add(qd);
                                    }

                                    //New Question
                                    qd = new QuestionDetail();
                                    qd.QuestionText = dr["QuestionText"].ToString();
                                    qd.QuestionID = dr["QuestionID"].ToString();
                                    CurrentQuestionID = int.Parse(dr["QuestionID"].ToString());

                                }

                                AnswerDetail ans = new AnswerDetail();
                                ans.AnswerID = dr["AnswerID"].ToString();
                                ans.AnswerText = dr["AnswerText"].ToString();
                                ans.SelectedAnswer = bool.Parse(dr["SelectedAnswer"].ToString());
                                ans.AnswerPoints = int.Parse(dr["AnswerPoints"].ToString());
                                qd.QuestionAnswers.Add(ans);
                            }

                            QuestionAnswerList.Add(qd); //Adding last Question

                            response.QuestionAnswerList = QuestionAnswerList;
                        }
                    }
                    else
                    {
                        response.ErrorMessage = "No Data";
                    }

                }
                else
                {
                    response.ErrorMessage = "Invalid Request";

                    DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                    DBAgent.ClearParams();
                    DBAgent.AddParameter("@ParamRefID", request.PQID);
                    DBAgent.AddParameter("@ParamRefType", "PQID");
                    DBAgent.AddParameter("@ParamAction", "IR");
                    DBAgent.AddParameter("@ParamComment", "Invalid Request from Mobile App - QuestionnaireQuestionsController - " + request.UserToken);
                    DBAgent.ExecuteNonQuery("dbo.spAddUserAction");
                }
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
                CommonHelpers.writeLogToFile("API: PostQuestionnaireQuestions - QuestionnaireQuestionsController.cs", ex.Message + Environment.NewLine + ex.StackTrace);
            }


            return Ok(response);
        }
    }
}

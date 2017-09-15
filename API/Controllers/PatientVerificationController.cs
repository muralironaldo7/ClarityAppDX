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
    public class PatientVerificationController : ApiController
    {
        public DataAccessProvider DBAgent = null;
        public CryptoProvider securityAgent = null;

        public IHttpActionResult PostPatientVerificaiton([FromBody] PatientVerifiactionRequest request)
        {
            PatientVerificationResponse response = new PatientVerificationResponse();
            try
            {
                if(CommonHelpers.ValidateRequest(request.UserToken))
                {
                    if(!request.LogVerificaiton)
                    {
                        DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                        DBAgent.ClearParams();
                        DBAgent.AddParameter("@ParamPatientID", request.PatientID);
                        string data = DBAgent.ExecuteStoredProcedure("dbo.spGetPatientDetails");
                        if (data.Length > 0)
                        {
                            DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                            if (ds.Tables.Count > 0)
                            {
                                DataRow dr = ds.Tables[0].Rows[0];
                                response.PatientFirstName = dr["PatientFirstName"].ToString();
                                response.PatientLastName = dr["PatientLastName"].ToString();
                                response.DOB = dr["FormattedDOB"].ToString();
                                response.MaskedName = dr["MaskedName"].ToString();
                                response.PhysicianName = dr["PhysicianName"].ToString();
                                response.AccountNumber = dr["PatientAccountNumber"].ToString();
                            }
                            else
                            {
                                response.ErrorMessage = "No Data";
                            }
                        }
                        else
                        {
                            response.ErrorMessage = "No Data";
                        }
                    }
                    else
                    {
                        DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                        DBAgent.ClearParams();
                        DBAgent.AddParameter("@ParamRefID", request.PatientID);
                        DBAgent.AddParameter("@ParamRefType", "PatientInfo");
                        DBAgent.AddParameter("@ParamAction", "VR");
                        DBAgent.AddParameter("@ParamComment", "Patient Verificaiton from Mobile App");
                        DBAgent.ExecuteNonQuery("dbo.spAddUserAction");
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
                    DBAgent.AddParameter("@ParamComment", "Invalid Request from Mobile App - PatientVerification - " + request.UserToken);
                    DBAgent.ExecuteNonQuery("dbo.spAddUserAction");
                }
            }
            catch(Exception ex)
            {
                response.ErrorMessage = ex.Message;
                CommonHelpers.writeLogToFile("API: PostPatientVerificaiton - PatientVerificaitonController.cs", ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return Ok(response);
        }
    }
}

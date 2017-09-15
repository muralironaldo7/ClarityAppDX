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
    public class PatientListController : ApiController
    {
        public DataAccessProvider DBAgent = null;
        public CryptoProvider securityAgent = null;

        public PatientListResponse PostPatientList([FromBody] PatientListRequest request)
        {
            PatientListResponse response = new PatientListResponse();
            try
            {
                if(CommonHelpers.ValidateRequest(request.UserToken))
                {
                    DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                    DBAgent.ClearParams();
                    if(!String.IsNullOrEmpty(request.AccountNumber))
                    {
                        DBAgent.AddParameter("@ParamAccountNumber", request.AccountNumber);
                    }
                    string data = DBAgent.ExecuteStoredProcedure("dbo.spGetPatientListByAccount");
                    if(data.Length > 0)
                    {
                        DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                        if(ds.Tables.Count > 0)
                        {
                            DataTable dTable = ds.Tables[0];
                            //response.PatientListDataTable = dTable;

                            ArrayList PatientList = new ArrayList();
                            List<PatientDetails> PatientDetailsList = new List<PatientDetails>();
                            foreach (DataRow dr in dTable.Rows)
                            {
                                string PatientNameRow = String.Format("{0}, {1} ({2} - {3})", dr["PatientLastName"], dr["PatientFirstName"], dr["PatientAccountNumber"], dr["PatientDOB"]);
                                PatientList.Add(String.Format("{0}, {1} ({2} - {3})", dr["PatientLastName"], dr["PatientFirstName"], dr["PatientAccountNumber"], dr["PatientDOB"]));
                                PatientDetailsList.Add(new PatientDetails(PatientNameRow, dr["PatientID"].ToString()));
                            }

                            response.PatientList = PatientList;
                            response.PatientDetailsList = PatientDetailsList;
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
                    response.ErrorMessage = "Invalid Request";

                    DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                    DBAgent.ClearParams();
                    DBAgent.AddParameter("@ParamRefID", request.LoginID);
                    DBAgent.AddParameter("@ParamRefType", "Users");
                    DBAgent.AddParameter("@ParamAction", "IR");
                    DBAgent.AddParameter("@ParamComment", "Invalid Requestv from Mobile App - PatientListController - " + request.UserToken);
                    DBAgent.ExecuteNonQuery("dbo.spAddUserAction");
                }
            }
            catch(Exception ex)
            {
                response.ErrorMessage = ex.Message;
                CommonHelpers.writeLogToFile("API: PostPatientList - PatientListController.cs", ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return response;
        }
    }
}

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
using API.Models;

namespace API.Controllers
{
    public class StaffLoginController : ApiController
    {
        public DataAccessProvider DBAgent = null;
        public CryptoProvider securityAgent = null;

        public IHttpActionResult PostStaffLogin([FromBody]StaffAuthenticationRequest request)
        {
            StaffAuthenticationResponse response = new StaffAuthenticationResponse();
            try
            {
                DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                DBAgent.AddParameter("@ParamUserName", request.UserName);
                string data = DBAgent.ExecuteStoredProcedure("dbo.spGetUserDetails");

                if (string.IsNullOrEmpty(data))
                {
                    response.ErrorMessage = "Invalid Username/Password conbination. Please try again";
                    response.IsAuthenticated = false;
                    response.LoginID = -1;

                    DBAgent.ClearParams();
                    DBAgent.AddParameter("@ParamRefID", 0);
                    DBAgent.AddParameter("@ParamRefType", "Users");
                    DBAgent.AddParameter("@ParamAction", "FL");
                    DBAgent.AddParameter("@ParamComment", "Login Failed from Mobile App- " + request.UserName);
                    DBAgent.ExecuteNonQuery("dbo.spAddUserAction");

                }
                else
                {
                    DataSet ds = CommonHelpers.GetDataSetFromXml(data);
                    if (ds.Tables.Count > 0)
                    {
                        securityAgent = new CryptoProvider();
                        DataRow dRow = ds.Tables[0].Rows[0];
                        string upassword = securityAgent.decryptText(dRow["Password"].ToString().Replace(" ", "+"));

                        if (upassword.Equals(request.Password))
                        {

                            DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                            DBAgent.ClearParams();
                            DBAgent.AddParameter("@ParamRefID", dRow["LoginID"].ToString());
                            DBAgent.AddParameter("@ParamRefType", "Users");
                            DBAgent.AddParameter("@ParamAction", "LI");
                            DBAgent.AddParameter("@ParamComment", "Successful Login from Mobile App- " + request.UserName);
                            DBAgent.ExecuteNonQuery("dbo.spAddUserAction");

                            response.IsAuthenticated = true;

                            response.UserFirstName = dRow["FirstName"].ToString();
                            response.UserLastName = dRow["LastName"].ToString();
                            response.UserToken = ConfigurationManager.AppSettings["UserToken"];
                        }
                        else
                        {
                            response.IsAuthenticated = false;
                            response.ErrorMessage = "Invalid Username/Password conbination. Please try again";

                            DBAgent = new DataAccessProvider(DataAccessProvider.ParamType.ServerCredentials, ConfigurationManager.AppSettings["DBServerName"], ConfigurationManager.AppSettings["DBUserName"], ConfigurationManager.AppSettings["DBPassword"]);
                            DBAgent.ClearParams();
                            DBAgent.AddParameter("@ParamRefID", 0);
                            DBAgent.AddParameter("@ParamRefType", "Users");
                            DBAgent.AddParameter("@ParamAction", "FL");
                            DBAgent.AddParameter("@ParamComment", "Login Failed from Mobile App- " + request.UserName);
                            DBAgent.ExecuteNonQuery("dbo.spAddUserAction");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.IsAuthenticated = false;
                CommonHelpers.writeLogToFile("API: PostStaffLogin - StaffLoginController.cs", ex.Message + Environment.NewLine + ex.StackTrace);
            }
            return Ok(response);
        }

    }
}

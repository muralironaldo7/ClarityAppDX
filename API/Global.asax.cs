using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Data;
using System.Xml;
using System.IO;
using System.Configuration;

namespace API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }

    public static class CommonHelpers
    {
        public static DataSet GetDataSetFromXml(string sXML)
        {
            DataSet ds = new DataSet();
            try
            {
                XmlTextReader xReader = new XmlTextReader(sXML, XmlNodeType.Document, null);
                ds.ReadXml(xReader);
                return ds;
            }
            catch (Exception ex)
            {
                writeLogToFile("GetDataSetFromXml", ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }

        }

        public static void writeLogToFile(string Modulename, string msg)
        {
            string dPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Exceptions");
            string dMsg = "[" + DateTime.Now.ToString() + "] - " + Modulename + " | " + msg;
            string filename = Path.Combine(dPath, DateTime.Now.Date.ToString("yyyyMMdd") + ".txt");
            StreamWriter oStream = new StreamWriter(filename, true);
            oStream.WriteLine(dMsg);
            oStream.Flush();
            oStream.Close();
        }

        public static bool ValidateRequest(string UserToken)
        {
            if(UserToken.Equals(ConfigurationManager.AppSettings["UserToken"]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

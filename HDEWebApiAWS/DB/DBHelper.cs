using System;
using System.Linq;
using System.Collections.Generic;

namespace HDEWebApiAWS.DB
{
    public class DBHelper
    {
        public static string GetRDSConnectionString()
        {
            //var appConfig =  ConfigurationManager.AppSettings;

            //string dbname = appConfig["RDS_DB_NAME"];

            //if (string.IsNullOrEmpty(dbname)) return null;

            //string username = appConfig["RDS_USERNAME"];
            //string password = appConfig["RDS_PASSWORD"];
            //string hostname = appConfig["RDS_HOSTNAME"];
            //string port     = appConfig["RDS_PORT"];

            return "Data Source=" + "hdebuynowdb.cbbrl88kqfjd.us-east-1.rds.amazonaws.com" + "; Initial Catalog=" + "HDEBuyNow" + ";User ID=" + "hdebuynowadmin" + ";Password=" + "hdebuynow%%01" + ";";
        }
    }
}

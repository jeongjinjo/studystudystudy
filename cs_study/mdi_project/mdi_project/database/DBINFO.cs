using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace mdi_project.database
{
    public class DBINFO
    {
        public static string dbstr="Data Source= (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = xe))); User Id = usertodo; Password=1234;";
        public static OracleConnection conn = null;//싱글톤패턴으로 수정함.
        public static OracleConnection openConnect()
        {
            if (conn == null)
            {
                conn = new OracleConnection(dbstr);
                conn.Open();
            }
            else
            {
                conn.Open();
            }
           
            return conn;
        }
        public static void closeConnect()
        {
            if(conn!=null)
            {
                conn.Close();
                conn.Dispose();
                conn=null;
            }
        }

    }
}

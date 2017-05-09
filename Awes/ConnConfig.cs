using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Awes
{
    public class ConnectConfig
    {
        public static string DBConn { get { return "Data Source=KUN;Initial Catalog=Awesome;Persist Security Info=True;User ID=sa;Password=sa"; } }
        public static string Test { get { return "Data Source=KUN;Initial Catalog=Test;Persist Security Info=True;User ID=sa;Password=sa"; } }

        public static SqlConnection GetConnsection
        {
            get
            {
                SqlConnection conn = new SqlConnection(DBConn);
                conn.Open();
                return conn;
            }
        }
    }
}

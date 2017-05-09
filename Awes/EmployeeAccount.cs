using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Awes
{
    public class EmployeeAccount
    {
        public Guid EmployeeID { get; private set; }
        public string Account { get; private set; }
        public string Password { get; private set; }
        public DateTime LastLogin { get; set; }

        public EmployeeAccount(Guid empID)
        {
            this.EmployeeID = empID;
        }
        public bool Login(string acc,string pwd)
        {
            string sql = $"select * from EmployeeAccount where Account = '{acc}' and Password = '{pwd}'";
            using (SqlConnection conn = ConnectConfig.GetConnsection)
            {
                SqlCommand sqc = new SqlCommand(sql, conn);
                using(SqlDataReader sdr = sqc.ExecuteReader())
                {
                    if (!sdr.HasRows) return false;
                    if (sdr.FieldCount == 1) return true;
                    return false;
                }
            }                        
        }
    }
}

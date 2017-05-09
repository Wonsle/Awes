using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace Awes
{
    public class Employees
    {
        #region field
        public Guid EmployeeID { get; private set; }
        public string FirtstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public Post PostLevel { get; private set; } = Post.New_Register;
        public int Sex { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public DateTime RegistTime { get; private set; }
        public DateTime LeaveTime { get; set; }
        #endregion

        public bool? Register(string fn, string ln,string twid,
            int sex, DateTime birthday, string nn = "", string mail = ""
            )
        {           
            if (fn.Length > 20) return false;
            if (ln.Length > 20) return false;
            if (ln.Length > 10) return false;
            if (nn.Length > 10) return false;
            if (mail.Length > 20) return false;
            bool? isSuc = null;
            SqlConnection conn = ConnectConfig.GetConnsection;
            SqlCommand sqc = new SqlCommand();
            sqc.Connection = conn;
            sqc.CommandText = $@"insert into EmployeesInfo values('{Guid.NewGuid()}', '{fn}', '{ln}', '{nn}', {(int)Post.New_Register}, '{twid}', {sex}, '{mail}',
'{birthday.ToString("yyyy-MM-dd")}', '{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff")}', null)";
            SqlTransaction tran = conn.BeginTransaction();
            sqc.Transaction = tran;
            try
            {
                sqc.ExecuteNonQuery();
                tran.Commit();
                isSuc = true;
            }
            catch
            {
                tran.Rollback();
                isSuc = false;
            }
            finally
            {
                using (conn) { }                
            }
            return isSuc;
        }
    }
}

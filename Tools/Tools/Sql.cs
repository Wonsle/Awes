using System.Data.Common;

namespace System.Data
{
    public static class DbCmdExtension
    {
        public static bool IsDBNull(this DbDataReader r, string name) => r.IsDBNull(r.GetOrdinal(name));
        public static string GetString(this DbDataReader r, string name)=> r.GetString(r.GetOrdinal(name));                  

        public static byte GetByte(this DbDataReader r, string name) => r.GetByte(r.GetOrdinal(name));
        
        public static char GetChar(this DbDataReader r, string name) =>r.GetChar(r.GetOrdinal(name));
        
        public static DateTime GetDateTime(this DbDataReader r, string name) => r.GetDateTime(r.GetOrdinal(name));
        
        public static decimal GetDecimal(this DbDataReader r, string name) => r.GetDecimal(r.GetOrdinal(name));
        
        public static double GetDouble(this DbDataReader r, string name) => r.GetDouble(r.GetOrdinal(name));
        
        public static float GetFloat(this DbDataReader r, string name) => r.GetFloat(r.GetOrdinal(name));
        
        public static Guid GetGuid(this DbDataReader r, string name) => r.GetGuid(r.GetOrdinal(name));
        
        public static short GetInt16(this DbDataReader r, string name) => r.GetInt16(r.GetOrdinal(name));
        
        public static int GetInt32(this DbDataReader r, string name) => r.GetInt32(r.GetOrdinal(name));
        
        public static long GetInt64(this DbDataReader r, string name) => r.GetInt64(r.GetOrdinal(name));        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class DbConnection
    {
        private static DbConnection dbConn = null;
        private DbConnection() { }

        public static DbConnection GetDbConn()
        {
            if(dbConn == null)
                dbConn = new DbConnection();
            return dbConn;
        }

        public string ConnectionString { get; set; }
        public void RunQuery(string query)
        {
            //code to execute the sql query
        }
    }
}

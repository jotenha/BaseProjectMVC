using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using BaseProjectMVC.Model_Persistence.DatabaseAdapter;

namespace BaseProjectMVC.Model_Persistence
{
    internal class DatabaseConnection : IDatabaseAdapter
    {
        private static DatabaseConnection DB;
        //For SQLServer Connection - mdf file must be in the root of the executable (usually bin/debug during production)
       /* private String strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + 
            Directory.GetCurrentDirectory() + "\\DBv2.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection con = null;
        private SqlTransaction trans = null;*/

        private DatabaseConnection() {}
        ///<summary>
        ///Singleton instance of Database connection. Creates a new one if null (firt call) or return existing one.
        ///Usage: DatabaseConnection.GetDatabaseConnection()
        ///</summary>
        public static DatabaseConnection GetDatabaseConnection()
        {
            if (DB == null)
            {
                DB = new DatabaseConnection();
            }
            return DB;
        }
        //End of singleton implementation

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public bool Connect()
        {
            throw new NotImplementedException();
        }

        public bool Disconnect()
        {
            throw new NotImplementedException();
        }

        public void QueryRead(string sql, out DataTable dt, params object[] paramsData)
        {
            throw new NotImplementedException();
        }

        public void QueryWrite(string sql, params object[] paramsData)
        {
            throw new NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProjectMVC.Model_Persistence.DatabaseAdapter
{
    interface IDatabaseAdapter
    {
        public bool Connect();
        public bool Disconnect();
        public void BeginTransaction();
        public void CommitTransaction();
        public void RollbackTransaction();

        public void QueryRead(String sql, out DataTable dt, params Object[] paramsData);
        public void QueryWrite(String sql, params Object[] paramsData);
    }
}

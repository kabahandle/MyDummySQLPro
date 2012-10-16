using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MyDummySQL.DAOs
{
    class tableDAO : MyDAOBase
    {
        private string tableName = "";
        public tableDAO(DAOContext con, string tableName_)
            : base(con)
        {
            this.tableName = tableName_;
        }

        //select ID, val
        public DataTable selectAll()
        {
            string sql = @"select * from " + this.tableName;
            this.ClearParameters();
            return base.GetTable(sql);
        }
        //select ID, val
        public DataTable selectTop5()
        {
            string sql = @"select Top 5 * from " + this.tableName;
            this.ClearParameters();
            return base.GetTable(sql);
        }
    }
}

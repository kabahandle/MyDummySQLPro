using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MyDummySQL.MySQLDAO
{
    class myTableDAO : MySQLDAOBase
    {
        private string tableName = "";
        private string columnName = "";
        public myTableDAO(MySQLDAOContext con, string tableName_)
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
    }   
}

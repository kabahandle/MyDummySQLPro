using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MyDummySQL.MySQLDAO
{
    class myTableColDAO : MySQLDAOBase
    {
        private string tableName = "";
        private string columnName = "";
        public myTableColDAO(MySQLDAOContext con, string tableName_, string columnName_)
            : base(con)
        {
            this.tableName = tableName_;
            this.columnName = columnName_;
        }

        //select ID, col
        public DataTable selectAll()
        {
            string col = "*";
            if (!string.IsNullOrEmpty(this.columnName))
            {
                col = this.columnName;
            }
            string sql = @"select " + col + " from " + this.tableName;
            this.ClearParameters();
            return base.GetTable(sql);
        }
        //select ID, col
        public DataTable selectTop5()
        {
            string col = "*";
            if (!string.IsNullOrEmpty(this.columnName))
            {
                col = this.columnName;
            }
            string sql = @"select " + col + " from " + this.tableName + " limit 0,5";
            this.ClearParameters();
            return base.GetTable(sql);
        }
    }   
}

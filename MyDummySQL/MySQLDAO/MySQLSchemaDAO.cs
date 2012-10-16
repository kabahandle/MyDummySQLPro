using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MyDummySQL.MySQLDAO
{
    class MySQLSchemaDAO : MySQLDAOBase
    {
        public MySQLSchemaDAO(MySQLDAOContext con)
            : base(con)
        {
        }

        public DataTable selectTableColumns(string dbname, string tablename)
        {
            string sql = @"
                    select
                         *
                     from
                         information_schema.columns as c
                     where
                         c.table_schema = @pdbname
                         and
                         c.table_name   = @ptablename
                     order by
                         ordinal_position
                    ";
            this.ClearParameters();
            this.AddParameter("pdbname", DbType.String, dbname);
            this.AddParameter("ptablename", DbType.String, tablename);
            return base.GetTable(sql);
        }

        public DataTable selectTables(string dbname)
        {
            string sql = @"
                    select
                         table_name
                    from
                         information_schema.tables as t
                     where
                         t.table_schema = @pdbname
                     order by
                         table_name
                    ";
            this.ClearParameters();
            this.AddParameter("pdbname", DbType.String, dbname);
            return base.GetTable(sql);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.Types;
using System.Data;
namespace MyDummySQL.MySQLDAO
{
    class t_table1Dao : MySQLDAOBase
    {
        public t_table1Dao(MySQLDAOContext con) : base(con) { }

        public DataTable select(int id)
        {
            string sql = @"select *
                            from t_table1
                            where
                                id = @pid";

            this.ClearParameters();
            this.AddParameter("pid", DbType.Int32, id);

            DataTable tbl = base.GetTable(sql);
            return tbl;
        }
        public DataTable selectAll()
        {
            string sql = @"select *
                            from t_table1";

            this.ClearParameters();

            DataTable tbl = base.GetTable(sql);
            return tbl;
        }

        public int insert(string strgName)
        {
            string sql = @"insert into
                            t_table1(
                                name
                            )
                            values(
                                 @pname
                            )";

            this.ClearParameters();
            this.AddParameter("pname", DbType.String, strgName);

            return base.ExecuteNonQuery(sql);
        }

        public int update(int id, string name)
        {
            string sql = @"update t_table1
                            set
                                name = @pname
                            where
                                id = @pid";

            this.ClearParameters();
            this.AddParameter("pname", DbType.String, name);
            this.AddParameter("pid", DbType.Int32, id);

            return base.ExecuteNonQuery(sql);
        }

        public int delete(int id)
        {
            string sql = @"delete from t_table1
                            where
                                id = @pid";

            this.ClearParameters();
            this.AddParameter("pid", DbType.Int32, id);

            return base.ExecuteNonQuery(sql);
        }

    }
}

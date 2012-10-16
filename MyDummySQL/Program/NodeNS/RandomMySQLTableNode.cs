using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDummySQL.MySQLDAO;
using System.Data;
using MyDummySQL.HelperNS;

namespace MyDummySQL.NodeNS
{
    class RandomMySQLTableNode : INode
    {
        private DataTable table = null;
        private string TableName = "";
        private string ColumnName = "";
        private int no = 0;
        private int max = 0;
        private Random objRandom = null;

        public RandomMySQLTableNode(string tableName_, string columnName_)
        {
            this.TableName = tableName_;
            this.ColumnName = columnName_;

            /*
            using (MySQLDAOContext con = new MySQLDAOContext(MySQLConString.getStaticConstring()))
            {
                con.OpenConnection();

                myTableColDAO dao = new myTableColDAO(con, tableName_, columnName_);
                this.table = dao.selectAll();

                con.CloseConnection();
            }

            this.max = this.table.Rows.Count;

            int seed = Environment.TickCount;
            this.objRandom = new Random(seed);
             */
            MySQLTableHelper.AddTable(this.TableName);

        }

        public string NextString()
        {
            string col = "val";
            if( !string.IsNullOrEmpty(this.ColumnName))
            {
                col = this.ColumnName;
            }

            return MySQLTableHelper.getCurrentRndColString(this.TableName, col);

        }
    }
}

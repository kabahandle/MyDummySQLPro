using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDummySQL.MySQLDAO;
using System.Data;
using MyDummySQL.HelperNS;

namespace MyDummySQL.NodeNS
{
    class SeqMySQLTableNode : INode
    {
        private DataTable table = null;
        private string TableName = "";
        private string ColumnName = "";
        private int no = 0;

        public SeqMySQLTableNode(string tableName_, string columnName_)
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
            return MySQLTableHelper.getCurrentSeqColString(this.TableName, col);

        }
    }
}

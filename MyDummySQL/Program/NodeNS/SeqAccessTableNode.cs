using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MyDummySQL.DAOs;

namespace MyDummySQL.NodeNS
{
    class SeqAccessTableNode : INode
    {
        private DataTable table = null;
        private int no = 0;

        public SeqAccessTableNode(string tableName)
        {
            using (DAOContext con = new DAOContext(AccessConstring.conString))
            {
                con.OpenConnection();

                tableDAO dao = new tableDAO(con, tableName);
                this.table = dao.selectAll();

                con.CloseConnection();
            }
        }

        public string NextString()
        {
            string ret = this.table.Rows[this.no]["val"].ToString();
            this.no++;
            if (this.no >= this.table.Rows.Count)
            {
                this.no = 0;
            }

            return ret;
        }
    }
}

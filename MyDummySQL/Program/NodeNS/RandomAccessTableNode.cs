using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MyDummySQL.DAOs;

namespace MyDummySQL.NodeNS
{
    class RandomAccessTableNode : INode
    {
        private DataTable table = null;
        private int no = 0;
        private int max = 0;
        private Random objRandom = null;

        public RandomAccessTableNode(string tableName)
        {
            using (DAOContext con = new DAOContext(AccessConstring.conString))
            {
                con.OpenConnection();

                tableDAO dao = new tableDAO(con, tableName);
                this.table = dao.selectAll();

                con.CloseConnection();
            }

            this.max = this.table.Rows.Count;

            int seed = Environment.TickCount;
            this.objRandom = new Random(seed);
        }

        public string NextString()
        {
            //調整したランダム数値取得
            int idx = this.objRandom.Next(this.max);

            string ret = this.table.Rows[idx]["val"].ToString();

            return ret;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MyDummySQL.HelperNS
{
    class MySQLTableData
    {
        private int CurrentSeqNo = 0;
        private int CurrentRndNo = 0;
        private DataTable table = null;
        private int rowsMax = 0;
        private Random objRandom = null;

        public MySQLTableData(DataTable table_)
        {
            this.table = table_;
            this.rowsMax = table_.Rows.Count;
            this.objRandom = new Random(Environment.TickCount);
        }

        public void SetNext()
        {
            this.CurrentSeqNo++;
            if (this.CurrentSeqNo >= this.rowsMax)
            {
                this.CurrentSeqNo = 0;
            }
            //調整したランダム数値取得
            this.CurrentRndNo = this.objRandom.Next(this.rowsMax-1);
        }

        public string getCurrentSeqColString(string colName)
        {
            return this.table.Rows[this.CurrentSeqNo][colName].ToString();
        }
        public string getCurrentRndColString(string colName)
        {
            return this.table.Rows[this.CurrentRndNo][colName].ToString();
        }
    }
}

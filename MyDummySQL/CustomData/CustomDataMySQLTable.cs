using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDummySQL.CustomData
{
    class CustomDataMySQLTable
    {
        public string ColName { get; set; }
        public string ColType { get; set; }
        public string Val { get; set; }
        public string NullRatio { get; set; }
        public CustomDataMySQLTable(string colName_, string colType_, string val_, string nullRatio_)
        {
            this.ColName = colName_;
            this.ColType = colType_;
            this.Val = val_;
            this.NullRatio = nullRatio_;
        }
    }
}

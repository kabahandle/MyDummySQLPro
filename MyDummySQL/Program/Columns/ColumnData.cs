using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDummySQL.GeneratorNS;

namespace MyDummySQL.Columns
{
    class ColumnData
    {
        //[ColumnName, Generator]の組
        private Dictionary<string, ColumnDataGenerator> aryColumnData = new Dictionary<string, ColumnDataGenerator>();
        //[ColumnName, Param]の組
        private Dictionary<string, string> paramsByColumn = new Dictionary<string, string>();
        //[ColumnName, NullRatio]の組
        private Dictionary<string, string> nullRatioByColumn = new Dictionary<string, string>();

        //ランダムオブジェクト
        private Random objRnd = null;
        
        public ColumnData(Dictionary<string,string> paramsByColumn_, Dictionary<string,string> nullRatioByColumn_)
        {
            this.paramsByColumn = paramsByColumn_;
            this.nullRatioByColumn = nullRatioByColumn_;
            foreach (var key in this.paramsByColumn.Keys)
            {
                this.aryColumnData.Add(key, new ColumnDataGenerator(key,this.paramsByColumn[key]));
            }

            //ランダムシード
            int seed = Environment.TickCount;
            this.objRnd = new Random(seed);

        }

        //[ColumnName, 生成したColumnValue]の組
        public Dictionary<string, string> GenerateNext()
        {
            Dictionary<string, string> generatedValuesByColumn = new Dictionary<string, string>();

            foreach (var key in this.aryColumnData.Keys)
            {
                int nullratio = 0;
                if (this.nullRatioByColumn.Keys.Contains(key))
                {
                    string script = this.nullRatioByColumn[key];
                    if (!string.IsNullOrEmpty(script))
                    {
                        script = script.Replace("|null:", "");
                        int.TryParse(script, out nullratio);
                    }
                    else
                    {
                        nullratio = 0;
                    }
                }

                int thr = this.objRnd.Next(0, 100);
                //スレッショルド（閾値）がNULL挿入率未満ならNULL挿入
                if (thr < nullratio)
                {
                    //Null挿入
                    string columnName = key;
                    string nullValue = "";    //空白がNULLと等価

                    generatedValuesByColumn.Add(columnName, nullValue);
                }
                else
                {
                    //値挿入
                    ColumnDataGenerator g = this.aryColumnData[key];
                    string columnName = key;
                    string columnValue = g.BuildColumnData();

                    generatedValuesByColumn.Add(columnName, columnValue);
                }
            }

            return generatedValuesByColumn;
        }
    }
}

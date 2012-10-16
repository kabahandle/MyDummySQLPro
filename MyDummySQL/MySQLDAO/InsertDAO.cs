using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDummySQL.MySQLDAO
{
    class InsertDAO : MySQLDAOBase
    {
        public InsertDAO(MySQLDAOContext con) : base(con) { }

        public string[] intType = { "int", "smallint", "bigint", "mediumint", "tinyint", "decimal", "float", "double", "real", "bit", "bool", "serial" };

        public void setAutoCommiOff()
        {
            string sql = "SET AUTOCOMMIT=0;";
            base.ExecuteNonQuery(sql);
        }

        public int Insert(string tableName, List<string> colNames, Dictionary<string, string> colTypes, Dictionary<string, string> colValues)
        {
            //cols
            StringBuilder sql1 = new StringBuilder();
            sql1.Append(" ( ");
            for(int i = 0; i < colNames.Count; i++ )
            {
                sql1.Append(colNames[i]);
                if (i + 1 < colNames.Count)
                {
                    sql1.Append(",");
                }
            }
            sql1.Append(" ) ");

            //values
            StringBuilder sql2 = new StringBuilder();
            sql2.Append(" ( ");
            for (int i = 0; i < colNames.Count; i++)
            {
                string type = colTypes[colNames[i]];
                string val = colValues[colNames[i]];

                bool isInt = false;
                foreach (string t in this.intType)
                {
                    if (t.Equals(type))
                    {
                        isInt = true;
                        break;
                    }
                }

                if (string.IsNullOrEmpty(val))
                {
                    sql2.Append("NULL");
                }
                else
                {
                    if (isInt)
                    {
                        sql2.Append(val);
                    }
                    else
                    {
                        sql2.Append("'" + val + "'");
                    }
                }

                if (i + 1 < colNames.Count)
                {
                    sql2.Append(",");
                }
            }
            sql2.Append(" ) ");

            string sql = "insert into " + tableName + " " + sql1.ToString() + " values " + sql2.ToString();

            
            byte[] bytesData = System.Text.Encoding.GetEncoding(932).GetBytes(sql);

            string str = System.Text.Encoding.GetEncoding(932).GetString(bytesData);
            

            return base.ExecuteNonQuery(str);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MyDummySQL.MySQLDAO;

namespace MyDummySQL.HelperNS
{
    class MySQLTableHelper
    {
        //シングルトン
        static private MySQLTableHelper singleton_ = new MySQLTableHelper();
        //プライベートコンストラクタ
        MySQLTableHelper() { }

        //シングルトン取得メソッド
        static public MySQLTableHelper getInstance()
        {
            return MySQLTableHelper.singleton_;
        }

        static private Dictionary<string, MySQLTableData> MySQLTableData = new Dictionary<string, MySQLTableData>();

        static public void AddTable(string tableName)
        {
            if (!MySQLTableHelper.MySQLTableData.Keys.Contains(tableName))
            {
                DataTable newTable = null;
                using (MySQLDAOContext con = new MySQLDAOContext(MySQLConString.getStaticConstring()))
                {
                    con.OpenConnection();

                    myTableDAO dao = new myTableDAO(con, tableName);
                    newTable = dao.selectAll();

                    con.CloseConnection();
                }

                MySQLTableHelper.MySQLTableData.Add(tableName, new MySQLTableData( newTable));

            }
        }

        static public void SetNext()
        {
            foreach (var key in MySQLTableHelper.MySQLTableData.Keys)
            {
                MySQLTableHelper.MySQLTableData[key].SetNext();
            }
        }

        static public string getCurrentSeqColString(string tableName, string colName)
        {
            if (MySQLTableHelper.MySQLTableData.Keys.Contains(tableName))
            {
                return MySQLTableHelper.MySQLTableData[tableName].getCurrentSeqColString(colName);
            }
            else
            {
                return "";
            }
            
        }
        static public string getCurrentRndColString(string tableName, string colName)
        {
            if (MySQLTableHelper.MySQLTableData.Keys.Contains(tableName))
            {
                return MySQLTableHelper.MySQLTableData[tableName].getCurrentRndColString(colName);
            }
            else
            {
                return "";
            }
        }

    }
}

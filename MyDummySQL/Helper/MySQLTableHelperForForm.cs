using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDummySQL.MySQLDAO;
using System.Data;

namespace MyDummySQL.Helper
{
    class MySQLTableHelperForForm
    {
        static private MySQLTableHelperForForm singleton = new MySQLTableHelperForForm();
        MySQLTableHelperForForm() {}

        static public MySQLTableHelperForForm getInstance()
        {
            return MySQLTableHelperForForm.singleton;
        }

        static public IList<string> getTableNames(string dbname)
        {
            List<string> ret = new List<string>();
            DataTable schema = null;

            using (MySQLDAO.MySQLDAOContext con = new MySQLDAO.MySQLDAOContext(MySQLConString.getStaticConstring()))
            {
                con.OpenConnection();

                MySQLSchemaDAO dao = new MySQLSchemaDAO(con);
                schema = dao.selectTables(dbname);

                con.CloseConnection();
            }

            if (schema != null)
            {
                foreach (DataRow row in schema.Rows)
                {
                    ret.Add(row["table_name"].ToString());
                }
            }

            return ret;
        }
        static public IList<string> getTableColumnNames(string dbname, string tableName)
        {
            List<string> ret = new List<string>();
            DataTable schema = null;

            using (MySQLDAO.MySQLDAOContext con = new MySQLDAO.MySQLDAOContext(MySQLConString.getStaticConstring()))
            {
                con.OpenConnection();

                MySQLSchemaDAO dao = new MySQLSchemaDAO(con);
                schema = dao.selectTableColumns(dbname, tableName);

                con.CloseConnection();
            }

            if (schema != null)
            {
                foreach (DataRow row in schema.Rows)
                {
                    ret.Add(row["COLUMN_NAME"].ToString());
                }
            }

            return ret;
        }

        static public IList<string> getTop5TableCol(string tableName, string colName)
        {
            List<string> ret = new List<string>();
            DataTable tbl = null;

            using (MySQLDAOContext con = new MySQLDAOContext(MySQLConString.getStaticConstring()))
            {
                con.OpenConnection();

                myTableColDAO dao = new myTableColDAO(con, tableName, colName);
                tbl = dao.selectTop5();

                con.CloseConnection();
            }

            if (tbl != null)
            {
                foreach (DataRow row in tbl.Rows)
                {
                    ret.Add(row[colName].ToString());
                }
            }

            return ret;

        }
    }
}

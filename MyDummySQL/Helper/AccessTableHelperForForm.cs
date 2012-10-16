using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MyDummySQL.DAOs;

namespace MyDummySQL.Helper
{
    class AccessTableHelperForForm
    {
        static private AccessTableHelperForForm singleton = new AccessTableHelperForForm();
        AccessTableHelperForForm() { }

        static public AccessTableHelperForForm getInstance()
        {
            return AccessTableHelperForForm.singleton;
        }

        static public IList<string> getTableNames()
        {
            List<string> ret = new List<string>();

            using (DAOContext con = new DAOContext(AccessConstring.conString))
            {
                con.OpenConnection();

                AccessSchemaDAO dao = new AccessSchemaDAO(con);
                ret = dao.GetTables();

                con.CloseConnection();
            }

            return ret;
        }
        static public IList<string> getTop5TableVal(string tableName)
        {
            List<string> ret = new List<string>();
            DataTable tbl = null;

            using (DAOContext con = new DAOContext(AccessConstring.conString))
            {
                con.OpenConnection();

                tableDAO dao = new tableDAO(con,tableName);
                tbl = dao.selectTop5();

                con.CloseConnection();
            }

            if (tbl != null)
            {
                foreach (DataRow row in tbl.Rows)
                {
                    ret.Add(row["val"].ToString());
                }
            }

            return ret;
        }
    }
}

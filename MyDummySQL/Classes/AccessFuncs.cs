using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDummySQL.DAOs;
using System.Data;

namespace MyDummySQL.Classes
{
    class AccessFuncs : FunctionsDataBase
    {
        public AccessFuncs()
        {
            DataTable tbl = null;
            using (DAOContext con = new DAOContext(AccessConstring.FuncsConString))
            {
                con.OpenConnection();
                funcsDAO dao = new funcsDAO(con);

                tbl = dao.selectAll();

                foreach (DataRow row in tbl.Rows)
                {
                    string funcname = row["funcname"].ToString();
                    string stringfuncname = row["stringfuncname"].ToString();

                    DataTable argsTbl = dao.selectArgs(funcname);
                    List<string> argTypes = new List<string>();
                    foreach (DataRow arow in argsTbl.Rows)
                    {
                        argTypes.Add(arow["argtype"].ToString());
                    }

                    if (!AccessFuncs.FuncsData.ContainsKey(funcname))
                    {
                        AccessFuncs.FuncsData.Add(funcname, new FuncData(funcname, stringfuncname, argTypes));
                    }
                }

                con.CloseConnection();
            }
        }


        public override Dictionary<string, FuncData> getFuncsData()
        {
            return AccessFuncs.FuncsData;
        }

        private static Dictionary<string, FuncData> FuncsData = new Dictionary<string, FuncData>();


    }
}

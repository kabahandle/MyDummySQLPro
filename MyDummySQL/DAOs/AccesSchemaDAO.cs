using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MyDummySQL.DAOs
{
    class AccessSchemaDAO : MyDAOBase
    {
        public AccessSchemaDAO(DAOContext con) : base(con) { }
        public List<string> GetTables()
        {
            List<string> tableNames = new List<string>();
            DataTable tbl =  this.Context.Connection.GetSchema("Tables", new string[4] { null, null, null, "TABLE" });
            foreach (DataRow row in tbl.Rows)
            {
                tableNames.Add(row["TABLE_NAME"].ToString());
            }
            return tableNames;
        }
    }
}

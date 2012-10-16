using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MyDummySQL.DAOs
{
    class funcsDAO : MyDAOBase
    {
        public funcsDAO(DAOContext con)
            : base(con)
        {
        }

        //select funcs
        public DataTable selectAll()
        {
            string sql = @"select * from funcs ";
            this.ClearParameters();
            return base.GetTable(sql);
        }

        //select args
        public DataTable selectArgs(string funcname)
        {
            string sql = @"select 
                            * 
                        from 
                            args left join argtype on args.argtypeid = argtype.argtypeid
                        where
                            args.funcname like @pfuncname ";
            this.ClearParameters();
            this.AddParameter("pfuncname", DbType.String, funcname);

            return base.GetTable(sql);
        }


}
}

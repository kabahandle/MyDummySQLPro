using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDummySQL.Classes
{
    class EmbeddedFuncs : FunctionsDataBase
    {
        public EmbeddedFuncs()
        {
        }

        public override Dictionary<string, FuncData> getFuncsData()
        {
            return EmbeddedFuncs.EmbededFuncsData;
        }

        private static Dictionary<string, FuncData> EmbededFuncsData = new Dictionary<string, FuncData>()
        {
            { "R", new FuncData("R","Replace", new List<string>(){ "String", "String"}  ) }
        };

    }
}

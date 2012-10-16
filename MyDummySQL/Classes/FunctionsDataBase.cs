using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDummySQL.Classes
{
    abstract class FunctionsDataBase
    {
        public virtual Dictionary<string, FuncData> getFuncsData() { return null; }
    }
}

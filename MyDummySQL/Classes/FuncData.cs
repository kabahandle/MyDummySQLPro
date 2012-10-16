using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDummySQL.Classes
{
    class FuncData
    {
        public FuncData(string funcName_, string stringFuncName_, List<string> argTypes_)
        {
            this.FuncName = funcName_;
            this.StringFuncName = stringFuncName_;
            this.argTypes = argTypes_;
        }
        public string FuncName = "";
        public string StringFuncName = "";
        public List<string> argTypes = null;
    }
}

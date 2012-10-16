using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDummySQL.DAOs
{
    class AccessConstring
    {
        //public static string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\Data\\main.mdb";
        public static string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\App_Data\\main.mdb";
        public static string SettingConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\App_Data\\setting.mdb";
        public static string FuncsConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\App_Data\\funcs.mdb";
    }
}

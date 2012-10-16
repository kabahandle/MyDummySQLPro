using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyDummySQL.Classes
{
    class MyLogSingleton
    {
        private static MyTraceSource appTrace = new MyTraceSource("MainTraceSource", Application.StartupPath + @"\App_Data\Log\Log_"+DateTime.Today.ToString("yyyyMMdd")+".txt");
        MyLogSingleton() { }

        public static MyTraceSource getIncetance()
        {
            return appTrace;
        }

    }
}

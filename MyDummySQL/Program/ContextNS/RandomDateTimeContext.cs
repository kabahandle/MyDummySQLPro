using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDummySQL.FactoryNS;


namespace MyDummySQL.ContextNS
{
    class RandomDateTimeContext : Context
    {
        public DateTime StartDateTime = DateTime.Now;
        public DateTime EndDateTime = DateTime.Now;
        public string IncrementType = string.Empty;

        public RandomDateTimeContext(string param_, int no_)
            : base(param_,no_)
        {
            this.Parse();

            ProgramNodefactory fac = new ProgramNodefactory();
            this.node = fac.Create(this);
        }

        private void Parse()
        {
            char[] sep = { ',' };
            string[] p = this.param.Split(sep);

            if (p.Length < 3)
            {
                throw new ArgumentException("順序日付コマンドの引数は３つ指定して下さい。");
            }

            string strgStartDateSrc = p[0];
            string strgEndDateSrc = p[1];
            string strgIncrementType = p[2];

            strgStartDateSrc = strgStartDateSrc.Substring(0, 4) + "/" + strgStartDateSrc.Substring(4, 2) + "/" + strgStartDateSrc.Substring(6, 2)
                + " " + strgStartDateSrc.Substring(8, 2) + ":" + strgStartDateSrc.Substring(10, 2) + ":" + strgStartDateSrc.Substring(12, 2);
            strgEndDateSrc = strgEndDateSrc.Substring(0, 4) + "/" + strgEndDateSrc.Substring(4, 2) + "/" + strgEndDateSrc.Substring(6, 2)
               + " " + strgEndDateSrc.Substring(8, 2) + ":" + strgEndDateSrc.Substring(10, 2) + ":" + strgEndDateSrc.Substring(12, 2);

            DateTime.TryParse(strgStartDateSrc, out this.StartDateTime);
            DateTime.TryParse(strgEndDateSrc, out this.EndDateTime);
            this.IncrementType = strgIncrementType;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDummySQL.FactoryNS;

namespace MyDummySQL.ContextNS
{
    class RandomNumberContext : Context
    {
        public long StartInt = 0;
        public long EndInt = 0;

        public RandomNumberContext(string param_, int no_)
            : base(param_, no_) 
        {
            this.Parse();

            ProgramNodefactory fac = new ProgramNodefactory();
            this.node = fac.Create(this);
        }

        private void Parse()
        {
            char[] sep = { ',' };
            string[] p = this.param.Split(sep);

            if (p.Length < 2)
            {
                throw new ArgumentException("ランダム番号コマンドの引数は２つ指定して下さい。");
            }

            long.TryParse(p[0], out this.StartInt);
            long.TryParse(p[1], out this.EndInt);
        }
    }
}

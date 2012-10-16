using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDummySQL.FactoryNS;

namespace MyDummySQL.ContextNS
{
    class RandomMySQLTableContext : Context
    {
        public string TableName = "";
        public string ColName = "";

        public RandomMySQLTableContext(string param_, int no_)
            : base(param_,no_)
        {
            this.Parse();

            ProgramNodefactory fac = new ProgramNodefactory();
            this.node = fac.Create(this);
        }

        public void Parse()
        {
            char[] sep = { ',' };
            string[] p = this.param.Split(sep);

            if (p.Length < 2)
            {
                throw new ArgumentException("ランダムMySQLテーブルコマンドの引数は２つ指定して下さい。");
            }

            this.TableName = p[0];
            this.ColName = p[1];
        }

    }
}

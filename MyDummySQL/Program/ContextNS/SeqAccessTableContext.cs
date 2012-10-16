using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDummySQL.FactoryNS;

namespace MyDummySQL.ContextNS
{
    class SeqAccessTableContext : Context
    {
        public string TableName;

        public SeqAccessTableContext(string param_, int no_)
            : base(param_,no_)
        {
            this.Parse();

            ProgramNodefactory fac = new ProgramNodefactory();
            this.node = fac.Create(this);
        }

        private void Parse()
        {
            this.TableName = this.param;
        }
    }
}

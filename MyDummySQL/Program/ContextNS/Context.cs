using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDummySQL.FactoryNS;
using MyDummySQL.NodeNS;

namespace MyDummySQL.ContextNS
{
    abstract class Context
    {
        protected string param = "";
        protected INode node = null;
        public int no { get; set; }

        public Context(string param_, int no_)
        {
            this.param = param_;
            this.no = no_;


            /*
            ProgramNodefactory fac = new ProgramNodefactory();
            this.node = fac.Create(this);
             */
        }

        public virtual string NextString()
        {
            return this.node.NextString();
        }
    }
}

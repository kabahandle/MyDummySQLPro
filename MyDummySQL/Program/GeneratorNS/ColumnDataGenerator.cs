using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDummySQL.ContextNS;
using MyDummySQL.FactoryNS;

namespace MyDummySQL.GeneratorNS
{
    class ColumnDataGenerator
    {
        public Dictionary<long, string> funcsDict = new Dictionary<long, string>();
        public virtual Dictionary<long, string> FuncsDict
        {
            get
            {
                return this.funcsDict;
            }
            set
            {
                this.funcsDict = value;
            }
        }



        protected List<Context> contexts = new List<Context>();
        protected string columnName = "";

        protected ColumnDataGenerator() { }

        public ColumnDataGenerator(string columnName_, string param_)
        {
            this.columnName = columnName_;
            this.contexts = this.ParseParam(param_);
        }
        protected virtual List<Context> ParseParam(string param)
        {
            char[] sep = { '|' };
            string[] atoms = param.Split(sep);
            int no = 0;
            List<Context> cxts = new List<Context>();
            ContextFactory fac = new ContextFactory();

            no = 1;
            foreach (string atom in atoms)
            {
                if (string.IsNullOrEmpty(atom)) { continue; }
                Context cxt = fac.Create(atom,no);
                no++;

                cxts.Add(cxt);
            }

            return cxts;
        }

        public virtual string BuildColumnData()
        {
            string ret = "";
            foreach (Context cxt in this.contexts)
            {
                ret += cxt.NextString().ToString();
            }

            return ret;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDummySQL.ContextNS;
using MyDummySQL.FactoryNS;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MyDummySQL.Classes;
using System.Diagnostics;

namespace MyDummySQL.GeneratorNS
{
    class ContextMaxFunctionDataGenerator : ColumnDataGenerator
    {
        public const string funcHeader = "###MDFUNC###";
        public override Dictionary<long, string> FuncsDict
        {
            get
            {
                return base.FuncsDict;
            }
            set
            {
                this.funcsDict = value;
            }
        }


        public ContextMaxFunctionDataGenerator(string columnName_, string param_)
        {
            this.columnName = columnName_;
            this.contexts = this.ParseParam(param_);
        }
        protected override List<Context> ParseParam(string param)
        {
            Regex regex = new System.Text.RegularExpressions.Regex(@"([a-zA-Z0-9]+[\(].*[\)])+");
            MatchCollection matchCol = regex.Matches(param);
            
            List<string> lstAtoms = new List<string>();

            string proccessedParam = param;
            long funcNo = 1;
            //Dictionary<long, string> funcs = new Dictionary<long, string>();

            for (int i = 0; i < matchCol.Count; i++)
            {
                string func = matchCol[i].Value;
                string funcID = ContextMaxFunctionDataGenerator.funcHeader + funcNo.ToString();
                //MessageBox.Show("Func0:" + func);
                MyLogSingleton.getIncetance().DoLogWithDate(TraceEventType.Verbose, 1, "Func0:" + func);
                
                proccessedParam = proccessedParam.Replace(func, funcID);
                this.funcsDict.Add(funcNo, func);
                
                funcNo++;
            }

            /*
            StringBuilder collineSb = new StringBuilder();
            foreach (string col in lstAtoms)
            {
                collineSb.Append(col);
            }
            */

            string colline = proccessedParam;

            //MessageBox.Show("Line0:"+colline);
            MyLogSingleton.getIncetance().DoLogWithDate(TraceEventType.Verbose, 1, "Line0:" + colline);

            param = colline;

            char[] sep = { '|' };
            string[] atoms = param.Split(sep);
            //string[] atoms = { "" }; //lstAtoms.ToArray<string>();
            int no = 0;
            List<Context> cxts = new List<Context>();
            ContextFactory fac = new ContextFactory();

            Context cxt = null;

            no = 1;
            foreach (string atom in atoms)
            {
                if (string.IsNullOrEmpty(atom)) { continue; }

                if (atom.Contains(ContextMaxFunctionDataGenerator.funcHeader))
                {
                    Regex regex2 = new System.Text.RegularExpressions.Regex(@"("+ContextMaxFunctionDataGenerator.funcHeader+"[a-zA-Z0-9]+)");
                    MatchCollection matchCol2 = regex2.Matches(atom);

                    if (matchCol2.Count > 0)
                    {
                        string num = matchCol2[0].Value.Replace(ContextMaxFunctionDataGenerator.funcHeader, "");
                        long funcNo_ = 0;
                        long.TryParse(num, out funcNo_);

                        string func = this.FuncsDict[funcNo_];

                        cxt = fac.Create(atom, no, funcNo_, this);
                    }
                }
                else
                {
                    cxt = fac.Create(atom, no);
                }
                no++;

                cxts.Add(cxt);
            }

            return cxts;
        }

        public override string BuildColumnData()
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDummySQL.GeneratorNS;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MyDummySQL.Classes;
using System.Reflection;
using System.Diagnostics;

namespace MyDummySQL.ContextNS
{
    class FunctionContext : Context
    {
        //public const string funcHeader = "###MDFUNC###";

        public Dictionary<long, string> funcsDict = new Dictionary<long, string>();

        private string Funcname { get; set; }
        private List<string> Args { get; set; }
        private string innerCol { get; set; }
        private string FunctionID { get; set; }
        private ColumnDataGenerator Gen { get; set; }
        private ColumnDataGenerator InnerMinGen { get; set; }
        private ColumnDataGenerator InnerMaxGen { get; set; }
        public FunctionContext(string param_, int no_, long funcno_, ColumnDataGenerator gen)
            : base(param_, no_)
        {
            string eval = gen.funcsDict[funcno_];

            //this.Funcname = funcName_;


            //関数名
            Regex regex = new System.Text.RegularExpressions.Regex(@"([a-zA-Z0-9]+)[\(].*[\)]");
            MatchCollection matchCol = regex.Matches(eval);

            if (matchCol.Count > 0 && matchCol[0].Groups.Count > 1)
            {
                this.Funcname = matchCol[0].Groups[1].Value;
                //MessageBox.Show("Func:" + this.Funcname);
                MyLogSingleton.getIncetance().DoLogWithDate(TraceEventType.Verbose, 1,"Func:"+this.Funcname);


                //this.InnerGen = new ContextColumnDataGenerator(this.Funcname, this.innerCol);
            }

            ArgSelector asel = new ArgSelector();
            this.Args = asel.SelectArgs(eval.Substring(this.Funcname.Length),1);

            foreach (string arg in this.Args)
            {
                //MessageBox.Show("Arg:"+arg);
                MyLogSingleton.getIncetance().DoLogWithDate(TraceEventType.Verbose, 1, "Arg:" + arg);
            }

            //引数部取得
            string inner = eval.Replace(this.Funcname + "(", "");
            inner = inner.Substring(0, inner.Length - 1);

            //引数部
            /*
            Regex regex2 = new System.Text.RegularExpressions.Regex(@"([a-zA-Z0-9]+[\(][^\)]*[\)])");
            MatchCollection matchCol2 = regex2.Matches(inner);

            string proccessedParam = inner;
            long funcNo = 1;

            if (matchCol2.Count > 0 && matchCol2[0].Groups.Count > 1)
            {
                foreach (Match m in matchCol2)
                {
                    //this.innerCol = matchCol2[0].Groups[1].Value;

                    MessageBox.Show("innerFunc:" + m.Groups[1].Value);

                    string func = m.Groups[1].Value;
                    string funcID = ContextMaxFunctionDataGenerator.funcHeader + funcNo.ToString();

                    proccessedParam = proccessedParam.Replace(func, funcID);
                    this.funcsDict.Add(funcNo, func);

                    funcNo++;

                }

            }
             */

            //Regex regexMin = new System.Text.RegularExpressions.Regex(@"([a-zA-Z0-9]+[\(][^\)]*[\)])+");
            //MatchCollection matchColMin = regexMin.Matches(inner);

            FunctionSelector sel = new FunctionSelector();

            List<string> funcs = sel.SelectFunctions(inner, 1);



            //if (matchColMin.Count > 0 && matchColMin[0].Groups.Count > 1)
            if( funcs.Count > 0 )
            {
                //MessageBox.Show("min");
                MyLogSingleton.getIncetance().DoLogWithDate(TraceEventType.Verbose, 1, "min:");
                this.InnerMinGen = new ContextMinFunctionDataGenerator("", inner);
            }
            else
            {
                //MessageBox.Show("max");
                MyLogSingleton.getIncetance().DoLogWithDate(TraceEventType.Verbose, 1, "max:");
                this.InnerMaxGen = new ContextMaxFunctionDataGenerator("", inner);
            }

            /*
            if (this.Funcname != null && this.innerCol != null)
            {
                this.InnerGen = new ContextMinFunctionDataGenerator(this.Funcname, this.innerCol);
            }
            */
        }

        public override string NextString()
        {
            string returnSring = "";
            if (this.InnerMinGen != null)
            {
                returnSring =  this.InnerMinGen.BuildColumnData();
            }
            else if (this.InnerMaxGen != null)
            {
                returnSring = this.InnerMaxGen.BuildColumnData();
            }
            else
            {
                returnSring = "";
            }

            //FunctionsDataBase objFunc = new EmbeddedFuncs();
            FunctionsDataBase objFunc = new AccessFuncs();
            Dictionary<string, FuncData> funcs = objFunc.getFuncsData();

            if (funcs.ContainsKey(this.Funcname))
            {

                FuncData fd = funcs[this.Funcname];
                int argNum = fd.argTypes.Count;
                string stringFuncName = fd.StringFuncName;

                if (argNum == (this.Args.Count - 1))
                {
                    //System.StringのTypeを取得する
                    Type t = Type.GetType("System.String");

                    //System.Stringのインスタンスを作成する
                    //str = new System.String('*', 10);
                    //と同等
                    /*
                    object str = t.InvokeMember(null,
                        System.Reflection.BindingFlags.CreateInstance,
                        null, null,
                        new object[] {this.Args[0]});
                     */
                    string str = returnSring;

                    //List<Type> pt = new List<Type>();
                    List<object> argExcept1StArg = new List<object>();
                    bool isfirst = true;
                    for (int i = 0; i < this.Args.Count; i++ )
                    {
                        string arg = this.Args[i];
                        //pt.Add(Type.GetType("System.String"));
                        if (isfirst == true)
                        {
                            isfirst = false;
                            continue;
                        }

                        if (i > 0)
                        {
                            switch (fd.argTypes[i - 1])
                            {
                                case "int":
                                    int i1 = 0;
                                    int.TryParse(arg, out i1);
                                    argExcept1StArg.Add(i1);
                                    break;
                                case "long":
                                    long l = 0;
                                    long.TryParse(arg, out l);
                                    argExcept1StArg.Add(l);
                                    break;
                                case "String":
                                    argExcept1StArg.Add(arg);
                                    break;
                                case "string":
                                    argExcept1StArg.Add(arg);
                                    break;
                                case "char":
                                    char c = '\0';
                                    if (arg.Length > 0)
                                    {
                                        c = arg[0];
                                    }
                                    argExcept1StArg.Add(c);
                                    break;
                            }
                        }

                    }
                    //Type[] paramTypes = pt.ToArray<Type>();

                    //System.StringのReplaceメソッドを呼び出す
                    //result = str.Replace('*', '+');
                    //と同等
                    object result = t.InvokeMember(fd.StringFuncName,
                        System.Reflection.BindingFlags.InvokeMethod,
                        null, str,
                        argExcept1StArg.ToArray());

                    //string a = "";
                    //a.Substring(1);
                    

                    return result.ToString();
                }
            }

            return returnSring;

        }
    }
}

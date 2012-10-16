using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MyDummySQL.Classes
{
    class ArgSelector
    {
        public ArgSelector() { }

        public List<string> SelectArgs(string line, int level)
        {
            List<string> functions = new List<string>();

            Regex regex = new System.Text.RegularExpressions.Regex(@"[a-zA-Z0-9]+");

            int startlv = 0;
            StringBuilder funcName = new StringBuilder();
            StringBuilder hikisu = new StringBuilder();
            List<string> funcs = new List<string>();

            List<string> args = new List<string>();


            bool inFunc = false;
            bool inFuncInFunc = false;
            int inFuncInFuncLevel = 0;
            for (int i = 0; i < line.Length; i++)
            {
                string mono = line[i].ToString();

                if (inFunc == false && regex.IsMatch(mono))
                {
                    funcName.Append(mono);
                    continue;
                }
                else if ("(".Equals(mono))
                {
                    startlv++;
                    if (startlv == level)
                    {
                        inFunc = true;
                    }
                    else if (inFunc == true)
                    {
                        inFuncInFunc = true;
                        inFuncInFuncLevel++;
                        hikisu.Append(mono);
                    }
                    else
                    {
                        hikisu.Append(mono);
                    }
                    continue;
                }
                else if (")".Equals(mono))
                {
                    if (inFuncInFunc == true && inFunc == true )
                    {
                        inFuncInFuncLevel--;
                        if (inFuncInFuncLevel == 0)
                        {
                            inFuncInFunc = false;
                        }
                    }
                    if (startlv == level)
                    {
                        inFunc = false;

                        if (hikisu.Length > 0)
                        {
                            args.Add(hikisu.ToString());
                        }

                        funcs.Add(funcName.ToString() + "(" + hikisu.ToString() + ")");
                        funcName.Clear();
                        hikisu.Clear();
                    }
                    else
                    {
                        hikisu.Append(mono);
                    }
                    startlv--;
                }
                else if (inFuncInFunc == false && ";".Equals(mono))
                {
                    args.Add(hikisu.ToString());
                    hikisu.Clear();
                }
                else if (inFunc == true)
                {
                    hikisu.Append(mono);
                }
                else
                {
                    funcName.Clear();
                }
            }


            return args;
        }
    }
}

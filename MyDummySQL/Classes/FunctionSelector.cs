using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MyDummySQL.Classes
{
    class FunctionSelector
    {
        public FunctionSelector() { }

        public List<string> SelectFunctions(string line, int level)
        {
            List<string> functions = new List<string>();

            Regex regex = new System.Text.RegularExpressions.Regex(@"[a-zA-Z0-9]+");

            int startlv = 0;
            StringBuilder funcName = new StringBuilder();
            StringBuilder hikisu = new StringBuilder();
            List<string> funcs = new List<string>();
            bool inFunc = false;
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
                    else
                    {
                        hikisu.Append(mono);
                    }
                    continue;
                }
                else if (")".Equals(mono))
                {
                    if (startlv == level)
                    {
                        inFunc = false;

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
                else if (inFunc == true)
                {
                    hikisu.Append(mono);
                }
                else
                {
                    funcName.Clear();
                }
            }

            return funcs;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDummySQL.ContextNS;
using MyDummySQL.GeneratorNS;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyDummySQL.FactoryNS
{
    class ContextFactory
    {

        public ContextFactory()
        {
        }

        public Context Create(string funcParam, int no_, long funcno_, ColumnDataGenerator gen)
        {
            return new FunctionContext(funcParam, no_, funcno_, gen);
        }


        public Context Create(string atomParam, int no)
        {
            //Regex regex = new System.Text.RegularExpressions.Regex(@"([\w\|]+[\(].*[\)]|[\w\|]+)+");
            //MatchCollection matchCol = regex.Matches(atomParam);


            char[] sep = { ':' };
            string[] parts = atomParam.Split(sep);

            //ガード
            if (parts.Length != 2)
            {
                throw new ArgumentException("アトムコマンドのフォーマットエラーです。「:」で区切ってください。");
            }

            string  ctxarg = "";
            if (parts[1].Contains(";"))
            {
                ctxarg = parts[1].Substring(0,parts[1].IndexOf(';') );
            }
            else
            {
                ctxarg = parts[1];
            }

            //MessageBox.Show(ctxarg);
            

            switch (parts[0].ToLower())
            {
                case "seqint":
                    return new SeqNumberContext(ctxarg, no);
                    //break;
                case "rndint":
                    return new RandomNumberContext(ctxarg, no);
                    //break;
                case "seqactbl":
                    return new SeqAccessTableContext(ctxarg, no);
                case "rndactbl":
                    return new RandomAccessTableContext(ctxarg, no);
                case "seqmstbl":
                    return new SeqMySQLTableContext(ctxarg, no);
                case "rndmstbl":
                    return new RandomMySQLTableContext(ctxarg, no);
                case "const":
                    return new ConstStringContext(ctxarg, no);
                case "seqdate":
                    return new SeqDateContext(ctxarg, no);
                case "rnddate":
                    return new RandomDateContext(ctxarg, no);
                case "seqdatetime":
                    return new SeqDateTimeContext(ctxarg, no);
                case "rnddatetime":
                    return new RandomDateTimeContext(ctxarg, no);
                default:
                    //throw new ArgumentException("存在しないアトムコマンドです。");
                    return null;
            }
        }
    }
}

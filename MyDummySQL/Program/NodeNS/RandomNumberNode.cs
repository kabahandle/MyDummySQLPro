using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDummySQL.NodeNS
{
    class RandomNumberNode : INode
    {
        private long startInt = 0;
        private long endInt = 0;
        private Random objRnd = null;
        public RandomNumberNode(long startInt_, long endInt_)
        {
            //ガード
            if (startInt_ >= endInt_)
            {
                ArgumentException aexcep = new ArgumentException("startIntがendIntより大きな数です。");
                throw aexcep;
            }
                
            this.startInt = startInt_;
            this.endInt = endInt_;


            //ランダムシード
            int seed = Environment.TickCount;
            this.objRnd = new Random(seed);
        }
        public string NextString()
        {
            //調整したランダム数値取得
            long divide = this.endInt - this.startInt;
            double d = this.objRnd.NextDouble();
            long ret = this.startInt + ((long)(d * (double)divide));

            return ret.ToString();
        }
    }
}

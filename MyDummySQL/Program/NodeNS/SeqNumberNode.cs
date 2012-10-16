using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDummySQL.NodeNS
{
    class SeqNumberNode : INode
    {
        private long startInt = 0;
        private long endInt = 0;
        private long currentInt = 0;
        public SeqNumberNode(long startInt_, long endInt_)
        {
            //ガード
            if (startInt_ >= endInt_)
            {
                ArgumentException aexcep = new ArgumentException("startIntがendIntより大きな数です。");
                throw aexcep;
            }

            this.startInt = startInt_;
            this.endInt = endInt_;

            this.currentInt = this.startInt - 1;
        }
        public string NextString()
        {
            //インクリメント
            this.currentInt++;
            
            //フィルター、リミッター
            if (this.currentInt <= this.startInt)
            {
                this.currentInt = this.startInt;
            }
            if (this.currentInt > this.endInt)
            {
                this.currentInt = this.startInt;
            }

            //戻り値
            return this.currentInt.ToString();
        }

    }
}

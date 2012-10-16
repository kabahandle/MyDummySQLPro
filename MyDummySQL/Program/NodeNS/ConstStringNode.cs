using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDummySQL.NodeNS
{
    class ConstStringNode : INode
    {
        private string ConstString = "";
        public ConstStringNode(string constString_)
        {
            this.ConstString = constString_;
        }

        public string NextString()
        {
            return this.ConstString;
        }
    }
}

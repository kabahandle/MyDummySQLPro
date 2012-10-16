using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDummySQL.HelperNS
{
    class ContextNo
    {
        private long lineNo = 0;
        private long rowsMaxCount = 0;

        public ContextNo(long lineNo_, long rowsMaxCount_)
        {
            this.lineNo = lineNo_;
            this.rowsMaxCount = rowsMaxCount_;
        }

        public long Increment()
        {
            lineNo++;
            if ((rowsMaxCount != 0 ) &&  lineNo > rowsMaxCount)
            {
                lineNo = 1;
            }
            return lineNo;
        }
    }
}

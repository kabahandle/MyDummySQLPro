using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDummySQL.ContextNS;
using MyDummySQL.NodeNS;

namespace MyDummySQL.FactoryNS
{
    class ProgramNodefactory
    {
        private List<INode> nodes = new List<INode>();

        public ProgramNodefactory()
        {
        }

        /*
         * 基底クラスを引数にしない
        public void Visit(Context cxt)
        {
        }
         */
        public INode Create(Context cxt)
        {
            NotImplementedException excep = new NotImplementedException("このメソッドの引数クラスは抽象クラスです。");
            throw excep;
            //return null;
        }
        public INode Create(SeqNumberContext seqCtx)
        {
            return new SeqNumberNode(seqCtx.StartInt, seqCtx.EndInt);
        }

        public INode Create(RandomNumberContext rndCxt)
        {
            return new RandomNumberNode(rndCxt.StartInt, rndCxt.EndInt);
        }

        public INode Create(SeqAccessTableContext seqAcTblCxt)
        {
            return new SeqAccessTableNode(seqAcTblCxt.TableName);
        }

        public INode Create(RandomAccessTableContext rndAcTblCxt)
        {
            return new RandomAccessTableNode(rndAcTblCxt.TableName);
        }

        public INode Create(SeqMySQLTableContext seqMsTblCxt)
        {
            return new SeqMySQLTableNode(seqMsTblCxt.TableName, seqMsTblCxt.ColName);
        }

        public INode Create(RandomMySQLTableContext rndMsTblCxt)
        {
            return new RandomMySQLTableNode(rndMsTblCxt.TableName, rndMsTblCxt.ColName);
        }

        public INode Create(ConstStringContext cstStrgCxt)
        {
            return new ConstStringNode(cstStrgCxt.ConstString);
        }

        public INode Create(SeqDateContext seqDateCxt)
        {
            return new SeqDateNode(seqDateCxt.StartDate, seqDateCxt.EndDate, seqDateCxt.IncrementType);
        }
        public INode Create(RandomDateContext rndDateCxt)
        {
            return new RandomDateNode(rndDateCxt.StartDate, rndDateCxt.EndDate, rndDateCxt.IncrementType);
        }

        public INode Create(SeqDateTimeContext seqDateTimeCxt)
        {
            return new SeqDateTimeNode(seqDateTimeCxt.StartDateTime, seqDateTimeCxt.EndDateTime, seqDateTimeCxt.IncrementType);
        }

        public INode Create(RandomDateTimeContext rndDateTimeCxt)
        {
            return new RandomDateTimeNode(rndDateTimeCxt.StartDateTime, rndDateTimeCxt.EndDateTime, rndDateTimeCxt.IncrementType);
        }
    }
}

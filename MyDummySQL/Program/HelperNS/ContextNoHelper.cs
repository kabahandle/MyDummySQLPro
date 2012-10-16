using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDummySQL.ContextNS;

namespace MyDummySQL.HelperNS
{
    class ContextNoHelper
    {
        //シングルトン
        static private ContextNoHelper singleton_ = new ContextNoHelper();
        //プライベートコンストラクタ
        ContextNoHelper() { }

        //シングルトン取得メソッド
        static public ContextNoHelper getInstance()
        {
            return ContextNoHelper.singleton_;
        }

        //現在行保持用Dict
        static private Dictionary<Context, ContextNo> dictOfNoClass = new Dictionary<Context, ContextNo>();

        //次の行
        static public long getNextRowNo(Context cxt)
        {
            if (ContextNoHelper.dictOfNoClass.Keys.Contains(cxt))
            {
                ContextNo objNo = ContextNoHelper.dictOfNoClass[cxt];
                return objNo.Increment();
            }
            else
            {
                return 1;
            }
        }
        //現在行保持用Dictに、１つのコンテキストを追加
        static public void setContextToDict(Context cxt, long rowsMaxNumber)
        {
            if (!ContextNoHelper.dictOfNoClass.Keys.Contains(cxt))
            {
                ContextNoHelper.dictOfNoClass.Add(cxt, new ContextNo(1, rowsMaxNumber));
            }
        }
    }
}

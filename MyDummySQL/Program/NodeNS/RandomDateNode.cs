using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDummySQL.NodeNS
{
    class RandomDateNode : INode
    {
        private DateTime startDate = DateTime.Now;
        private DateTime endDate = DateTime.Now;
        private DateTime currentDate = DateTime.Now;
        private TimeSpan divide = TimeSpan.Zero;
        private string IncrementType = string.Empty;
        private Random objRnd = null;

        public RandomDateNode(DateTime startDate_, DateTime endDate_, string strgIncrementType)
        {
            //ガード
            if (startDate_ > endDate_)
            {
                ArgumentException aexcep = new ArgumentException("startDateがendDateより大きな数です。");
                throw aexcep;
            }

            this.startDate = startDate_;
            this.endDate = endDate_;

            this.divide = endDate_.Subtract(startDate_);

            this.IncrementType = strgIncrementType;

            this.currentDate = this.startDate;

            //ランダムシード
            int seed = Environment.TickCount;
            this.objRnd = new Random(seed);
        }
        public string NextString()
        {
            //インクリメント
            //this.currentDate++;
            switch (this.IncrementType)
            {
                case "日":
                    double d = this.objRnd.NextDouble() * this.divide.TotalDays;
                    this.currentDate = this.startDate.AddDays(d);
                    break;
                case "月":
                    int m = (int)((this.objRnd.NextDouble() * this.divide.TotalDays) / 30);
                    this.currentDate = this.startDate.AddMonths(m);
                    break;
                case "年":
                    int y = (int)((this.objRnd.NextDouble() * this.divide.TotalDays) / (365));
                    this.currentDate = this.startDate.AddYears(y);
                    break;
                default:
                    break;
            }

            
            //フィルター、リミッター
            if (this.currentDate <= this.startDate)
            {
                this.currentDate = this.startDate;
            }
            if (this.currentDate > this.endDate)
            {
                this.currentDate = this.endDate;
            }

            //戻り値
            return this.currentDate.ToString("yyyy/MM/dd");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDummySQL.NodeNS
{
    class RandomDateTimeNode : INode
    {
        private DateTime startDateTime = DateTime.Now;
        private DateTime endDateTime = DateTime.Now;
        private DateTime currentDateTime = DateTime.Now;
        private TimeSpan divide = TimeSpan.Zero;
        private string IncrementType = string.Empty;
        private Random objRnd = null;

        public RandomDateTimeNode(DateTime startDateTime_, DateTime endDateTime_, string strgIncrementType)
        {
            //ガード
            if (startDateTime_ > endDateTime_)
            {
                ArgumentException aexcep = new ArgumentException("startDateがendDateより大きな数です。");
                throw aexcep;
            }

            this.startDateTime = startDateTime_;
            this.endDateTime = endDateTime_;

            this.divide = endDateTime_.Subtract(startDateTime_);

            this.IncrementType = strgIncrementType;

            this.currentDateTime = this.startDateTime;

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
                case "秒":
                    double sec = this.objRnd.NextDouble() * this.divide.TotalSeconds;
                    this.currentDateTime = this.startDateTime.AddSeconds(sec);
                    break;
                case "分":
                    double min = this.objRnd.NextDouble() * this.divide.TotalMinutes;
                    this.currentDateTime = this.startDateTime.AddMinutes(min);
                    break;
                case "時":
                    double h = this.objRnd.NextDouble() * this.divide.TotalHours;
                    this.currentDateTime = this.startDateTime.AddHours(h);
                    break;
                case "日":
                    double d = this.objRnd.NextDouble() * this.divide.TotalDays;
                    this.currentDateTime = this.startDateTime.AddDays(d);
                    break;
                case "月":
                    int m = (int)((this.objRnd.NextDouble() * this.divide.TotalDays) / 30);
                    this.currentDateTime = this.startDateTime.AddMonths(m);
                    break;
                case "年":
                    int y = (int)((this.objRnd.NextDouble() * this.divide.TotalDays) / (365));
                    this.currentDateTime = this.startDateTime.AddYears(y);
                    break;
                default:
                    break;
            }

            
            //フィルター、リミッター
            if (this.currentDateTime <= this.startDateTime)
            {
                this.currentDateTime = this.startDateTime;
            }
            if (this.currentDateTime > this.endDateTime)
            {
                this.currentDateTime = this.endDateTime;
            }

            //戻り値
            return this.currentDateTime.ToString("yyyy/MM/dd HH:mm:ss");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDummySQL.NodeNS
{
    class SeqDateTimeNode : INode
    {
        private DateTime startDateTime = DateTime.Now;
        private DateTime endDateTime = DateTime.Now;
        private DateTime currentDateTime = DateTime.Now;
        private string IncrementType = string.Empty;

        public SeqDateTimeNode(DateTime startDateTime_, DateTime endDateTime_, string strgIncrementType)
        {
            //ガード
            if (startDateTime_ > endDateTime_)
            {
                ArgumentException aexcep = new ArgumentException("startDateがendDateより大きな数です。");
                throw aexcep;
            }

            this.startDateTime = startDateTime_;
            this.endDateTime = endDateTime_;

            this.IncrementType = strgIncrementType;

            this.currentDateTime = this.startDateTime;

            switch (this.IncrementType)
            {
                case "秒":
                    this.currentDateTime = this.currentDateTime.AddSeconds(-1);
                    break;
                case "分":
                    this.currentDateTime = this.currentDateTime.AddMinutes(-1);
                    break;
                case "時":
                    this.currentDateTime = this.currentDateTime.AddHours(-1);
                    break;
                case "日":
                    this.currentDateTime = this.currentDateTime.AddDays(-1);
                    break;
                case "月":
                    this.currentDateTime = this.currentDateTime.AddMonths(-1);
                    break;
                case "年":
                    this.currentDateTime = this.currentDateTime.AddYears(-1);
                    break;
                default:
                    break;
            }

        }
        public string NextString()
        {
            //インクリメント
            //this.currentDate++;
            switch (this.IncrementType)
            {
                case "秒":
                    this.currentDateTime = this.currentDateTime.AddSeconds(1);
                    break;
                case "分":
                    this.currentDateTime = this.currentDateTime.AddMinutes(1);
                    break;
                case "時":
                    this.currentDateTime = this.currentDateTime.AddHours(1);
                    break;
                case "日":
                    this.currentDateTime = this.currentDateTime.AddDays(1);
                    break;
                case "月":
                    this.currentDateTime = this.currentDateTime.AddMonths(1);
                    break;
                case "年":
                    this.currentDateTime = this.currentDateTime.AddYears(1);
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
                this.currentDateTime = this.startDateTime;
            }

            //戻り値
            return this.currentDateTime.ToString("yyyy/MM/dd HH:mm:ss");
        }

    }
}

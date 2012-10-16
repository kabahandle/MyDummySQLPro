using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDummySQL.NodeNS
{
    class SeqDateNode : INode
    {
        private DateTime startDate = DateTime.Now;
        private DateTime endDate = DateTime.Now;
        private DateTime currentDate = DateTime.Now;
        private string IncrementType = string.Empty;

        public SeqDateNode(DateTime startDate_, DateTime endDate_, string strgIncrementType)
        {
            //ガード
            if (startDate_ > endDate_)
            {
                ArgumentException aexcep = new ArgumentException("startDateがendDateより大きな数です。");
                throw aexcep;
            }

            this.startDate = startDate_;
            this.endDate = endDate_;

            this.IncrementType = strgIncrementType;

            this.currentDate = this.startDate;

            switch (this.IncrementType)
            {
                case "日":
                    this.currentDate = this.currentDate.AddDays(-1);
                    break;
                case "月":
                    this.currentDate = this.currentDate.AddMonths(-1);
                    break;
                case "年":
                    this.currentDate = this.currentDate.AddYears(-1);
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
                case "日":
                    this.currentDate = this.currentDate.AddDays(1);
                    break;
                case "月":
                    this.currentDate = this.currentDate.AddMonths(1);
                    break;
                case "年":
                    this.currentDate = this.currentDate.AddYears(1);
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
                this.currentDate = this.startDate;
            }

            //戻り値
            return this.currentDate.ToString("yyyy/MM/dd");
        }

    }
}

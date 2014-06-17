using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace KanColleAlarm
{
    [Serializable]
    public class Expedition
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public TimeSpan TimeCost
        {
            get { return FormatTools.ParseTimeSpan(CostValue); }
            set { CostValue = value.ToString(); }
        }

        public string CostValue { get; set; }
    }

}

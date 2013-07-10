using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpenditureTracker.Entities
{
    public class TrackerAttributes
    {
        public string DateAtt { get; set; }
        public string DayAtt { get; set; }
        public string MonthAtt { get; set; }
        public string YearAtt { get; set; }
        public float USDAtt { get; set; }
        public string PaymentTypeAtt { get; set; }
        public string PaymentCategoryAtt { get; set; }
        public string DescriptionAtt { get; set; }
        public string EssentialAtt { get; set; }

        public DateTime DateNow { get; set; }
    }
}

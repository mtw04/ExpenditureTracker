using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpenditureTracker.Entities
{
    public class Settings
    {
        public bool SelectDate { get; set; }
        public bool SelectYear { get; set; }
        public bool SelectUpload { get; set; }
        public bool ViewConfirmation { get; set; }
    }
}

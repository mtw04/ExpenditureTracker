using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpenditureTracker.Entities
{
    public class SelectionEnums
    {
        public enum PaymentType
        {
            HSBC,
            AMEX,
            CHASE,
            CASH
        };

        public enum PaymentCategory
        {
            Bills,
            CarFees,
            Petrol,
            Grocery,
            Restaurant,
            Supplies,
            Rent,
            Holiday,
            Other
        };
    }
}

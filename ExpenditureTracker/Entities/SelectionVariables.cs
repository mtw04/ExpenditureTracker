using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpenditureTracker.Entities
{
    public class SelectionVariables
    {
        public enum PaymentType
        {
            HSBC,
            AMEX,
            CHASE,
            CASH
        };

        public void GetVariables()
        {
            List<string> PaymentTypeOptions = new List<string>();
 
            foreach (PaymentType paymentType in Enum.GetValues(typeof(PaymentType)))
            {
                PaymentTypeOptions.Add(paymentType.ToString());
            }

            string s = PaymentTypeOptions[PaymentTypeOptions.IndexOf("AMEX")];

            //int t = (int)PaymentType.AMEX;
            string v = PaymentType.AMEX.ToString();
        }
    }

}

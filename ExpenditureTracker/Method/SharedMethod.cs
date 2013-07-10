using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpenditureTracker.Method
{
    public class SharedMethod
    {
        public static string GetYear(DateTime inputDate)
        {
            return inputDate.Year.ToString();
        }

        public static string GetMonth(DateTime inputDate)
        {
            return Helper.VerifyString(inputDate.Month.ToString());
        }

        public static string GetDay(DateTime inputDate)
        {
            return Helper.VerifyString(inputDate.Day.ToString());
        }

        public static string GetDate(string inputDay, string inputMonth, string inputYear)
        {
            return (inputMonth + "/" + inputDay + "/" + inputYear);
        }
    }
}

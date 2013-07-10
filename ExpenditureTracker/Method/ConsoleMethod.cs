using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ExpenditureTracker.Entities;

namespace ExpenditureTracker.Method
{
    class ConsoleMethod
    {
        public static void Header()
        {
            ///----------[ Console UI ]----------///
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("ExpenditureTracker");
            Console.WriteLine("Designed by: Mike Wu.");
            Console.WriteLine("Ver 0.2");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
        }

        public static string GetDay(bool SelectDate, string itemDay, DateTime inputDate)
        {
            if (SelectDate == true)
            {
                Console.Write("Enter Day [Press ENTER to use same day as before]: ");
                string inputDay = Console.ReadLine();

                if (inputDay == "" && itemDay != null)
                    return itemDay;
                else
                {
                    return Method.SharedMethod.GetDay(inputDate);
                }
            }
            else
            {
                return Method.SharedMethod.GetDay(inputDate);
            }
        }

        public static string GetMonth(bool SelectDate, DateTime inputDate)
        {
            if (SelectDate == true)
            {
                Console.Write("Enter Month: ");
                return (Console.ReadLine());
            }
            else
            {
                return Method.SharedMethod.GetMonth(inputDate);
            }
        }

        public static string GetYear(bool SelectDate, bool SelectYear, DateTime inputDate)
        {
            string input = null;
            if (SelectDate & SelectYear)
            {
                Console.Write("Enter Year: ");
                input = Console.ReadLine();

                if (input.Length == 4)
                    return input;
                else
                    return ("20" + input);
            }
            else
                return Method.SharedMethod.GetYear(inputDate);
        }

        public static string GetDate(string itemDay, string itemMonth, string itemYear)
        {
            return Method.SharedMethod.GetDate(itemDay, itemMonth, itemYear);
        }

        public static float GetUSD()
        {
            // Get USD value
            String readValue = null;
            float itemValue = 0;

            do
            {
                Console.Write("Enter USD Value: ");
                readValue = Console.ReadLine();
                float.TryParse(readValue, out itemValue);
            } while (string.IsNullOrEmpty(readValue));

            return itemValue;
        }

        public static string GetCardType()
        {
            // Get card type
            string itemCard = null;
            string readCard = null;

            // list available card types as reminder
            Console.WriteLine("Card Type: [AMEX(A)] [HSBC(H)] [CHASE(F)] [CASH(C)] ");

            Console.Write("Enter Card Type: ");
            readCard = Console.ReadLine();

            switch (readCard)
            {
                case "a":
                case "A":
                case "amex":
                case "AMEX":
                    itemCard = SelectionEnums.PaymentType.AMEX.ToString();
                    break;
                case "h":
                case "H":
                case "hsbc":
                case "HSBC":
                    itemCard = SelectionEnums.PaymentType.HSBC.ToString();
                    break;
                case "c":
                case "C":
                case "cash":
                case "CASH":
                    itemCard = SelectionEnums.PaymentType.CASH.ToString();
                    break;
                case "f":
                case "F":
                case "chase":
                case "CHASE":
                    itemCard = SelectionEnums.PaymentType.CHASE.ToString();
                    break;
                default:
                    itemCard = SelectionEnums.PaymentType.AMEX.ToString();
                    break;
            }
            return itemCard;
        }

        public static string GetCategory()
        {
            // Get category
            string itemCat = null;
            string readCat = null;

            // list available categories as reminder
            Console.WriteLine("Category: [Bills] [Car] [Petrol] [Grocery] [Restaurant] [Supplies] \n" +
                              "\t  [Rent] [Other]");

            Console.Write("Enter Item Category: ");
            readCat = Console.ReadLine();

            switch (readCat)
            {
                case "b":
                case "B":
                    itemCat += SelectionEnums.PaymentCategory.Bills.ToString();
                    break;
                case "c":
                case "C":
                    itemCat += SelectionEnums.PaymentCategory.CarFees.ToString();
                    break;
                case "p":
                case "P":
                    itemCat += SelectionEnums.PaymentCategory.Petrol.ToString();
                    break;
                case "g":
                case "G":
                    itemCat += SelectionEnums.PaymentCategory.Grocery.ToString();
                    break;
                case "r":
                case "R":
                    itemCat += SelectionEnums.PaymentCategory.Restaurant.ToString();
                    break;
                case "s":
                case "S":
                    itemCat += SelectionEnums.PaymentCategory.Petrol.ToString();
                    break;
                case "re":
                case "RE":
                    itemCat += SelectionEnums.PaymentCategory.Rent.ToString();
                    break;
                case "h":
                case "H":
                    itemCat += SelectionEnums.PaymentCategory.Holiday.ToString();
                    break;
                case "o":
                case "O":
                    itemCat += SelectionEnums.PaymentCategory.Other.ToString();
                    break;
                default:
                    itemCat += SelectionEnums.PaymentCategory.Other.ToString();
                    break;
            }

            return itemCat;

            #region multi-category (N/A)
            //while (readCat != "")
            //{
            //    Console.Write("Enter Item Category: ");
            //    readCat = Console.ReadLine();

            //    switch (readCat)
            //    {
            //        case "b":
            //        case "B":
            //            itemCat += "bills, ";
            //            break;
            //        case "c":
            //        case "C":
            //            itemCat += "car, ";
            //            break;
            //        case "p":
            //        case "P":
            //            itemCat += "petrol, ";
            //            break;
            //        case "g":
            //        case "G":
            //            itemCat += "grocer, ";
            //            break;
            //        case "r":
            //        case "R":
            //            itemCat += "restaurant, ";
            //            break;
            //        case "s":
            //        case "S":
            //            itemCat += "supplies, ";
            //            break;
            //        case "re":
            //        case "RE":
            //            itemCat += "rent, ";
            //            break;
            //        case "o":
            //        case "O":
            //            itemCat += "other, ";
            //            break;
            //        case "":
            //            if (!string.IsNullOrEmpty(itemCat))
            //                itemCat = itemCat.Remove(itemCat.Length - 2); //truncate to remove extra commas
            //            break;
            //        default:
            //            itemCat += readCat + ", ";
            //            break;
            //    }
            //};
            #endregion
        }

        public static string GetDescription()
        {
            // Get description
            Console.Write("Enter Item Description: ");
            return (Console.ReadLine());
        }

        public static string GetEssential()
        {
            // Get essential flag
            Console.Write("Item Essential? [Y/N]: ");
            String readEssential = Console.ReadLine();

            switch (readEssential)
            {
                case "Y":
                case "y":
                    return "True";
                default:
                    return "False";
            }
        }

        public static void ShowSummary(string itemDate, float itemValue, string itemCardType, string itemCat, string itemDesc, string itemEssential)
        {
            // Show summary
            Console.WriteLine("\n--------------------------------------------------\n" +
                              "Summary: \n" +
                              "Date: " + itemDate + "\n" +
                              "USD: $" + itemValue + "\n" +
                              "Card Type: " +itemCardType + "\n" +
                              "Category: " + itemCat + "\n" +
                              "Description: " + itemDesc + "\n" +
                              "Essential: " + itemEssential + "\n" +
                              "--------------------------------------------------");
        }

        public static void UploadSQLConsole(bool selectUpload, string itemDate, string itemMonth, string itemDay, string itemYear, float itemValue, string itemCardType, string itemCat, string itemEssential, string itemDesc)
        {
            // Upload to SQL
            if (selectUpload == true)
            {
                Console.Write("Upload data to database? [Y/N]: ");
                String uploadConf = Console.ReadLine();

                switch (uploadConf)
                {
                    case "y":
                    case "Y":
                        Helper.WriteDataToSQL(itemDate, itemMonth, itemDay, itemYear, itemValue, itemCardType, itemCat, itemEssential, itemDesc);
                        Console.WriteLine("Database update succeeded!");
                        Console.ReadLine(); // pause console
                        break;
                    default:
                        Console.WriteLine("Database NOT updated!");
                        Console.ReadLine();
                        break;
                }
            }
            else
            {
                Helper.WriteDataToSQL(itemDate, itemMonth, itemDay, itemYear, itemValue, itemCardType, itemCat, itemEssential, itemDesc);
                Console.WriteLine("Database update succeeded!");
            }
        }

        public static void ShowConfirmation(bool conf, ref string repeat)
        {
            // Insert another item?
            if (conf)
            {
                Console.Write("Upload another entry? [Hit ENTER to continue. Hit any other key to EXIT]");
                repeat = Console.ReadLine();
            }
        }
    }
}

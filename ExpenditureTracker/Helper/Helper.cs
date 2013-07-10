using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting; //sql commands

namespace ExpenditureTracker
{
    class Helper
    {
        #region SQL

        public static SqlConnection sqlconnect = null;

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Console.WriteLine("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public static void InitializeSQLServer()
        {
            //Note that the table "Expenditures must FIRST be MANUALLY created under Finance database.

            List<String> TableCols = new List<string>() { "Date", "Month", "Day", "Year", "USD", "CardType", "Category", "Essential", "Description", };

            // Create a SQL connection
            string myConnectString = "Persist Security Info=False;" +
                                     "Integrated Security=SSPI;" +
                                     "database=" + "Finance" + ";" +
                                     "server=" + "Elysium";
            sqlconnect = new SqlConnection(myConnectString);
            try
            {
                sqlconnect.Open();
            }
            catch (Exception e)
            {
                Assert.IsTrue(true, "Failed to create SQL connection:" + e.ToString());
            }

            SqlCommand sqlcmd = null;

            //Create the table columns if they don't exist in the table
            foreach (string table_col in TableCols)
            {
                string addColumns = "IF NOT EXISTS (" +
                    "SELECT * FROM INFORMATION_SCHEMA.COLUMNS " +
                    "WHERE TABLE_NAME = '" + "Expenditures" + "' " +
                    "AND COLUMN_NAME = '" + table_col + "') " +
                    "BEGIN " +
                    "ALTER TABLE dbo." + "Expenditures" + " " +
                    "ADD [" + table_col + "]"
                    + (table_col == "USD" ? " decimal(18, 2) " : " nvarchar(100) ") +
                    "END";

                sqlcmd = new SqlCommand(addColumns, sqlconnect);
                try
                {
                    sqlcmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Assert.IsTrue(false, "Failed to add table columns:" + e.ToString());
                }
            }
        }

        public static void CloseSQLConnection()
        {
            sqlconnect.Close();
        }

        public static void WriteDataToSQL(string Date, string Month, string Day, string Year, float USD, string CardType, string Category, string Essential, string Desc)
        {
            SqlCommand sqlcmd = null;

            //Update column ColName with the value ColValue
            string updateColumn = "INSERT INTO dbo." + "Expenditures" + " " +
                    "(Date, Month, Day, Year, USD, CardType, Category, Essential, Description) " +
                    "VALUES ('" + Date + "', '" + Month + "', '" + Day + "', '" + Year + "', '" + USD + "', '" + CardType + "', '" + Category + "', '" + Essential + "', '" + Desc + "') ";
            sqlcmd = new SqlCommand(updateColumn, sqlconnect);
            try
            {
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string error = e.ToString();
                Assert.IsTrue(false, "Test Failed: failed to update SQL table column. SQL query" + updateColumn + " Error msg:" + error);
            }
        }

        #endregion

        public static string VerifyString(string input)
        {
            if (input.Length != 2)
                input = ("0" + input);
            return input;
        }

    }
}

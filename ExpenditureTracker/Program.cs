using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ExpenditureTracker.Entities;
using System.Windows.Forms;

namespace ExpenditureTracker
{
    static class Program
    {
        static void Main()
        {
            // Initialize SQL Connection
            Helper.InitializeSQLServer();

            // Run Console App
            //ConsoleApp.Tracker Tracker = new ConsoleApp.Tracker();
            //Tracker.TrackerProgram();

            // Run Windows Form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WinFormTracker());
        }
    }
}

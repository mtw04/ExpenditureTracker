using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ExpenditureTracker.Entities;
using ExpenditureTracker.Method;

namespace ExpenditureTracker.ConsoleApp
{
    public class Tracker
    {
        #region Private

        private Settings inputSettings = new Settings();
        private TrackerAttributes trackerAttributes = new TrackerAttributes();

        #endregion

        #region Public

        // Constructor
        public Tracker()
        {
            this.inputSettings.SelectDate = Properties.Settings.Default.SelectDate;
            this.inputSettings.SelectYear = Properties.Settings.Default.SelectYear;
            this.inputSettings.SelectUpload = Properties.Settings.Default.SelectUpload;
            this.inputSettings.ViewConfirmation = Properties.Settings.Default.ViewConfirmation;

            this.trackerAttributes.PaymentTypeAtt = null;
            this.trackerAttributes.PaymentCategoryAtt = null;
            this.trackerAttributes.DayAtt = null;
            this.trackerAttributes.DateAtt = null;
            this.trackerAttributes.DescriptionAtt = null;
            this.trackerAttributes.EssentialAtt = null;
            this.trackerAttributes.MonthAtt = null;
            this.trackerAttributes.USDAtt = 0;
            this.trackerAttributes.YearAtt = null;
            this.trackerAttributes.DateNow = DateTime.Now;
        }

        public void TrackerProgram()
        {
            // Initialization
            string repeat = null;

            ///----------[ Header ]----------///
            ConsoleMethod.Header();

            do
            {
                ///----------[ Get Date ]----------///
                this.trackerAttributes.DayAtt = ConsoleMethod.GetDay(this.inputSettings.SelectDate, this.trackerAttributes.DayAtt, this.trackerAttributes.DateNow);
                this.trackerAttributes.MonthAtt = ConsoleMethod.GetMonth(this.inputSettings.SelectDate, this.trackerAttributes.DateNow);
                this.trackerAttributes.YearAtt = ConsoleMethod.GetYear(this.inputSettings.SelectDate, this.inputSettings.SelectYear, this.trackerAttributes.DateNow);
                this.trackerAttributes.DateAtt = ConsoleMethod.GetDate(this.trackerAttributes.DayAtt, this.trackerAttributes.MonthAtt, this.trackerAttributes.YearAtt);

                ///----------[ Get USD value ]----------///
                this.trackerAttributes.USDAtt = ConsoleMethod.GetUSD();

                ///----------[ Get Card type ]----------///
                this.trackerAttributes.PaymentTypeAtt = ConsoleMethod.GetCardType();

                ///----------[ Get Category ]----------///
                this.trackerAttributes.PaymentCategoryAtt = ConsoleMethod.GetCategory();

                ///----------[ Get Description ]----------///
                this.trackerAttributes.DescriptionAtt = ConsoleMethod.GetDescription();

                ///----------[ Get Essential ]----------///
                this.trackerAttributes.EssentialAtt = ConsoleMethod.GetEssential();

                ///----------[ Show Summary ]----------///
                ConsoleMethod.ShowSummary(this.trackerAttributes.DateAtt, this.trackerAttributes.USDAtt, this.trackerAttributes.PaymentTypeAtt, this.trackerAttributes.PaymentCategoryAtt, this.trackerAttributes.DescriptionAtt, this.trackerAttributes.EssentialAtt);

                ///----------[ Upload SQL ]----------///
                ConsoleMethod.UploadSQLConsole(this.inputSettings.SelectUpload, this.trackerAttributes.DateAtt, this.trackerAttributes.MonthAtt, this.trackerAttributes.DayAtt, this.trackerAttributes.YearAtt, this.trackerAttributes.USDAtt, this.trackerAttributes.PaymentTypeAtt, this.trackerAttributes.PaymentCategoryAtt, this.trackerAttributes.EssentialAtt, this.trackerAttributes.DescriptionAtt);

                ///----------[ Confirmation ]----------///
                ConsoleMethod.ShowConfirmation(this.inputSettings.ViewConfirmation, ref repeat);

            } while (string.IsNullOrEmpty(repeat));

        }

        #endregion

    }
}

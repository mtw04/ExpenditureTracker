using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ExpenditureTracker.Entities;

namespace ExpenditureTracker
{
    public partial class WinFormTracker : Form
    {
        #region Public

        public WinFormTracker()
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

            InitializeComponent(); // Initialize WinForm
        }

        #endregion

        #region Private

        private Settings inputSettings = new Settings();
        private TrackerAttributes trackerAttributes = new TrackerAttributes();

        private void MyWinForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripAbout_Click(object sender, EventArgs e)
        {
            var AboutDialog = new WinFormAbout();
            AboutDialog.ShowDialog();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                //MessageBox.Show("All controls are valid!");

                this.ExtractDate();
                this.ExtractUSD();
                this.ExtractPaymentType();
                this.ExtractPaymentCategory();
                this.ExtractDescription();
                this.ExtractEssential();

                Helper.WriteDataToSQL(this.trackerAttributes.DateAtt, this.trackerAttributes.MonthAtt, this.trackerAttributes.DayAtt, this.trackerAttributes.YearAtt, this.trackerAttributes.USDAtt, this.trackerAttributes.PaymentTypeAtt, this.trackerAttributes.PaymentCategoryAtt, this.trackerAttributes.EssentialAtt, this.trackerAttributes.DescriptionAtt);

                this.RefreshWindow();
            }
            else
            {
                MessageBox.Show("There are invalid controls on the form.");
            }
        }

        private void RefreshWindow()
        {
            this.FormClosed += (o, a) => new WinFormTracker().ShowDialog();
            this.Hide();
            this.Close();
        }

        #region Validation

        #region Validating

        // General Validated item
        private void ValidatingEmpty(object sender, CancelEventArgs e, Control control, string message)
        {
            bool cancel = false;

            if (control.Text == "")
            {
                cancel = true;
                this.errorProvider1.SetError(control, message);
            }
            else
            {
                this.ValidatedGeneral(control);
            }
            e.Cancel = cancel;
        }

        private void inputUSD_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            decimal number = -1;

            if (Decimal.TryParse(this.inputUSD.Text, out number))
            {
                if (number > 0)
                {
                    // This control passes validation
                    cancel = false;
                    this.inputUSD_Validated(sender, e);
                }
                else
                {
                    // This control has failed validation: number is not in valid range
                    cancel = true;
                    this.errorProvider1.SetError(this.inputUSD, "You must provide a valid number above 0!");
                }
            }
            else
            {
                // This control has failed validation: text box is not a number
                cancel = true;
                this.errorProvider1.SetError(this.inputUSD, "You must provide a valid number!");
            }
            e.Cancel = cancel;
        }

        private void inputPaymentType_Validating(object sender, CancelEventArgs e)
        {
            ValidatingEmpty(sender, e, this.inputPaymentType, "You must select a payment type!");
        }

        private void inputPaymentCategory_Validating(object sender, CancelEventArgs e)
        {
            ValidatingEmpty(sender, e, this.inputPaymentCategory, "You must select a payment category!");
        }

        private void inputDescription_Validating(object sender, CancelEventArgs e)
        {
            ValidatingEmpty(sender, e, this.inputDescription, "You must include a description!");
        }

        private void inputEssential_Validating(object sender, CancelEventArgs e)
        {
            ValidatingEmpty(sender, e, this.inputDescription, "You must specify if purchase is essential");
        }

        #endregion

        #region Validated

        // General Validated item
        private void ValidatedGeneral(Control control)
        {
            this.errorProvider1.SetError(control, string.Empty);
        }

        private void inputUSD_Validated(object sender, EventArgs e)
        {
            // Control has validated, clear any error message.
            ValidatedGeneral(this.inputUSD);
        }

        private void inputPaymentType_Validated(object sender, EventArgs e)
        {
            ValidatedGeneral(this.inputPaymentType);
        }

        private void inputPaymentCategory_Validated(object sender, EventArgs e)
        {
            ValidatedGeneral(this.inputPaymentCategory);
        }

        private void inputDescription_Validated(object sender, EventArgs e)
        {
            ValidatedGeneral(this.inputDescription);
        }

        private void inputEssential_Validated(object sender, EventArgs e)
        {
            ValidatedGeneral(this.inputEssential);
        }

        #endregion

        #endregion

        #region ExtractData

        private void ExtractDate()
        {
            DateTime inputDate = this.inputCalendar.SelectionRange.Start;
            
            this.trackerAttributes.DayAtt = this.ExtractDay(inputDate);
            this.trackerAttributes.MonthAtt = this.ExtractMonth(inputDate);
            this.trackerAttributes.YearAtt = this.ExtractYear(inputDate);
            this.trackerAttributes.DateAtt = Method.SharedMethod.GetDate(this.trackerAttributes.DayAtt, this.trackerAttributes.MonthAtt, this.trackerAttributes.YearAtt);
        }

        private string ExtractYear(DateTime inputDate)
        {
            return Method.SharedMethod.GetYear(inputDate);
        }

        private string ExtractMonth(DateTime inputDate)
        {
            return Method.SharedMethod.GetMonth(inputDate);
        }

        private string ExtractDay(DateTime inputDate)
        {
            return Method.SharedMethod.GetDay(inputDate);
        }

        private void ExtractUSD()
        {
            float itemValue;
            float.TryParse(this.inputUSD.Text, out itemValue);
            
            this.trackerAttributes.USDAtt = itemValue;
        }

        private void ExtractPaymentType()
        {
            this.trackerAttributes.PaymentTypeAtt = this.inputPaymentType.Text;
        }
        
        private void ExtractPaymentCategory()
        {
            this.trackerAttributes.PaymentCategoryAtt = this.inputPaymentCategory.Text;
        }

        private void ExtractDescription()
        {
            this.trackerAttributes.DescriptionAtt = this.inputDescription.Text;
        }

        private void ExtractEssential()
        {
            this.trackerAttributes.EssentialAtt = this.inputEssential.Text;
        }

        #endregion

        private void toolStripClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}

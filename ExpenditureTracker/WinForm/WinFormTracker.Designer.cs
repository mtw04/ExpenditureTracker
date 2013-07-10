using System;
using System.ComponentModel;
namespace ExpenditureTracker
{
    partial class WinFormTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inputUSD = new System.Windows.Forms.TextBox();
            this.labelUSD = new System.Windows.Forms.Label();
            this.labelPaymentType = new System.Windows.Forms.Label();
            this.inputPaymentType = new System.Windows.Forms.ComboBox();
            this.paymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPaymentCategory = new System.Windows.Forms.Label();
            this.inputPaymentCategory = new System.Windows.Forms.ComboBox();
            this.paymentCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputCalendar = new System.Windows.Forms.MonthCalendar();
            this.labelDescription = new System.Windows.Forms.Label();
            this.inputDescription = new System.Windows.Forms.TextBox();
            this.inputEssential = new System.Windows.Forms.ComboBox();
            this.labelEsssential = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripClose = new System.Windows.Forms.ToolStripButton();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentCategoryBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputUSD
            // 
            this.inputUSD.Location = new System.Drawing.Point(116, 34);
            this.inputUSD.Name = "inputUSD";
            this.inputUSD.Size = new System.Drawing.Size(121, 20);
            this.inputUSD.TabIndex = 0;
            this.inputUSD.Validating += new System.ComponentModel.CancelEventHandler(this.inputUSD_Validating);
            // 
            // labelUSD
            // 
            this.labelUSD.AutoSize = true;
            this.labelUSD.Location = new System.Drawing.Point(8, 37);
            this.labelUSD.Name = "labelUSD";
            this.labelUSD.Size = new System.Drawing.Size(51, 13);
            this.labelUSD.TabIndex = 12;
            this.labelUSD.Text = "USD ($): ";
            // 
            // labelPaymentType
            // 
            this.labelPaymentType.AutoSize = true;
            this.labelPaymentType.Location = new System.Drawing.Point(8, 63);
            this.labelPaymentType.Name = "labelPaymentType";
            this.labelPaymentType.Size = new System.Drawing.Size(78, 13);
            this.labelPaymentType.TabIndex = 11;
            this.labelPaymentType.Text = "Payment Type:";
            // 
            // inputPaymentType
            // 
            this.inputPaymentType.DataSource = Enum.GetValues(typeof(ExpenditureTracker.Entities.SelectionEnums.PaymentType));
            this.inputPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputPaymentType.FormattingEnabled = true;
            this.inputPaymentType.Location = new System.Drawing.Point(116, 60);
            this.inputPaymentType.Name = "inputPaymentType";
            this.inputPaymentType.Size = new System.Drawing.Size(121, 21);
            this.inputPaymentType.TabIndex = 1;
            this.inputPaymentType.Validating += new System.ComponentModel.CancelEventHandler(this.inputPaymentType_Validating);
            // 
            // labelPaymentCategory
            // 
            this.labelPaymentCategory.AutoSize = true;
            this.labelPaymentCategory.Location = new System.Drawing.Point(8, 90);
            this.labelPaymentCategory.Name = "labelPaymentCategory";
            this.labelPaymentCategory.Size = new System.Drawing.Size(96, 13);
            this.labelPaymentCategory.TabIndex = 10;
            this.labelPaymentCategory.Text = "Payment Category:";
            // 
            // inputPaymentCategory
            // 
            this.inputPaymentCategory.DataSource = Enum.GetValues(typeof(ExpenditureTracker.Entities.SelectionEnums.PaymentCategory));
            this.inputPaymentCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputPaymentCategory.FormattingEnabled = true;
            this.inputPaymentCategory.Location = new System.Drawing.Point(115, 87);
            this.inputPaymentCategory.Name = "inputPaymentCategory";
            this.inputPaymentCategory.Size = new System.Drawing.Size(121, 21);
            this.inputPaymentCategory.TabIndex = 2;
            this.inputPaymentCategory.Validating += new System.ComponentModel.CancelEventHandler(this.inputPaymentCategory_Validating);
            // 
            // inputCalendar
            // 
            this.inputCalendar.Location = new System.Drawing.Point(261, 29);
            this.inputCalendar.Name = "inputCalendar";
            this.inputCalendar.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(8, 117);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(66, 13);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Description: ";
            // 
            // inputDescription
            // 
            this.inputDescription.Location = new System.Drawing.Point(115, 114);
            this.inputDescription.Multiline = true;
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Size = new System.Drawing.Size(120, 50);
            this.inputDescription.TabIndex = 3;
            this.inputDescription.Validating += new System.ComponentModel.CancelEventHandler(this.inputDescription_Validating);
            // 
            // inputEssential
            // 
            this.inputEssential.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputEssential.FormattingEnabled = true;
            this.inputEssential.Items.AddRange(new object[] {
            "False",
            "True"});
            this.inputEssential.Location = new System.Drawing.Point(116, 170);
            this.inputEssential.Name = "inputEssential";
            this.inputEssential.Size = new System.Drawing.Size(121, 21);
            this.inputEssential.TabIndex = 4;
            this.inputEssential.Validating += new System.ComponentModel.CancelEventHandler(this.inputEssential_Validating);
            this.inputEssential.Text = "False";
            // 
            // labelEsssential
            // 
            this.labelEsssential.AutoSize = true;
            this.labelEsssential.Location = new System.Drawing.Point(8, 173);
            this.labelEsssential.Name = "labelEsssential";
            this.labelEsssential.Size = new System.Drawing.Size(55, 13);
            this.labelEsssential.TabIndex = 8;
            this.labelEsssential.Text = "Essential?";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAbout,
            this.toolStripClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(497, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripAbout
            // 
            this.toolStripAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Left;
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Size = new System.Drawing.Size(29, 22);
            this.toolStripAbout.Text = "About";
            this.toolStripAbout.ToolTipText = "About";
            this.toolStripAbout.Click += new System.EventHandler(this.toolStripAbout_Click);
            // 
            // toolStripClose
            // 
            this.toolStripClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Left;
            this.toolStripClose.Name = "toolStripClose";
            this.toolStripClose.Size = new System.Drawing.Size(44, 22);
            this.toolStripClose.Text = "Exit";
            this.toolStripClose.ToolTipText = "Exit Program";
            this.toolStripClose.Click += new System.EventHandler(this.toolStripClose_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 197);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(473, 23);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // WinFormTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(497, 225);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelEsssential);
            this.Controls.Add(this.inputEssential);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.inputCalendar);
            this.Controls.Add(this.inputPaymentCategory);
            this.Controls.Add(this.labelPaymentCategory);
            this.Controls.Add(this.inputPaymentType);
            this.Controls.Add(this.labelPaymentType);
            this.Controls.Add(this.labelUSD);
            this.Controls.Add(this.inputUSD);
            this.Name = "WinFormTracker";
            this.Text = "Expenditure Tracker";
            this.Load += new System.EventHandler(this.MyWinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentCategoryBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputUSD;
        private System.Windows.Forms.Label labelUSD;
        private System.Windows.Forms.Label labelPaymentType;
        private System.Windows.Forms.ComboBox inputPaymentType;
        private System.Windows.Forms.BindingSource paymentTypeBindingSource;
        private System.Windows.Forms.Label labelPaymentCategory;
        private System.Windows.Forms.ComboBox inputPaymentCategory;
        private System.Windows.Forms.BindingSource paymentCategoryBindingSource;
        private System.Windows.Forms.MonthCalendar inputCalendar;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox inputDescription;
        private System.Windows.Forms.ComboBox inputEssential;
        private System.Windows.Forms.Label labelEsssential;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripAbout;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton toolStripClose;
    }
}
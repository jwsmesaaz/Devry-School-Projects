namespace SmithWk7Lab
{
    partial class fmEmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.mtxtHourlyPay = new System.Windows.Forms.MaskedTextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtSocialSecurityNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.mtxtZip = new System.Windows.Forms.MaskedTextBox();
            this.HourlyPay = new System.Windows.Forms.Label();
            this.HoursWorked = new System.Windows.Forms.Label();
            this.mtxtHoursWorked = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxtTelephoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.grossPay = new System.Windows.Forms.Label();
            this.netPay = new System.Windows.Forms.Label();
            this.fedTaxWithheld = new System.Windows.Forms.Label();
            this.socialSecurityTax = new System.Windows.Forms.Label();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.txtFedTaxWithheld = new System.Windows.Forms.TextBox();
            this.txtSocialTaxWithheld = new System.Windows.Forms.TextBox();
            this.btnProcessEmployee = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowPaycheck = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbKnowsPasswords = new System.Windows.Forms.ComboBox();
            this.cbHasAPhone = new System.Windows.Forms.ComboBox();
            this.cbPhoneLines = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PrimaSans BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 38);
            this.label1.TabIndex = 78;
            this.label1.Text = "Employee Information";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(137, 134);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(267, 134);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(137, 210);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 5;
            this.txtStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(267, 210);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 6;
            this.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtHourlyPay
            // 
            this.mtxtHourlyPay.BeepOnError = true;
            this.mtxtHourlyPay.Location = new System.Drawing.Point(137, 285);
            this.mtxtHourlyPay.Mask = "000.00";
            this.mtxtHourlyPay.Name = "mtxtHourlyPay";
            this.mtxtHourlyPay.Size = new System.Drawing.Size(100, 20);
            this.mtxtHourlyPay.TabIndex = 9;
            this.mtxtHourlyPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(159, 101);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 79;
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(288, 101);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 80;
            this.LastName.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Social Security Number";
            // 
            // mtxtSocialSecurityNumber
            // 
            this.mtxtSocialSecurityNumber.Location = new System.Drawing.Point(397, 134);
            this.mtxtSocialSecurityNumber.Mask = "000-00-0000";
            this.mtxtSocialSecurityNumber.Name = "mtxtSocialSecurityNumber";
            this.mtxtSocialSecurityNumber.Size = new System.Drawing.Size(100, 20);
            this.mtxtSocialSecurityNumber.TabIndex = 3;
            this.mtxtSocialSecurityNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Hire Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Street";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "State";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "Zip";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(397, 282);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 20);
            this.dtpHireDate.TabIndex = 11;
            this.dtpHireDate.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "District of Columbia",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia ",
            "Virgin Islands ",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming "});
            this.cbState.Location = new System.Drawing.Point(397, 210);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(100, 21);
            this.cbState.TabIndex = 7;
            // 
            // mtxtZip
            // 
            this.mtxtZip.Location = new System.Drawing.Point(527, 210);
            this.mtxtZip.Mask = "00000";
            this.mtxtZip.Name = "mtxtZip";
            this.mtxtZip.Size = new System.Drawing.Size(100, 20);
            this.mtxtZip.TabIndex = 8;
            this.mtxtZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HourlyPay
            // 
            this.HourlyPay.AutoSize = true;
            this.HourlyPay.Location = new System.Drawing.Point(158, 254);
            this.HourlyPay.Name = "HourlyPay";
            this.HourlyPay.Size = new System.Drawing.Size(58, 13);
            this.HourlyPay.TabIndex = 89;
            this.HourlyPay.Text = "Hourly Pay";
            // 
            // HoursWorked
            // 
            this.HoursWorked.AutoSize = true;
            this.HoursWorked.Location = new System.Drawing.Point(279, 254);
            this.HoursWorked.Name = "HoursWorked";
            this.HoursWorked.Size = new System.Drawing.Size(76, 13);
            this.HoursWorked.TabIndex = 90;
            this.HoursWorked.Text = "Hours Worked";
            // 
            // mtxtHoursWorked
            // 
            this.mtxtHoursWorked.Location = new System.Drawing.Point(267, 285);
            this.mtxtHoursWorked.Mask = "00";
            this.mtxtHoursWorked.Name = "mtxtHoursWorked";
            this.mtxtHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.mtxtHoursWorked.TabIndex = 10;
            this.mtxtHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(528, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "Telephone Number";
            // 
            // mtxtTelephoneNumber
            // 
            this.mtxtTelephoneNumber.Location = new System.Drawing.Point(527, 134);
            this.mtxtTelephoneNumber.Mask = "(999) 000-0000";
            this.mtxtTelephoneNumber.Name = "mtxtTelephoneNumber";
            this.mtxtTelephoneNumber.Size = new System.Drawing.Size(100, 20);
            this.mtxtTelephoneNumber.TabIndex = 4;
            this.mtxtTelephoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grossPay
            // 
            this.grossPay.AutoSize = true;
            this.grossPay.Location = new System.Drawing.Point(160, 418);
            this.grossPay.Name = "grossPay";
            this.grossPay.Size = new System.Drawing.Size(55, 13);
            this.grossPay.TabIndex = 96;
            this.grossPay.Text = "Gross Pay";
            // 
            // netPay
            // 
            this.netPay.AutoSize = true;
            this.netPay.Location = new System.Drawing.Point(295, 418);
            this.netPay.Name = "netPay";
            this.netPay.Size = new System.Drawing.Size(45, 13);
            this.netPay.TabIndex = 97;
            this.netPay.Text = "Net Pay";
            // 
            // fedTaxWithheld
            // 
            this.fedTaxWithheld.AutoSize = true;
            this.fedTaxWithheld.Location = new System.Drawing.Point(416, 418);
            this.fedTaxWithheld.Name = "fedTaxWithheld";
            this.fedTaxWithheld.Size = new System.Drawing.Size(63, 13);
            this.fedTaxWithheld.TabIndex = 98;
            this.fedTaxWithheld.Text = "Federal Tax";
            // 
            // socialSecurityTax
            // 
            this.socialSecurityTax.AutoSize = true;
            this.socialSecurityTax.Location = new System.Drawing.Point(528, 418);
            this.socialSecurityTax.Name = "socialSecurityTax";
            this.socialSecurityTax.Size = new System.Drawing.Size(98, 13);
            this.socialSecurityTax.TabIndex = 99;
            this.socialSecurityTax.Text = "Social Security Tax";
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Location = new System.Drawing.Point(137, 449);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.ReadOnly = true;
            this.txtGrossPay.Size = new System.Drawing.Size(100, 20);
            this.txtGrossPay.TabIndex = 19;
            this.txtGrossPay.TabStop = false;
            // 
            // txtNetPay
            // 
            this.txtNetPay.Location = new System.Drawing.Point(267, 449);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.Size = new System.Drawing.Size(100, 20);
            this.txtNetPay.TabIndex = 20;
            this.txtNetPay.TabStop = false;
            // 
            // txtFedTaxWithheld
            // 
            this.txtFedTaxWithheld.Location = new System.Drawing.Point(397, 449);
            this.txtFedTaxWithheld.Name = "txtFedTaxWithheld";
            this.txtFedTaxWithheld.ReadOnly = true;
            this.txtFedTaxWithheld.Size = new System.Drawing.Size(100, 20);
            this.txtFedTaxWithheld.TabIndex = 21;
            this.txtFedTaxWithheld.TabStop = false;
            // 
            // txtSocialTaxWithheld
            // 
            this.txtSocialTaxWithheld.Location = new System.Drawing.Point(527, 449);
            this.txtSocialTaxWithheld.Name = "txtSocialTaxWithheld";
            this.txtSocialTaxWithheld.ReadOnly = true;
            this.txtSocialTaxWithheld.Size = new System.Drawing.Size(100, 20);
            this.txtSocialTaxWithheld.TabIndex = 22;
            this.txtSocialTaxWithheld.TabStop = false;
            // 
            // btnProcessEmployee
            // 
            this.btnProcessEmployee.Location = new System.Drawing.Point(137, 502);
            this.btnProcessEmployee.Name = "btnProcessEmployee";
            this.btnProcessEmployee.Size = new System.Drawing.Size(109, 23);
            this.btnProcessEmployee.TabIndex = 15;
            this.btnProcessEmployee.Text = "Process Employee";
            this.btnProcessEmployee.UseVisualStyleBackColor = true;
            this.btnProcessEmployee.Click += new System.EventHandler(this.btnProcessEmployee_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(280, 502);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(410, 502);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowPaycheck
            // 
            this.btnShowPaycheck.Location = new System.Drawing.Point(519, 502);
            this.btnShowPaycheck.Name = "btnShowPaycheck";
            this.btnShowPaycheck.Size = new System.Drawing.Size(109, 23);
            this.btnShowPaycheck.TabIndex = 18;
            this.btnShowPaycheck.Text = "Show Paycheck";
            this.btnShowPaycheck.UseVisualStyleBackColor = true;
            this.btnShowPaycheck.Visible = false;
            this.btnShowPaycheck.Click += new System.EventHandler(this.btnShowPaycheck_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 92;
            this.label10.Text = "Office Manager";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(283, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 94;
            this.label11.Text = "Has a Phone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(388, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 95;
            this.label12.Text = "Number of Phone Lines";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(141, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 93;
            this.label13.Text = "Knows Passwords";
            // 
            // cbKnowsPasswords
            // 
            this.cbKnowsPasswords.FormattingEnabled = true;
            this.cbKnowsPasswords.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbKnowsPasswords.Location = new System.Drawing.Point(137, 367);
            this.cbKnowsPasswords.Name = "cbKnowsPasswords";
            this.cbKnowsPasswords.Size = new System.Drawing.Size(100, 21);
            this.cbKnowsPasswords.TabIndex = 12;
            // 
            // cbHasAPhone
            // 
            this.cbHasAPhone.FormattingEnabled = true;
            this.cbHasAPhone.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbHasAPhone.Location = new System.Drawing.Point(267, 367);
            this.cbHasAPhone.Name = "cbHasAPhone";
            this.cbHasAPhone.Size = new System.Drawing.Size(100, 21);
            this.cbHasAPhone.TabIndex = 13;
            this.cbHasAPhone.SelectedIndexChanged += new System.EventHandler(this.cbHasAPhone_SelectedIndexChanged);
            // 
            // cbPhoneLines
            // 
            this.cbPhoneLines.DisplayMember = "(none)";
            this.cbPhoneLines.FormattingEnabled = true;
            this.cbPhoneLines.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbPhoneLines.Location = new System.Drawing.Point(397, 366);
            this.cbPhoneLines.Name = "cbPhoneLines";
            this.cbPhoneLines.Size = new System.Drawing.Size(100, 21);
            this.cbPhoneLines.TabIndex = 14;
            this.cbPhoneLines.Visible = false;
            // 
            // fmEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.cbPhoneLines);
            this.Controls.Add(this.cbHasAPhone);
            this.Controls.Add(this.cbKnowsPasswords);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnShowPaycheck);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcessEmployee);
            this.Controls.Add(this.txtSocialTaxWithheld);
            this.Controls.Add(this.txtFedTaxWithheld);
            this.Controls.Add(this.txtNetPay);
            this.Controls.Add(this.txtGrossPay);
            this.Controls.Add(this.socialSecurityTax);
            this.Controls.Add(this.fedTaxWithheld);
            this.Controls.Add(this.netPay);
            this.Controls.Add(this.grossPay);
            this.Controls.Add(this.mtxtTelephoneNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mtxtHoursWorked);
            this.Controls.Add(this.HoursWorked);
            this.Controls.Add(this.HourlyPay);
            this.Controls.Add(this.mtxtZip);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxtSocialSecurityNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.mtxtHourlyPay);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Name = "fmEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Information";
            this.Load += new System.EventHandler(this.fmEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.MaskedTextBox mtxtHourlyPay;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtSocialSecurityNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.MaskedTextBox mtxtZip;
        private System.Windows.Forms.Label HourlyPay;
        private System.Windows.Forms.Label HoursWorked;
        private System.Windows.Forms.MaskedTextBox mtxtHoursWorked;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtxtTelephoneNumber;
        private System.Windows.Forms.Label grossPay;
        private System.Windows.Forms.Label netPay;
        private System.Windows.Forms.Label fedTaxWithheld;
        private System.Windows.Forms.Label socialSecurityTax;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.TextBox txtFedTaxWithheld;
        private System.Windows.Forms.TextBox txtSocialTaxWithheld;
        private System.Windows.Forms.Button btnProcessEmployee;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowPaycheck;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbKnowsPasswords;
        private System.Windows.Forms.ComboBox cbHasAPhone;
        private System.Windows.Forms.ComboBox cbPhoneLines;
    }
}
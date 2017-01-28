namespace SmithWk6Lab
{
    partial class Form1
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
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.lbTotalHours = new System.Windows.Forms.Label();
            this.lbHourlyWage = new System.Windows.Forms.Label();
            this.lbGrossWages = new System.Windows.Forms.Label();
            this.lbFedTax = new System.Windows.Forms.Label();
            this.lbSSTax = new System.Windows.Forms.Label();
            this.lbNetPay = new System.Windows.Forms.Label();
            this.btnCalcWages = new System.Windows.Forms.Button();
            this.btnClearScreen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtGrossWages = new System.Windows.Forms.TextBox();
            this.txtFedTax = new System.Windows.Forms.TextBox();
            this.txtSSTax = new System.Windows.Forms.TextBox();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.txtTotalHours = new System.Windows.Forms.MaskedTextBox();
            this.txtHourlyWage = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Location = new System.Drawing.Point(12, 27);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(87, 13);
            this.lbEmployeeName.TabIndex = 0;
            this.lbEmployeeName.Text = "Employee Name:";
            // 
            // lbTotalHours
            // 
            this.lbTotalHours.AutoSize = true;
            this.lbTotalHours.Location = new System.Drawing.Point(12, 55);
            this.lbTotalHours.Name = "lbTotalHours";
            this.lbTotalHours.Size = new System.Drawing.Size(93, 13);
            this.lbTotalHours.TabIndex = 1;
            this.lbTotalHours.Text = "Enter Total Hours:";
            // 
            // lbHourlyWage
            // 
            this.lbHourlyWage.AutoSize = true;
            this.lbHourlyWage.Location = new System.Drawing.Point(12, 83);
            this.lbHourlyWage.Name = "lbHourlyWage";
            this.lbHourlyWage.Size = new System.Drawing.Size(72, 13);
            this.lbHourlyWage.TabIndex = 2;
            this.lbHourlyWage.Text = "Hourly Wage:";
            // 
            // lbGrossWages
            // 
            this.lbGrossWages.AutoSize = true;
            this.lbGrossWages.Location = new System.Drawing.Point(10, 179);
            this.lbGrossWages.Name = "lbGrossWages";
            this.lbGrossWages.Size = new System.Drawing.Size(71, 13);
            this.lbGrossWages.TabIndex = 3;
            this.lbGrossWages.Text = "Gross Wages";
            // 
            // lbFedTax
            // 
            this.lbFedTax.AutoSize = true;
            this.lbFedTax.Location = new System.Drawing.Point(110, 179);
            this.lbFedTax.Name = "lbFedTax";
            this.lbFedTax.Size = new System.Drawing.Size(63, 13);
            this.lbFedTax.TabIndex = 4;
            this.lbFedTax.Text = "Federal Tax";
            // 
            // lbSSTax
            // 
            this.lbSSTax.AutoSize = true;
            this.lbSSTax.Location = new System.Drawing.Point(216, 179);
            this.lbSSTax.Name = "lbSSTax";
            this.lbSSTax.Size = new System.Drawing.Size(42, 13);
            this.lbSSTax.TabIndex = 5;
            this.lbSSTax.Text = "SS Tax";
            // 
            // lbNetPay
            // 
            this.lbNetPay.AutoSize = true;
            this.lbNetPay.Location = new System.Drawing.Point(311, 179);
            this.lbNetPay.Name = "lbNetPay";
            this.lbNetPay.Size = new System.Drawing.Size(45, 13);
            this.lbNetPay.TabIndex = 6;
            this.lbNetPay.Text = "Net Pay";
            // 
            // btnCalcWages
            // 
            this.btnCalcWages.Location = new System.Drawing.Point(15, 130);
            this.btnCalcWages.Name = "btnCalcWages";
            this.btnCalcWages.Size = new System.Drawing.Size(75, 23);
            this.btnCalcWages.TabIndex = 7;
            this.btnCalcWages.Text = "Calc Wages";
            this.btnCalcWages.UseVisualStyleBackColor = true;
            this.btnCalcWages.Click += new System.EventHandler(this.btnCalcWages_Click);
            // 
            // btnClearScreen
            // 
            this.btnClearScreen.Location = new System.Drawing.Point(107, 130);
            this.btnClearScreen.Name = "btnClearScreen";
            this.btnClearScreen.Size = new System.Drawing.Size(75, 23);
            this.btnClearScreen.TabIndex = 8;
            this.btnClearScreen.Text = "Clear";
            this.btnClearScreen.UseVisualStyleBackColor = true;
            this.btnClearScreen.Click += new System.EventHandler(this.btnClearScreen_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(203, 130);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.AcceptsTab = true;
            this.txtEmployeeName.Location = new System.Drawing.Point(132, 24);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(93, 20);
            this.txtEmployeeName.TabIndex = 10;
            // 
            // txtGrossWages
            // 
            this.txtGrossWages.Location = new System.Drawing.Point(8, 214);
            this.txtGrossWages.Name = "txtGrossWages";
            this.txtGrossWages.ReadOnly = true;
            this.txtGrossWages.Size = new System.Drawing.Size(75, 20);
            this.txtGrossWages.TabIndex = 13;
            // 
            // txtFedTax
            // 
            this.txtFedTax.Location = new System.Drawing.Point(104, 214);
            this.txtFedTax.Name = "txtFedTax";
            this.txtFedTax.ReadOnly = true;
            this.txtFedTax.Size = new System.Drawing.Size(75, 20);
            this.txtFedTax.TabIndex = 14;
            // 
            // txtSSTax
            // 
            this.txtSSTax.Location = new System.Drawing.Point(200, 214);
            this.txtSSTax.Name = "txtSSTax";
            this.txtSSTax.ReadOnly = true;
            this.txtSSTax.Size = new System.Drawing.Size(75, 20);
            this.txtSSTax.TabIndex = 15;
            // 
            // txtNetPay
            // 
            this.txtNetPay.Location = new System.Drawing.Point(296, 214);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.Size = new System.Drawing.Size(75, 20);
            this.txtNetPay.TabIndex = 16;
            // 
            // txtTotalHours
            // 
            this.txtTotalHours.Location = new System.Drawing.Point(132, 52);
            this.txtTotalHours.Mask = "00";
            this.txtTotalHours.Name = "txtTotalHours";
            this.txtTotalHours.Size = new System.Drawing.Size(93, 20);
            this.txtTotalHours.TabIndex = 17;
            this.txtTotalHours.TabStop = false;
            // 
            // txtHourlyWage
            // 
            this.txtHourlyWage.Location = new System.Drawing.Point(132, 83);
            this.txtHourlyWage.Mask = "000";
            this.txtHourlyWage.Name = "txtHourlyWage";
            this.txtHourlyWage.Size = new System.Drawing.Size(93, 20);
            this.txtHourlyWage.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 264);
            this.Controls.Add(this.txtHourlyWage);
            this.Controls.Add(this.txtTotalHours);
            this.Controls.Add(this.txtNetPay);
            this.Controls.Add(this.txtSSTax);
            this.Controls.Add(this.txtFedTax);
            this.Controls.Add(this.txtGrossWages);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearScreen);
            this.Controls.Add(this.btnCalcWages);
            this.Controls.Add(this.lbNetPay);
            this.Controls.Add(this.lbSSTax);
            this.Controls.Add(this.lbFedTax);
            this.Controls.Add(this.lbGrossWages);
            this.Controls.Add(this.lbHourlyWage);
            this.Controls.Add(this.lbTotalHours);
            this.Controls.Add(this.lbEmployeeName);
            this.Name = "Form1";
            this.Text = "Weekly Pay Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Label lbTotalHours;
        private System.Windows.Forms.Label lbHourlyWage;
        private System.Windows.Forms.Label lbGrossWages;
        private System.Windows.Forms.Label lbFedTax;
        private System.Windows.Forms.Label lbSSTax;
        private System.Windows.Forms.Label lbNetPay;
        private System.Windows.Forms.Button btnCalcWages;
        private System.Windows.Forms.Button btnClearScreen;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtGrossWages;
        private System.Windows.Forms.TextBox txtFedTax;
        private System.Windows.Forms.TextBox txtSSTax;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.MaskedTextBox txtTotalHours;
        private System.Windows.Forms.MaskedTextBox txtHourlyWage;
    }
}


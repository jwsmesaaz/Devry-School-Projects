using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MortgageCalculator_Complete
{
	
	public class MortgageInformationInput : System.Windows.Forms.Form
	{
		#region "control creation"

		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button btnExit;
		internal System.Windows.Forms.GroupBox grpDefault;
		internal System.Windows.Forms.RadioButton radDefault2;
		internal System.Windows.Forms.RadioButton radDefault1;
		internal System.Windows.Forms.RadioButton radDefault0;
		internal System.Windows.Forms.GroupBox grpLoadInfo;
		internal System.Windows.Forms.Label lblAmount;
		internal System.Windows.Forms.Label lblPaymentAmount;
		internal System.Windows.Forms.TextBox txtMortgageTerm;
		internal System.Windows.Forms.TextBox txtInterestRate;
		internal System.Windows.Forms.TextBox txtMortgageAmount;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Button btnClear;
		internal System.Windows.Forms.Button btnCalculate;
		internal System.Windows.Forms.GroupBox grpAmortTable;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.RichTextBox rtfAmortTable;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label11;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.ComponentModel.IContainer components;
#endregion

		#region "constructors"

		public MortgageInformationInput()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Windows Form Designer generated code
	
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.grpDefault = new System.Windows.Forms.GroupBox();
			this.radDefault2 = new System.Windows.Forms.RadioButton();
			this.radDefault1 = new System.Windows.Forms.RadioButton();
			this.radDefault0 = new System.Windows.Forms.RadioButton();
			this.grpLoadInfo = new System.Windows.Forms.GroupBox();
			this.lblAmount = new System.Windows.Forms.Label();
			this.lblPaymentAmount = new System.Windows.Forms.Label();
			this.txtMortgageTerm = new System.Windows.Forms.TextBox();
			this.txtInterestRate = new System.Windows.Forms.TextBox();
			this.txtMortgageAmount = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.grpAmortTable = new System.Windows.Forms.GroupBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.rtfAmortTable = new System.Windows.Forms.RichTextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.grpDefault.SuspendLayout();
			this.grpLoadInfo.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.grpAmortTable.SuspendLayout();
			this.SuspendLayout();
			// 
			// Label1
			// 
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label1.Location = new System.Drawing.Point(8, 8);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(220, 20);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Mortgage Calculator";
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(8, 32);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(488, 34);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Fill in the Mortgage Amount, Annual Interest Rate, and Term of Loan in Years and " +
				"then click Calculate to display the monthly loan payment";
			// 
			// btnExit
			// 
			this.btnExit.CausesValidation = false;
			this.btnExit.Location = new System.Drawing.Point(520, 8);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(60, 20);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "Exit";
			this.toolTip1.SetToolTip(this.btnExit, "Click to exit the application");
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// grpDefault
			// 
			this.grpDefault.Controls.Add(this.radDefault2);
			this.grpDefault.Controls.Add(this.radDefault1);
			this.grpDefault.Controls.Add(this.radDefault0);
			this.grpDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grpDefault.Location = new System.Drawing.Point(8, 80);
			this.grpDefault.Name = "grpDefault";
			this.grpDefault.Size = new System.Drawing.Size(136, 160);
			this.grpDefault.TabIndex = 7;
			this.grpDefault.TabStop = false;
			this.grpDefault.Text = "Default Information";
			// 
			// radDefault2
			// 
			this.radDefault2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radDefault2.Location = new System.Drawing.Point(8, 90);
			this.radDefault2.Name = "radDefault2";
			this.radDefault2.Size = new System.Drawing.Size(120, 24);
			this.radDefault2.TabIndex = 2;
			this.radDefault2.Text = "RadioButton1";
			this.radDefault2.CheckedChanged += new System.EventHandler(this.radDefault2_CheckedChanged);
			// 
			// radDefault1
			// 
			this.radDefault1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radDefault1.Location = new System.Drawing.Point(8, 56);
			this.radDefault1.Name = "radDefault1";
			this.radDefault1.Size = new System.Drawing.Size(112, 24);
			this.radDefault1.TabIndex = 1;
			this.radDefault1.Text = "RadioButton1";
			this.radDefault1.CheckedChanged += new System.EventHandler(this.radDefault1_CheckedChanged);
			// 
			// radDefault0
			// 
			this.radDefault0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radDefault0.Location = new System.Drawing.Point(8, 24);
			this.radDefault0.Name = "radDefault0";
			this.radDefault0.Size = new System.Drawing.Size(112, 24);
			this.radDefault0.TabIndex = 0;
			this.radDefault0.Text = "RadioButton1";
			this.radDefault0.CheckedChanged += new System.EventHandler(this.radDefault0_CheckedChanged);
			// 
			// grpLoadInfo
			// 
			this.grpLoadInfo.Controls.Add(this.lblAmount);
			this.grpLoadInfo.Controls.Add(this.lblPaymentAmount);
			this.grpLoadInfo.Controls.Add(this.txtMortgageTerm);
			this.grpLoadInfo.Controls.Add(this.txtInterestRate);
			this.grpLoadInfo.Controls.Add(this.txtMortgageAmount);
			this.grpLoadInfo.Controls.Add(this.Label5);
			this.grpLoadInfo.Controls.Add(this.Label4);
			this.grpLoadInfo.Controls.Add(this.Label3);
			this.grpLoadInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grpLoadInfo.Location = new System.Drawing.Point(144, 80);
			this.grpLoadInfo.Name = "grpLoadInfo";
			this.grpLoadInfo.Size = new System.Drawing.Size(288, 160);
			this.grpLoadInfo.TabIndex = 8;
			this.grpLoadInfo.TabStop = false;
			this.grpLoadInfo.Text = "Loan Information";
			// 
			// lblAmount
			// 
			this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblAmount.Location = new System.Drawing.Point(192, 125);
			this.lblAmount.Name = "lblAmount";
			this.lblAmount.Size = new System.Drawing.Size(80, 21);
			this.lblAmount.TabIndex = 3;
			this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPaymentAmount
			// 
			this.lblPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblPaymentAmount.Location = new System.Drawing.Point(80, 125);
			this.lblPaymentAmount.Name = "lblPaymentAmount";
			this.lblPaymentAmount.Size = new System.Drawing.Size(100, 21);
			this.lblPaymentAmount.TabIndex = 8;
			this.lblPaymentAmount.Text = "Payment Amount:";
			this.lblPaymentAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtMortgageTerm
			// 
			this.txtMortgageTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtMortgageTerm.Location = new System.Drawing.Point(192, 90);
			this.txtMortgageTerm.MaxLength = 2;
			this.txtMortgageTerm.Name = "txtMortgageTerm";
			this.txtMortgageTerm.Size = new System.Drawing.Size(80, 20);
			this.txtMortgageTerm.TabIndex = 2;
			this.txtMortgageTerm.Tag = "Mortgage Term";
			this.txtMortgageTerm.Text = "";
			this.toolTip1.SetToolTip(this.txtMortgageTerm, "Enter a value greater than zero the total length of the mortgage loan in years");
			this.txtMortgageTerm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
			this.txtMortgageTerm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputField_KeyPress);
			// 
			// txtInterestRate
			// 
			this.txtInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtInterestRate.Location = new System.Drawing.Point(192, 56);
			this.txtInterestRate.MaxLength = 6;
			this.txtInterestRate.Name = "txtInterestRate";
			this.txtInterestRate.Size = new System.Drawing.Size(80, 20);
			this.txtInterestRate.TabIndex = 1;
			this.txtInterestRate.Tag = "Interest Rate";
			this.txtInterestRate.Text = "";
			this.toolTip1.SetToolTip(this.txtInterestRate, "Enter a percentage greater than or equal to zeor for the annual interest rate for" +
				" the loan");
			this.txtInterestRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
			this.txtInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputField_KeyPress);
			this.txtInterestRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtInterestRate_Validating);
			// 
			// txtMortgageAmount
			// 
			this.txtMortgageAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtMortgageAmount.Location = new System.Drawing.Point(192, 24);
			this.txtMortgageAmount.MaxLength = 10;
			this.txtMortgageAmount.Name = "txtMortgageAmount";
			this.txtMortgageAmount.Size = new System.Drawing.Size(80, 20);
			this.txtMortgageAmount.TabIndex = 0;
			this.txtMortgageAmount.Tag = "Mortgage Amount";
			this.txtMortgageAmount.Text = "";
			this.toolTip1.SetToolTip(this.txtMortgageAmount, "Enter a value greater than zero for total  amount of the mortgage loan");
			this.txtMortgageAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
			this.txtMortgageAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputField_KeyPress);
			this.txtMortgageAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtMortgageAmount_Validating);
			// 
			// Label5
			// 
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label5.Location = new System.Drawing.Point(80, 90);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(100, 21);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Mortgage Term:";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label4
			// 
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label4.Location = new System.Drawing.Point(8, 56);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(168, 21);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Annual Percentage Rate:";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label3
			// 
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label3.Location = new System.Drawing.Point(44, 24);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(136, 21);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Mortgage Amount:";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.btnClear);
			this.GroupBox1.Controls.Add(this.btnCalculate);
			this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.GroupBox1.Location = new System.Drawing.Point(440, 80);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(144, 160);
			this.GroupBox1.TabIndex = 9;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Mortgage Operations";
			// 
			// btnClear
			// 
			this.btnClear.CausesValidation = false;
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(31, 56);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(80, 20);
			this.btnClear.TabIndex = 1;
			this.btnClear.Text = "Clear";
			this.toolTip1.SetToolTip(this.btnClear, "Click to clear the input fields and the calculated mortgage amount");
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnCalculate
			// 
			this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnCalculate.Location = new System.Drawing.Point(31, 24);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(80, 20);
			this.btnCalculate.TabIndex = 0;
			this.btnCalculate.Text = "Calculate";
			this.toolTip1.SetToolTip(this.btnCalculate, "Click to calculate the mortgage amount");
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// grpAmortTable
			// 
			this.grpAmortTable.Controls.Add(this.Label6);
			this.grpAmortTable.Controls.Add(this.rtfAmortTable);
			this.grpAmortTable.Controls.Add(this.Label7);
			this.grpAmortTable.Controls.Add(this.Label8);
			this.grpAmortTable.Controls.Add(this.Label9);
			this.grpAmortTable.Controls.Add(this.Label10);
			this.grpAmortTable.Controls.Add(this.Label11);
			this.grpAmortTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grpAmortTable.Location = new System.Drawing.Point(8, 248);
			this.grpAmortTable.Name = "grpAmortTable";
			this.grpAmortTable.Size = new System.Drawing.Size(576, 416);
			this.grpAmortTable.TabIndex = 10;
			this.grpAmortTable.TabStop = false;
			this.grpAmortTable.Text = "Amortization Table";
			// 
			// Label6
			// 
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label6.Location = new System.Drawing.Point(2, 24);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(40, 16);
			this.Label6.TabIndex = 14;
			this.Label6.Text = "Period";
			// 
			// rtfAmortTable
			// 
			this.rtfAmortTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rtfAmortTable.Location = new System.Drawing.Point(0, 40);
			this.rtfAmortTable.Name = "rtfAmortTable";
			this.rtfAmortTable.ReadOnly = true;
			this.rtfAmortTable.Size = new System.Drawing.Size(568, 368);
			this.rtfAmortTable.TabIndex = 0;
			this.rtfAmortTable.TabStop = false;
			this.rtfAmortTable.Text = "";
			// 
			// Label7
			// 
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label7.Location = new System.Drawing.Point(64, 24);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(76, 16);
			this.Label7.TabIndex = 15;
			this.Label7.Text = "Loan Balance";
			// 
			// Label8
			// 
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label8.Location = new System.Drawing.Point(152, 24);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(96, 16);
			this.Label8.TabIndex = 16;
			this.Label8.Text = "Principal Balance";
			// 
			// Label9
			// 
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label9.Location = new System.Drawing.Point(264, 24);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(96, 16);
			this.Label9.TabIndex = 11;
			this.Label9.Text = "Interest Balance";
			// 
			// Label10
			// 
			this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label10.Location = new System.Drawing.Point(368, 24);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(80, 16);
			this.Label10.TabIndex = 12;
			this.Label10.Text = "Principal Paid";
			// 
			// Label11
			// 
			this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label11.Location = new System.Drawing.Point(456, 24);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(96, 16);
			this.Label11.TabIndex = 13;
			this.Label11.Text = "Interest Paid";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// MortgageInformationInput
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 670);
			this.Controls.Add(this.grpAmortTable);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.grpLoadInfo);
			this.Controls.Add(this.grpDefault);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Name = "MortgageInformationInput";
			this.Text = "Mortgage Calculator";
			this.Load += new System.EventHandler(this.MortgageInformationInput_Load);
			this.grpDefault.ResumeLayout(false);
			this.grpLoadInfo.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.grpAmortTable.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		
		[STAThread]
		static void Main() 
		{
			Application.Run(new MortgageInformationInput());
		}
		#region "Event Handling"

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			DialogResult response;
			string prompt;

			prompt = "Exit the Mortgage Calculator?";

			response = MessageBox.Show(this, prompt, 
									  "Exit Mortgage Calculator",
									   MessageBoxButtons.YesNo, 
									   MessageBoxIcon.Question);

			if(response == DialogResult.Yes)
			{
				this.Close();
			}
			else
			{
				txtMortgageAmount.Focus();
				txtMortgageAmount.SelectAll();
			}
		}
		private void btnCalculate_Click(object sender, System.EventArgs e)
		{
			findMortgagePayment();
		}
		private void btnClear_Click(object sender, System.EventArgs e)
		{
			clearFields();
		}
		#endregion

		#region "Data Processing"

		private void findMortgagePayment()
		{
			string prompt;
			bool validPV = false;
			bool validAPR = false;
			bool validTerm = false;
			double principal = 0.0;
			double apr = 0.0 ;
			int term = 0;
            
			try
			{
				//***********************************************************************
				//implement input validation and set local variables  here
				//***********************************************************************
				if (validPV && validAPR && validTerm)
				{
					//***********************************************************************
					//declare and create a new mortgage data object  
					//invoke this class's displayPayment method
					//invoke this class's displayAmoritizationTable method
					//***********************************************************************
				}
				else
				{
					lblAmount.Text = "";
					toolTip1.SetToolTip(lblAmount, "");
					toolTip1.SetToolTip(rtfAmortTable, "");
					if (!validPV)
					{
						setInputErrorField(txtMortgageAmount);
					}
					else if (!validAPR)
					{
						setInputErrorField(txtInterestRate);
					}
					else
					{
						setInputErrorField(txtMortgageTerm);
					}
				}
			}
			catch (Exception ex)
			{
				prompt = "Please re-enter the mortgage information and try again";
				InputUtilities.showErrorMessage(ex, prompt);
				clearFields();
			}

		}
		private void setInputErrorField(TextBox txtBox)
		{
			string prompt = "Please re-enter the " + txtBox.Tag + " information";
			InputUtilities.showErrorMessage(prompt, "Invalid " + txtBox.Tag);
			txtBox.Focus();
			txtBox.SelectAll();
		}
		private void displayPayment(MortgageData mortgage)
		{
			lblAmount.Text = String.Format("{0:c}", mortgage.Payment);
			toolTip1.SetToolTip(lblAmount, "Monthly payment is: " + lblAmount.Text);
		}
		private void displayAmoritizationTable(MortgageData mortgage)
		{
			string tableOutput = "";

			//***********************************************************************
			//create AmortizationTable here
			//retreive the Amoritization table
			//***********************************************************************

			rtfAmortTable.Text = tableOutput;
			toolTip1.SetToolTip(rtfAmortTable, "Amortization Table for " + mortgage.FullDataString);
		}


		#endregion

		#region "Form Setup"

		private void MortgageInformationInput_Load(object sender, System.EventArgs e)
		{
			SetDefaultMortgageInformation();
		}

		private void SetDefaultMortgageInformation()
		{
			string tlTip;
			
			//set principle value defaults and tool tips
			tlTip = "Set Principle value to a number greater than " + PredefinedMortgages.MIN_PV + " and less than or equal to " + PredefinedMortgages.MAX_PV;
			toolTip1.SetToolTip(txtMortgageAmount, tlTip);

			//set interest defaults and tool tips
			tlTip = "Set APR value to a number greater than or equal to " + PredefinedMortgages.MIN_APR + " and less than or equal to " + PredefinedMortgages.MAX_APR;
			toolTip1.SetToolTip(txtInterestRate, tlTip);

			//set term defaults and tool tips
			tlTip = "Set Term value to a number greater than " + PredefinedMortgages.MIN_TERM + " and less than or equal to " + PredefinedMortgages.MAX_TERM;
			toolTip1.SetToolTip(txtMortgageTerm, tlTip);

			radDefault0.Text = PredefinedMortgages.DefaultMortgageData[0].DataString;
			tlTip = "Select for loan = " + PredefinedMortgages.DefaultMortgageData[0].FullDataString;
			toolTip1.SetToolTip(radDefault0, tlTip);

			radDefault1.Text = PredefinedMortgages.DefaultMortgageData[1].DataString;
			tlTip = "Select for loan = " + PredefinedMortgages.DefaultMortgageData[1].FullDataString;
			toolTip1.SetToolTip(radDefault1, tlTip);

			radDefault2.Text = PredefinedMortgages.DefaultMortgageData[2].DataString;
			tlTip = "Select for loan = " + PredefinedMortgages.DefaultMortgageData[2].FullDataString;
			toolTip1.SetToolTip(radDefault2, tlTip);

			radDefault0.Checked = true;

		}
		#endregion

		#region "Field Utility Operations"
			
		private void clearFields()
		{
			try
			{
				txtMortgageAmount.Clear();
				txtInterestRate.Clear();
				txtMortgageTerm.Clear();
				rtfAmortTable.Clear();
				clearErrorProvider();

				clearPayment();
			}
			catch(System.Exception ex)
			{
				InputUtilities.showErrorMessage(ex, "Delete loan field information and try again");
			}
			finally
			{
				txtMortgageAmount.Focus();
			}
		}
		private void clearErrorProvider()
		{
			try
			{
				errorProvider1.SetError(txtMortgageAmount, "");
				errorProvider1.SetError(txtInterestRate, "");
				errorProvider1.SetError(txtMortgageTerm, "");
				errorProvider1.SetError(rtfAmortTable, "");
			}
			catch(System.Exception ex)
			{
				InputUtilities.clearException(ex);
			}
		}
		private void clearPayment()
		{
			lblAmount.Text = "";
			toolTip1.SetToolTip(lblAmount, "");
		}

		#endregion

		#region "Predefined Mortgage Operations"

		
		private void radDefault0_CheckedChanged(object sender, System.EventArgs e)
		{
			if (radDefault0.Checked)
			{
				setMortgageInformation(0);
			}
		}
		private void radDefault1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (radDefault1.Checked)
			{
				setMortgageInformation(1);
			}
		}

		private void radDefault2_CheckedChanged(object sender, System.EventArgs e)
		{
			if (radDefault2.Checked)
			{
				setMortgageInformation(2);
			}
		}

		private void setMortgageInformation(int selectedMortgage)
		{
			try
			{
				clearFields();
				if ((selectedMortgage >= PredefinedMortgages.FirstMortgageNumber) && (selectedMortgage <= PredefinedMortgages.LastMortgageNumber))
				{
					txtMortgageAmount.Text = PredefinedMortgages.DefaultMortgageData[selectedMortgage].Principal.ToString();
					txtInterestRate.Text = PredefinedMortgages.DefaultMortgageData[selectedMortgage].APR.ToString();
					txtMortgageTerm.Text = PredefinedMortgages.DefaultMortgageData[selectedMortgage].Term.ToString();
				}
				else
				{
					txtMortgageAmount.Text = PredefinedMortgages.DEFAULT_PV.ToString();
					txtInterestRate.Text = PredefinedMortgages.DEFAULT_PV.ToString();
					txtMortgageTerm.Text = PredefinedMortgages.DEFAULT_TERM.ToString();
				}
				clearErrorProvider();
			}
			catch(System.Exception  ex)
			{
				InputUtilities.showErrorMessage(ex, "Unable to set mortgage default mortgage information.");
			}
		}

		#endregion

		#region "Input Validation"

		private bool nonNumberEntered;

		private void txtMortgageAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = !validatePrincipalAmount();
		}

		private bool validatePrincipalAmount()
		{
			return validateInputField(txtMortgageAmount, PredefinedMortgages.MIN_PV, PredefinedMortgages.MAX_PV);
		}
		
		private void txtInterestRate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = !validateInterestRate();
		}
		private bool validateInterestRate()
		{
			return validateInputField(txtInterestRate, PredefinedMortgages.MIN_APR, PredefinedMortgages.MAX_APR);
		}

		private bool validateTerm()
		{
			return validateInputField(txtMortgageTerm, (double) PredefinedMortgages.MIN_TERM, (double) PredefinedMortgages.MAX_TERM);
		}

		private bool validateInputField(TextBox txtBox, double min, double max)
		{
			double val;
			string errorMessage;
			bool valid;

			errorMessage = "Enter a number greater than or equal to " + min
				+ " and less than or equal to " + max
				+ " in the " + txtBox.Tag;

			try
			{
				errorProvider1.SetError(txtBox, "");
				if (txtBox.Text == "")
				{
					errorProvider1.SetError(txtBox, errorMessage);
					valid = false;
				}
				else
				{
					val = Double.Parse(txtBox.Text);
					if (val < min || val > max)
					{
						errorProvider1.SetError(txtBox, errorMessage);
						valid = false;
					}
					else
					{
						errorProvider1.SetError(txtBox, "");
						valid = true;
					}
				}
			}
			catch(Exception ex)
			{
				InputUtilities.showErrorMessage(ex, errorMessage);
				valid = false;
				txtBox.SelectAll();
			}
			return valid;
		}

		private void txtInputField_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			//stop the character from being entered if not a navigation key or a number
			if (nonNumberEntered == true) 
			{
				e.Handled = true;
			}
		}

		private void txtInput_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			TextBox txtBox;
			//if a navigation key do not react
			try
			{
				txtBox = (TextBox)(sender);
				if (InputUtilities.isNavigationKey(e))
				{
					errorProvider1.SetError(txtBox, "");
					//allow navigation keys to be entered
					nonNumberEntered = false;
					e.Handled = false;
				}
				else if (InputUtilities.isNumericKey(e))
				{
					errorProvider1.SetError(txtBox, "");
					nonNumberEntered = false;
					e.Handled = false;
				}
				else
				{
					string errorMessage = "Please enter only numeric values for the " + txtBox.Tag;
					errorProvider1.SetError(txtBox, errorMessage);
					//stop value form being entered since it is non-numeric
					nonNumberEntered = true;
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				//do nothing, catch the error later before calculations are done
				InputUtilities.clearException(ex);
			}
		}
		#endregion

		
	}
}

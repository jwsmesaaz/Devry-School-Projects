using System;
using System.Text;

namespace MortgageCalculator_Complete
{
//
//********************************************************************
//Program Name:  Mortgage Calcuator
//Class Name:  Amortization Information
//Programmers Name: Tevis Boulware
//Date: 18 Apr 06
//
//Class Description:
//Class calculates each row of the amortization table and formats the table for output. 
//
//	'********************************************************************/
	
	public class AmortizationTable
	{
		private AmortizationData[] amortizationTable;
		private MortgageData mortgageInformation;

		public AmortizationTable(MortgageData mortInfo)
		{
			this.mortgageInformation = mortInfo;
		}
		public string getAmortizationTable()
		{
			StringBuilder table = new StringBuilder();
			bool valid;

			valid = calculateAmortizationTable();

			if (valid == true)
			{
				try
				{
					for(int count = 0; count <= amortizationTable.GetUpperBound(0); count++)
					{
						table.Append(amortizationTable[count].Period.ToString() + "\t");
						table.Append(amortizationTable[count].LoanBalance_Formatted + "\t");
						table.Append(amortizationTable[count].PrincipalBalance_Formatted + "\t");
						table.Append(amortizationTable[count].InterestBalance_Formatted + "\t");
						table.Append(amortizationTable[count].PrincipalPaid_Formatted + "\t");
						table.Append(amortizationTable[count].InterestPaid_Formatted + "\n");
					}
				}
				catch (Exception ex)
				{
					InputUtilities.showErrorMessage(ex, "Unable to create Amortization Table");
					table.Length = 0;
				}
			}
			return table.ToString();
		}

		private bool calculateAmortizationTable()
		{
			double principal = mortgageInformation.Principal;
			double intRate = mortgageInformation.APR / 12 / 100;
			int numPayments = mortgageInformation.Term * 12;
			double payment = mortgageInformation.Payment;

			double loanBalance = 0.0;
			double interestPaid = 0.0;
			double principalBalance = 0.0;
			double interestBalance = 0.0;
			double principalPaid = 0.0;
			double totalPaid = 0.0;
			double totalInterestPaid = 0.0;
			bool valid = false;

			try
			{
				//calculate total paid on the loan over the entire term of the loan
				totalPaid = numPayments * payment;

				//calculate total interest paid over the entire term of the loan
				totalInterestPaid = totalPaid - principal;

				//make room for the initial entries
				amortizationTable = new AmortizationData[numPayments+1];

				 //initialize the starting point of the array with the total values
				amortizationTable[0] = new AmortizationData(0, totalPaid, principal, totalInterestPaid, 0, 0);

				//initialized the Amortization Table to the initial loan values, so start counting at 1
				for(int count = 1; count <= amortizationTable.GetUpperBound(0); count++)
				{
					//calculate loan balance from previous loan balance and mortgage payment
					loanBalance = amortizationTable[count - 1].LoanBalance - payment;

					//interest payment is the product of the interest rate per period and the remaining balance
					//remaining balance is the previous periods Principal Balance
					interestPaid = intRate * amortizationTable[count - 1].PrincipalBalance;

					//calculate new principal balance from previous principle balance, payment, and interest paid
					principalBalance = amortizationTable[count - 1].PrincipalBalance - (payment - interestPaid);

					//calculate interest balance using previous interest balance and new interest payment
					interestBalance = amortizationTable[count - 1].InterestBalance - interestPaid;

					//Calculate principal paid using previous principle paid, payment, and interest paid
					principalPaid = amortizationTable[count - 1].PrincipalPaid + (payment - interestPaid);

					//Calculate total interest paid, using the previous total interest paid and current interest paid
					totalInterestPaid = amortizationTable[count - 1].InterestPaid + interestPaid;

					//'generate new data entry in the amortization table
					//period, loanBalance, principleBalance, interestBalance, principalPaid, interestPaid
					amortizationTable[count] = new AmortizationData(count, 
																	loanBalance, 
																	principalBalance, 
																	interestBalance, 
																	principalPaid, 
																	totalInterestPaid);
				}
				valid = true;
			}
			catch (Exception ex)
			{
				InputUtilities.showErrorMessage(ex, "Unable to create Amortization Table");
				valid = false;
			}
			return valid;
		}
	}
}

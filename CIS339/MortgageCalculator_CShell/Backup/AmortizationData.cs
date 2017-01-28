using System;

namespace MortgageCalculator_Complete
{
	//********************************************************************
	//Program Name:  Mortgage Calculator
	//Class Name:  AmortizationData
	//Programmers Name: Tevis Boulware
	//Date: 22 Apr 06
	//
	//Program Description:
	//Data structure to hold amortization data for the Amortization table
	//
	//********************************************************************/

	public class AmortizationData
	{
		private int mPeriod;
		private double mLoanBalance;
		private double mPrincipalBalance;
		private double mInterestBalance;
		private double mPrincipalPaid;
		private double mInterestPaid;

		public AmortizationData(int period,
								double loanBalance,
								double principalBalance,
								double interestBalance,
								double principalPaid,
								double interestPaid)
		{
			mPeriod = period;
			mLoanBalance = loanBalance;
			mPrincipalBalance = principalBalance;
			mInterestBalance = interestBalance;
			mPrincipalPaid = principalPaid;
			mInterestPaid = interestPaid;
		}
		public int Period
		{
			get
			{
				return mPeriod;
			}
		}
		public double LoanBalance
		{
			get
			{
				return mLoanBalance;
			}
		}
		public double PrincipalBalance
		{
			get
			{
				return mPrincipalBalance;
			}
		}
		public double InterestBalance
		{
			get
			{
				return mInterestBalance;
			}
		}
		public double PrincipalPaid
		{
			get
			{
				return mPrincipalPaid;
			}
		}
		public double InterestPaid
		{
			get
			{
				return mInterestPaid;
			}
		}
		public string LoanBalance_Formatted
		{
			get
			{
				return formatAttribute(LoanBalance);
			}
		}
		public string PrincipalBalance_Formatted
		{
			get
			{
				return formatAttribute(PrincipalBalance);
			}
		}
		public string InterestBalance_Formatted
		{
			get
			{
				return formatAttribute(InterestBalance);
			}
		}
		public string PrincipalPaid_Formatted
		{
			get
			{
				return formatAttribute(PrincipalPaid);
			}
		}
		public string InterestPaid_Formatted 
		{
			get
			{
				return formatAttribute(InterestPaid);
			}
		}
		private string formatAttribute(double attribute)
		{
			char padChar = ' ';
			String str = String.Format("{0:c}", attribute);
			return str.PadLeft(PredefinedMortgages.FLD_WIDTH, padChar);
		}
	}
}

using System;

namespace MortgageCalculator_Complete
{
//********************************************************************
//Program Name:  Mortgage Calculator
//Class Name: MortgageData
//Programmers Name: Tevis Boulware
//Date: 18 Apr 06
//
//Program Description:
//Data structure to hold the mortgage data, all validation is
//completed in other classes.  Calculates the mortgage monthy payment using the formula:
//
//	PMT = (PV x IR) / (1 – (1 + IR)^-NP)
//	where PV = Principle Value (amount of loan)
//	IR = Interest Rate, by month
//	NP = Note Period, or mortgage term in months
//********************************************************************/

	public class MortgageData
	{
		private int mID;
		private double mPrincipal;
		private double mAPR;
		private int mTerm;
		private double mPayment;

		public MortgageData()
		{
			//do nothing
		}
		public MortgageData(int id, double principal, double apr, int term)
		{
			this.ID = id;
			this.Principal = principal;
			this.APR = apr;
			this.Term = term;
		}
		public int ID
		{
			get
			{
				return mID;
			}
			set
			{
				mID = value;
			}
		}
		public double Principal
		{
			get
			{
				return mPrincipal;
			}
			set
			{
				if (value >= PredefinedMortgages.MIN_PV && value <= PredefinedMortgages.MAX_PV)
				{
					mPrincipal = value;
				}
				else
				{
					mPrincipal = PredefinedMortgages.DEFAULT_PV;
				}
			}
		}
		public double APR
		{
			get
			{
				return mAPR;
			}
			set
			{
				if (value >= PredefinedMortgages.MIN_APR && value <= PredefinedMortgages.MAX_APR)
				{
					mAPR = value;
				}
				else
				{
					mAPR = PredefinedMortgages.DEFAULT_APR;
				}
			}
		}
		public int Term
		{
			get
			{
				return mTerm;
			}
			set
			{
				if(value >= PredefinedMortgages.MIN_TERM && value <= PredefinedMortgages.MAX_TERM)
				{
					mTerm = value;
				}
				else
				{
					mTerm = PredefinedMortgages.DEFAULT_TERM;
				}
			}
		}
		public double Payment
		{
			get
			{
				calculateMortgagePayment();
				return mPayment;
			}
		}
		public string DataString
		{
			get
			{
				return Term + " years @ " + APR + "%";
			}
		}
		public string FullDataString
		{
			get
			{
				return string.Format("{0:c}, Term {1} years @ {2} %", Principal, Term, APR);
			}
		}
		private void calculateMortgagePayment()
		{
			double ir;
			int np;

			try
			{
				ir = APR/12/100;
				np = Term * 12;
				mPayment = (mPrincipal * ir)/(1 - Math.Pow(1 + ir, -np));
			}
			catch (System.InvalidOperationException ex)
			{
				InputUtilities.showErrorMessage(ex, "Unable to calculate mortgage payment");
			}
		}
	}
}

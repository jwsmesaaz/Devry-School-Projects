using System;

namespace MortgageCalculator_Complete
{
//**********************************************************************************
//Program Name:  Mortgage Calculator
//Class Name: PredefinedMortgages
//Programmers Name: Tevis Boulware
//Date: 18 Apr 06
//
//Class Description
//	Holds application default values for the mortgage information
//	and contains shared methods for the error messages
//	'************************************************************************************

	public class PredefinedMortgages
	{
		public const double DEFAULT_PV = 200000.0;
		public const double DEFAULT_APR = 5.35;
		public const int DEFAULT_TERM = 7;

		public const double MAX_PV = 1000000.0;
		public const double MIN_PV = 0.0;
		public const double MIN_APR = 0.0;
		public const double MAX_APR = 100.0;
		public const int MIN_TERM = 5;
		public const int MAX_TERM = 30;

		public const int FLD_WIDTH = 17;
		
		public static MortgageData[] DefaultMortgageData = {new MortgageData(0, DEFAULT_PV, 5.35, 7),
															new MortgageData(1, DEFAULT_PV, 5.5, 15),
															new MortgageData(2, DEFAULT_PV, 5.75, 30)};

		public static int FirstMortgageNumber
		{
			get
			{
				return DefaultMortgageData.GetLowerBound(0);
			}
		}
		public static int LastMortgageNumber
		{
			get
			{
				return DefaultMortgageData.GetUpperBound(0);
			}
		}

	}
}

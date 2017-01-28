using System;
using System.Windows.Forms;

namespace MortgageCalculator_Complete
{
	
	public class InputUtilities
	{
		public static void showErrorMessage(Exception ex, string messageAction)
		{
			MessageBox.Show(ex.Message + ". " + messageAction, 
				ex.Source, 
				MessageBoxButtons.OK, 
				MessageBoxIcon.Error);
		}
		public static void showErrorMessage(string messageAction, string errorTitle)
		{
			MessageBox.Show( messageAction, 
				errorTitle, 
				MessageBoxButtons.OK, 
				MessageBoxIcon.Error);
		}
		public static bool isNumericKey(System.Windows.Forms.KeyEventArgs e)
		{
			char ch;
			try
			{
				if (e.KeyValue >= 95 && e.KeyValue <= 105)
				{
					return true;
				}
				else if (e.KeyValue == 190 || e.KeyValue == 110)
				{
					//need decimal point
					return true;
				}
				else
				{
					ch = (char)e.KeyValue;
					return Char.IsDigit(ch);
				}
			}
			catch(System.Exception ex)
			{
				clearException(ex);
				return true;
			}
		}
		public static bool isNavigationKey(System.Windows.Forms.KeyEventArgs e)
		{
			bool isNavigation;
			try
			{
				switch(e.KeyCode)
				{ 
					case Keys.Left:
					case Keys.Right:
					case Keys.Up:
					case Keys.Down:
					case Keys.Delete:
					case Keys.Tab:
					case Keys.Back:
						isNavigation = true;
						break;
					default:
						isNavigation = false;
						break;
				}
				return isNavigation;
			}
			catch(System.Exception ex)
			{
				clearException(ex);
				isNavigation = false;
			}
			return isNavigation;
		}
		public static void clearException(System.Exception ex)
		{
			ex = null;
		}
	}
}

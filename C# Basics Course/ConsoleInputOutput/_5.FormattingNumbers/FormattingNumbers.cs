using System;

namespace _5.FormattingNumbers
{
	class FormattingNumbers
	{
		public static void Main ()
		{
			Console.WriteLine ("Enter digit between 0 <= digit <= 500!");
			int digit = int.Parse (Console.ReadLine ());

			while (0 > digit || digit > 500)
			{
				Console.WriteLine ("Please enter valid digit between 0 - 500!");
				digit = int.Parse (Console.ReadLine ());
			}

			string binaryDigit = Convert.ToString (digit, 2).PadLeft (10,'0');

			Console.WriteLine ("Enter floating-point number!");
			double realNumber = double.Parse (Console.ReadLine ());
			string realNumberString = (realNumber % 1 == 0) ? String.Format("{0,10}", realNumber) : String.Format("{0,10:F2}", realNumber);

			Console.WriteLine ("Enter second floating-point number!");
			double secondRealNumber = double.Parse (Console.ReadLine ());
			string secondRealNumberString = (secondRealNumber % 1 == 0) ? String.Format("{0,-10}", secondRealNumber) : String.Format("{0,-10:F3}", secondRealNumber);

			Console.WriteLine ("|{0,-10:X}|{1}|{2}|{3}|", digit, binaryDigit, realNumberString, secondRealNumberString);
		}
	}
}

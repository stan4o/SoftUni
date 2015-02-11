using System;

namespace _9.SumOfNNumbers
{
	class SumOfNNumbers
	{
		public static void Main ()
		{
			Console.WriteLine ("Enter a digit to represent the count of numbers!");
			try
			{
				int n = int.Parse (Console.ReadLine ());

				if (n % 1 != 0)
				{
					throw new Exception("Please insert integer (not a floating-point number)!");
				}

				Console.WriteLine ("Please enter {0} digits to be summated!", n);

				int i;
				double sum = 0;

				for (i = 0; i < n; i++)
				{
					sum += double.Parse (Console.ReadLine ());
				}

				Console.WriteLine ("The sum of numbers is " + sum);
			}
			catch (Exception ex)
			{
				Console.WriteLine (ex.Message);
			}
		}
	}
}

using System;

namespace _7.SumOfFiveNumbers
{
	class SumOfFiveNumbers
	{
		public static void Main ()
		{
			Console.WriteLine ("Enter 5 digits separated by space!");

			try {

				string input = Console.ReadLine ().Trim();
				string[] integers = input.Split (' ');
				int length = integers.Length;

				if (length < 5 || length > 5)
				{
					throw new Exception("Numbers must be 5 and separated by space character -> ' '!");
				}

				double result = 0;
				int i;

				for (i = 0; i < length; i++)
				{
					result += double.Parse (integers[i]);
				}

				Console.WriteLine ("\r\nThe result is: " + result);

			}
			catch (Exception ex)
			{
				Console.WriteLine (ex.Message);
			}
		}
	}
}

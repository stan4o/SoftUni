using System;

namespace _01.NumbersFromOneToN
{
	class NumbersFromOneToN
	{
		public static void Main()
		{
			Console.WriteLine("Write a number to count!");

			try
			{
				int number;
				bool isNumber = int.TryParse(Console.ReadLine(), out number);

				if (isNumber)
				{
					for (int i = 1; i <= number; i++)
					{
						Console.WriteLine (i);
					}
				}
				else
				{
					throw new FormatException("Please enter a integer!");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

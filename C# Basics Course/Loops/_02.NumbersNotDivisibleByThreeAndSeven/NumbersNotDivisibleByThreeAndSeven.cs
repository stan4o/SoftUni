using System;

namespace _02.NumbersNotDivisibleByThreeAndSeven
{
	class NumbersNotDivisibleByThreeAndSeven
	{
		public static void Main()
		{
			Console.WriteLine("Enter positive integer to count from!");

			try
			{
				int number = int.Parse(Console.ReadLine());

				Console.WriteLine (new String('-', 20));

				for (int i = 1; i <= number; i++)
				{
					if ((i % 3 != 0) && (i % 7 != 0))
					{
						Console.WriteLine (i);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

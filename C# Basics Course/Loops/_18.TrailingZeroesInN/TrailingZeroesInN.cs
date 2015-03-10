using System;

namespace _18.TrailingZeroesInN
{
	class TrailingZeroesInN
	{
		public static void Main()
		{
			Console.WriteLine("Enter value for N to calculate Factoriel of N!");

			try
			{
				int n = int.Parse(Console.ReadLine());
				int power = 1;
				int count = 0;

				while ((n / Math.Pow(5, power)) > 0)
				{
					count += (int)(n / Math.Pow(5, power));
					power++;
				}

				Console.WriteLine (count);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

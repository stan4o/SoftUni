using System;

namespace _05.CalculateFactorielOfNDividedByX
{
	class CalculateFactorielOfNDividedByX
	{
		public static void Main()
		{
			// 1 + 1!/X + 2!/X + ... + N!/X
			Console.Write("Enter value for N!");

			try
			{
				double numberN = double.Parse(Console.ReadLine());
				Console.Write("Enter value for X!");
				double numberX = double.Parse(Console.ReadLine());
				double sum = 1d;

				for (int i = 1; i <= numberN; i++)
				{
					double factoriel = 1d;

					for (int k = 1; k <= i; k++)
					{
						factoriel *= k;
					}

					sum += factoriel / Math.Pow(numberX, i);
				}

				Console.WriteLine ("{0:F5}", sum);

			}
			catch (Exception ex)
			{
				Console.WriteLine (ex.Message);
			}
		}
	}
}

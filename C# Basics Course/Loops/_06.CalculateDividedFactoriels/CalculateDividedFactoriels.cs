using System;

namespace _06.CalculateDividedFactoriels
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// n! / k! for given n and k (1 < k < n < 100)
			Console.WriteLine("Enter value for N!");

			try
			{
				int n = int.Parse(Console.ReadLine());
				Console.WriteLine ("Enter value for K!");
				int k = int.Parse(Console.ReadLine());
				int factorielOfN = 1;
				int factorielOfK = 1;

				if (n > 100 || k > 100)
				{
					throw new Exception("Values for N or K are bigger than 100! Please choose different integers!");
				}

				for (int i = 1; i <= n; i++)
				{
					factorielOfN *= i;
				}

				for (int j = 1; j <= k; j++)
				{
					factorielOfK *= j;
				}

				Console.WriteLine (factorielOfN / factorielOfK);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

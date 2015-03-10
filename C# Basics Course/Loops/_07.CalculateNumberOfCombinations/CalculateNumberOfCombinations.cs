using System;
using System.Numerics;

namespace _07.CalculateNumberOfCombinations
{
	class CalculateNumberOfCombinations
	{
		public static void Main()
		{
			// N! / (K! * (N-K)!)
			Console.WriteLine("Enter value for N!");

			try
			{
				int n = int.Parse(Console.ReadLine());
				Console.WriteLine ("Enter value for K!");
				int k = int.Parse(Console.ReadLine());
				BigInteger factorielOfN = 1; // N!
				BigInteger factorielOfK = 1; // K!
				BigInteger factorielOfNK = 1; // (N-K)!

				if (n > 100 || k > 100)
				{
					throw new Exception("Values of N or K are bigger than 100. Please choose another other values!");
				}
				else if (n < k)
				{
					throw new Exception("N must be bigger than K!");
				}

				for (int i = 1; i <= n; i++)
				{
					if (i <= k)
					{
						factorielOfK *= i;
					}

					if (i <= n)
					{
						factorielOfN *= i;
					}
				}

				for (int p = 1; p <= n-k; p++)
				{
					factorielOfNK *= p;
				}

				Console.WriteLine (factorielOfN / (factorielOfK * factorielOfNK));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

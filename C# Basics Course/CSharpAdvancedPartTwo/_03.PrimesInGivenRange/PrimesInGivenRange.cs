using System;
using System.Collections.Generic;

namespace _03.PrimesInGivenRange
{
	class PrimesInGivenRange
	{
		public static void Main()
		{
			Console.WriteLine("Enter value for lowest boundary!");

			try
			{
				int lowBoundary = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter value for highest boundary!");
				int highBoundary = int.Parse(Console.ReadLine());

				var resultList = FindPrimesInRange(lowBoundary, highBoundary);

				Console.WriteLine (PrintList(resultList));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		static bool IsPrime(int n)
		{
			if (n < 2)
			{
				return false;
			}

			bool prime = true;
			int divider = 2;
			int maxDivider = (int)Math.Sqrt(n);

			while (prime && (divider <= maxDivider))
			{
				if (n % divider == 0)
				{
					prime = false;
					break;
				}

				divider++;
			}

			return prime;
		}

		static List<int> FindPrimesInRange(int startNum, int endNum)
		{
			var listOfPrimes = new List<int>();

			for (int i = startNum; i <= endNum; i++)
			{
				if (IsPrime(i))
				{
					listOfPrimes.Add(i);
				}
			}

			return listOfPrimes;
		}

		static string PrintList(List<int> listOfNumbers)
		{
			return string.Join(", ", listOfNumbers);
		}
	}
}

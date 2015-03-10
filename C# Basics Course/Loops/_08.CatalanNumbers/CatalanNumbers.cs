using System;
using System.Numerics;

namespace _08.CatalanNumbers
{
	class CatalanNumbers
	{
		public static void Main()
		{
			// (2 * n)! / (n + 1)! * n!
			Console.WriteLine("Enter value for N!");

			try
			{
				int n = int.Parse(Console.ReadLine());
				BigInteger catalan = 0;
				BigInteger nByTwo = 1;
				BigInteger nPlusOne = 1;
				BigInteger factorielOnN = 1;

				if (n < 2 || 100 < n)
				{
					throw new Exception("N must be between 1 - 100!");
				}

				for (int a = 1; a <= n * 2; a++)
				{
					nByTwo *= a;
				}

				for (int b = 1; b <= n + 1; b++)
				{
					nPlusOne *= b;
				}

				for (int c = 1; c <= n; c++)
				{
					factorielOnN *= c;
				}

				catalan = nByTwo / (nPlusOne * factorielOnN);

				Console.WriteLine ("Catalan({0}): {1}", n, catalan);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

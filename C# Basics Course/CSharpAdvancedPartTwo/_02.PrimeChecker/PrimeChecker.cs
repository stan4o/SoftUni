using System;

namespace _02.PrimeChecker
{
	class PrimeChecker
	{
		public static void Main()
		{
			Console.WriteLine("Please enter value to check if it is a prime number!");

			try
			{
				ulong num = ulong.Parse(Console.ReadLine());
				bool isPrime = IsPrime(num);

				Console.WriteLine ("Is {0} prime? {1}", num, isPrime);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public static bool IsPrime(ulong n)
		{
			if (n < 2)
			{
				return false;
			}

			bool prime = true;
			ulong divider = 2;
			ulong maxDivider = (ulong)Math.Sqrt(n);

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
	}
}

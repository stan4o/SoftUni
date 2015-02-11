using System;

namespace _10.FibonacciNumbers
{
	class FibonacciNumbers
	{
		public static void Main ()
		{
			Console.WriteLine ("Enter 'n' number to check n members of a Fibonacci sequence!");
			try
			{
				int n = int.Parse (Console.ReadLine ());

				if (n % 1 != 0)
				{
					throw new Exception();
				}

				int a = 0, b = 1, c = 0;
				Console.Write ("\r\nFibonacci sequence of {0} numbers: {1} {2}", n, a, b);

				for (int i = 2; i < n; i++)
				{
					c = a + b;
					Console.Write (" {0}", c);
					a = b;
					b = c;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine (ex.Message);
			}
		}
	}
}

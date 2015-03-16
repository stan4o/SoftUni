using System;

namespace _01.FibonacciNumbers
{
	class FibonacciNumbers
	{
		public static void Main()
		{
			Console.WriteLine("Please enter value for N to check for the N-th Fibonacci number!");

			try
			{
				int num = int.Parse(Console.ReadLine());

				int result = Fib(num);

				Console.WriteLine ("{0}-th Fibonacci number is: {1}", num, result);
			}
			catch (Exception ex)
			{
				Console.WriteLine (ex.Message);
			}
		}

		static int Fib(int number)
		{
			int a = 0, b = 1, c = 0;

			if (number == 0 || number == 1)
			{
				return 1;
			}
			else
			{
				for (int i = 0; i < number; i++)
				{
					c = a + b;
					a = b;
					b = c;
				}

				return c;
			}
		}
	}
}

using System;

namespace _8.NumbersFromOneToN
{
	class NumbersFromOneToN
	{
		public static void Main ()
		{
			Console.WriteLine ("Enter integer from 1 <= n <= 300!"); // most consoles are with 300 lines of code

			try
			{
				int n = int.Parse (Console.ReadLine ());

				if (n <= 0 || 300 < n) {
					throw new Exception("Integer must be 1 <= n <= 300");
				}

				// Console.BufferHeight = n + 3;
				Console.WriteLine ("\r\nStarting:");

				for (int i = 1; i <= n; i++) {
					Console.WriteLine (i);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine (ex.Message);
			}
		}
	}
}

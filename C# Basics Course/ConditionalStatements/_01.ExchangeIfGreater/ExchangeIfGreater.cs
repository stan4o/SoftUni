using System;

namespace _01.ExchangeIfGreater
{
	class ExchangeIfGreater
	{
		public static void Main()
		{
			Console.WriteLine ("Write an integer for variable A!");
			try
			{
				double a = double.Parse (Console.ReadLine ());
				Console.WriteLine ("Write an integer for variable B!");
				double b = double.Parse (Console.ReadLine ());

				if (b > a)
				{
					double c = a;
					a = b;
					b = c;
				}

				Console.WriteLine ("A={0} B={1}", a, b);
			}
			catch (Exception ex)
			{
				Console.WriteLine (ex.Message);
			}
		}
	}
}

using System;

namespace _1.SumOfThreeNumbers
{
	class SumOfThreeNumbers
	{
		public static void Main ()
		{
			Console.WriteLine ("Enter first value");
			double firstValue = double.Parse (Console.ReadLine ());

			Console.WriteLine ("Enter second value");
			double secondValue = double.Parse (Console.ReadLine ());

			Console.WriteLine ("Enter third value");
			double thirdValue = double.Parse (Console.ReadLine ());

			Console.WriteLine ("Sum = {0}", firstValue + secondValue + thirdValue);
		}
	}
}

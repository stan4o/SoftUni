using System;

namespace _4.NumberComparer
{
	class NumberComparer
	{
		public static void Main ()
		{
			Console.WriteLine ("Enter first number!");
			double firstNumber = double.Parse (Console.ReadLine ());

			Console.WriteLine ("Enter second number!");
			double secondNumber = double.Parse (Console.ReadLine ());

			double greater = firstNumber > secondNumber ? firstNumber : secondNumber;
			Console.WriteLine ("The greater number is: {0}", greater);
		}
	}
}

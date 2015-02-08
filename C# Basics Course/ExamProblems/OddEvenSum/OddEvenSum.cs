using System;

namespace OddEvenSum
{
	class OddEvenSum
	{
		public static void Main ()
		{
			int n = int.Parse (Console.ReadLine ());
			int oddSum = 0;
			int evenSum = 0;
			bool odd = true;

			for (int i = 0; i < 2 * n; i++) {
				int currNum = int.Parse (Console.ReadLine ());

				if (odd) {
					oddSum += currNum;
				}
				else
				{
					evenSum += currNum;
				}

				odd = !odd;
			}

			if (oddSum == evenSum) {
				Console.WriteLine ("Yes, sum={0}", oddSum);
			}
			else
			{
				Console.WriteLine ("No, diff={0}", Math.Abs (oddSum - evenSum));
			}
		}
	}
}
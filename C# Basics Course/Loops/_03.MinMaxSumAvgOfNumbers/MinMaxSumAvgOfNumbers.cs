using System;

namespace _03.MinMaxSumAvgOfNumbers
{
	class MinMaxSumAvgOfNumbers
	{
		public static void Main()
		{
			Console.WriteLine("Enter length of sequence!");

			try
			{
				int length = int.Parse(Console.ReadLine());
				int min = int.MaxValue;
				int max = int.MinValue;
				double sum = 0d;
				double avg = 0d;

				for (int i = 1; i <= length; i++)
				{
					int currentNumber = int.Parse(Console.ReadLine());

					if (currentNumber > max)
					{
						max = currentNumber;
					}

					if (currentNumber < min)
					{
						min = currentNumber;
					}

					sum += currentNumber;

					avg = sum / i;
				}

				Console.WriteLine (new String('-', 20));
				Console.WriteLine ("Min=" + min);
				Console.WriteLine ("Max=" + max);
				Console.WriteLine ("Sum=" + sum);
				Console.WriteLine ("Avg={0:F2}", avg);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

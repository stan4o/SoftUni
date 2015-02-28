using System;

namespace SumOfElements
{
	class SumOfElements
	{
		public static void Main()
		{
			string input = Console.ReadLine();
			string[] arrayOfNumbers = input.Split(' ');
			int arrayLength = arrayOfNumbers.Length;
			long finalSum = 0;
			long biggestNumber = long.MinValue;

			for (int i = 0; i < arrayLength; i++)
			{
				long currentNumber = long.Parse(arrayOfNumbers[i]);
				finalSum += currentNumber;

				if (currentNumber > biggestNumber)
				{
					biggestNumber = currentNumber;
				}
			}

			if (biggestNumber * 2 == finalSum)
			{
				Console.WriteLine("Yes, sum=" + biggestNumber);
			}
			else
			{
				long difference = Math.Abs((biggestNumber * 2) - finalSum);
				Console.WriteLine("No, diff=" + difference);
			}
		}
	}
}
using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.CategorizeNumbers
{
	class MainClass
	{
		public static void Main()
		{
			Console.WriteLine("Enter a sequence of floating-point numbers separated by space!");

			string sequence = Console.ReadLine();

			double[] numbers = StringToArrayOfNumbers(sequence);
			var wholeNumbers = new List<double>();
			var doubleNumbers = new List<double>();

			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] == (int)numbers[i])
				{
					wholeNumbers.Add(numbers[i]);
				}
				else
				{
					doubleNumbers.Add(numbers[i]);
				}
			}

			Console.WriteLine("Result:");

			// Print double numbers
			PrintResult(doubleNumbers);

			Console.WriteLine();

			// Print whole numbers
			PrintResult(wholeNumbers);

		}

		public static void PrintArray(double[] arrayToPrint)
		{
			Console.Write("[" + string.Join(", ", arrayToPrint) + "]");
		}

		public static double[] StringToArrayOfNumbers(string input)
		{
			return input.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries)
						.Select(x => double.Parse(x))
						.ToArray();
		}

		public static void PrintResult(List<double> listToPrint)
		{
			PrintArray(listToPrint.ToArray());
			listToPrint.Sort();
			Console.WriteLine
			(
				" -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}",
				listToPrint[0],
				listToPrint[listToPrint.Count - 1],
				listToPrint.Sum(),
				(listToPrint.Sum() / listToPrint.Count)
			);
		}
	}
}

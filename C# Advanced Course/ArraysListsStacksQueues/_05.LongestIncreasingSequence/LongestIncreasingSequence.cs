using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.LongestIncreasingSequence
{
	class MainClass
	{
		public static void Main()
		{
			Console.WriteLine("Enter numbers separated be space!");

			int[] numbers = ConvertInput(Console.ReadLine());
			var sortedNumbers = FindSequences(numbers);
			int longestSequence = 0,
				longestSequenceIndex = 0;

			for (int i = 0; i < sortedNumbers.Count; i++)
			{
				PrintSequence(sortedNumbers[i]);

				if (sortedNumbers[i].Count > longestSequence)
				{
					longestSequence = sortedNumbers[i].Count;
					longestSequenceIndex = i;
				}
			}

			Console.Write("longest: ");
			PrintSequence(sortedNumbers[longestSequenceIndex]);

		}

		public static int[] ConvertInput(string input)
		{
			return input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
		}

		public static List<List<int>> FindSequences(int[] arrayOfNumbers)
		{
			int length = arrayOfNumbers.Length;
			var result = new List<List<int>>();
			var temp = new List<int>();
			temp.Add(arrayOfNumbers[0]);

			for (int i = 0; i < length - 1; i++)
			{
				if (arrayOfNumbers[i] < arrayOfNumbers[i+1])
				{
					temp.Add(arrayOfNumbers[i+1]);
				}
				else
				{
					result.Add(temp);
					temp = new List<int>();
					temp.Add(arrayOfNumbers[i+1]);
				}
			}

			result.Add(temp);

			return result;
		}

		public static void PrintSequence (List<int> listOfNumbers)
		{
			Console.WriteLine(string.Join(" ", listOfNumbers));
		}
	}
}

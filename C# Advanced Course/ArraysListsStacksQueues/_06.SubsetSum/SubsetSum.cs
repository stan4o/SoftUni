using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SubsetSum
{
	class MainClass
	{
		static int[] numbers;
		static int sum;
		static bool isFound = false;

		public static void Main()
		{
			//get the sum 
			Console.Write("Please enter value for sum: ");
			int.TryParse(Console.ReadLine(), out sum);

			//get the array
			Console.Write("Please enter sequence of numbers separated by space: ");
			numbers = ConvertInput(Console.ReadLine());

			//check for subsets matching the sum
			var subsets = FindAllSubsets(numbers);

			//print any matching subsets
			PrintCorrectSubsets(subsets);

			if (!isFound)
			{
				Console.WriteLine("No matching subsets.");
			}
		}

		public static int[] ConvertInput(string input)
		{
			return input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
		}

		private static IEnumerable<IEnumerable<int>> FindAllSubsets(int[] arr)
		{  
			List<int> noDuplicates = arr.ToList();
			noDuplicates = noDuplicates.Distinct().ToList();

			// generate subsets
			var subsets = from m in Enumerable.Range(0, 1 << noDuplicates.Count)
				select
				from i in Enumerable.Range(0, noDuplicates.Count)
					where (m & (1 << i)) != 0
				select noDuplicates[i];

			return subsets;
		}

		public static void PrintCorrectSubsets(IEnumerable<IEnumerable<int>> list)
		{
			foreach (var item in list)
			{
				int sumTemp = 0;
				foreach (var number in item)
				{
					sumTemp += Convert.ToInt32(number);
				}
				if (sumTemp == sum && item.Count() > 0)
				{
					Console.WriteLine(string.Join(" + ", item) + " = {0}", sum);
					isFound = true;
				}
			}
		}

	}
}

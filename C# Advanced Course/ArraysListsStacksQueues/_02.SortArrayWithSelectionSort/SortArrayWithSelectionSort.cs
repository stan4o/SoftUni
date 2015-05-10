using System;
using System.Linq;

namespace _02.SortArrayWithSelectionSort
{
	class MainClass
	{
		public static void Main()
		{
			try
			{
				Console.WriteLine ("Please enter a sequence of numbers to sort them");

				string sequence	= Console.ReadLine();

				int[] numbers = StringToArrayOfNumbers(sequence);

				// Sort with Selection Sort
				SelectionSort(numbers);

				// Print the array
				PrintArray(numbers);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public static void PrintArray(int[] arrayToPrint)
		{
			Console.WriteLine ("Result: " + string.Join(", ", arrayToPrint));
		}

		public static int[] StringToArrayOfNumbers(string input)
		{
			return input.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
		}

		public static int[] SelectionSort(int[] arrayToSort)
		{
			int length = arrayToSort.Length;

			for (int i = 0; i < length - 1; i++)
			{
				int min_key = i;

				for (int k = i + 1; k < length; k++)
				{
					if (arrayToSort[k] < arrayToSort[min_key])
					{
						min_key = k;
					}
				}

				int tmp = arrayToSort[min_key];
				arrayToSort[min_key] = arrayToSort[i];
				arrayToSort[i] = tmp;
			}

			return arrayToSort;
		}
	}
}

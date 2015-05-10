using System;
using System.Linq;

namespace SortArrayOfNumbers
{
	class MainClass
	{
		public static void Main()
		{
			try
			{
				Console.WriteLine ("Please enter a sequence of numbers to sort them");

				string sequence	= Console.ReadLine();

				int[] numbers = StringToArray(sequence);

				Array.Sort(numbers);

				PrintArray(numbers);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
		}

		public static void PrintArray(int[] arrayToPrint)
		{
			Console.WriteLine ("Result: " + string.Join(", ", arrayToPrint));
		}

		public static int[] StringToArray(string input)
		{
			return input.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
		}
	}
}

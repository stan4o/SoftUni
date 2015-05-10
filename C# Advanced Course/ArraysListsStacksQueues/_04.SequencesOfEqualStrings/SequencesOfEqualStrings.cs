using System;
using System.Collections.Generic;

namespace _04.SequencesOfEqualStrings
{
	class MainClass
	{
		public static void Main()
		{
			Console.WriteLine("Enter a sequence of strings separated by space!");

			string input = Console.ReadLine();

			string[] words = ArrayOfStrings(input);

			var sorted = SortStrings(words);

			PrintDictionary(sorted);


		}

		public static string[] ArrayOfStrings(string input)
		{
			return input.Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
		}

		public static Dictionary<string, int> SortStrings(string[] arrayOfStrings)
		{
			int length = arrayOfStrings.Length;
			var result = new Dictionary<string, int>();

			for (int i = 0; i < length; i++)
			{
				if (result.ContainsKey(arrayOfStrings[i]))
				{
					result[arrayOfStrings[i]]++;
				}
				else
				{
					result.Add(arrayOfStrings[i], 1);
				}
			}

			return result;
		}

		public static void PrintDictionary(Dictionary<string, int> dictionary)
		{
			foreach (var item in dictionary)
			{
				for (int i = 0; i < item.Value; i++)
				{
					Console.Write(item.Key + ' ');
				}

				Console.WriteLine();
			}
		}
	}
}

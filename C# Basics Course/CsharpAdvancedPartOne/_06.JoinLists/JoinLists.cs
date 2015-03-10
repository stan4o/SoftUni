using System;
using System.Collections.Generic;

namespace _06.JoinLists
{
	class JoinLists
	{
		public static void Main()
		{
			Console.WriteLine("Enter first list of numbers!");

			try
			{
				var setOfNumbers = new HashSet<int>(); // use HashSet so that no repeated number will be added

				for (int i = 0; i < 2; i++)
				{
					string[] numbersAsString = Console.ReadLine().Split(' ');

					for (int j = 0; j < numbersAsString.Length; j++)
					{
						setOfNumbers.Add(int.Parse(Convert.ToString(numbersAsString[j])));
					}
				}

				var arrayOfNumbers = new int[setOfNumbers.Count]; // create array to hold the set
				setOfNumbers.CopyTo(arrayOfNumbers); // copy the set to the new array
				Array.Sort(arrayOfNumbers); // sort the new array of numbers

				Console.WriteLine (string.Join(" ", arrayOfNumbers));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

using System;
using System.Collections.Generic;

namespace _02.LongestAreaInArray
{
	class LongestAreaInArray
	{
		public static void Main()
		{
			Console.WriteLine("Enter length of sequence!");

			try
			{
				int n = int.Parse(Console.ReadLine());
				var listOfStrings = new List<string>();
				string resultString = "";
				int counter = 1;
				int biggest = 0;

				for (int i = 0; i < n; i++)
				{
					string currString = Console.ReadLine();

					if (listOfStrings.Contains(currString))
					{
						counter++;
					}
					else
					{
						counter = 1;
						listOfStrings.Add(currString);
					}

					if (counter > biggest)
					{
						biggest = counter;
						resultString = currString;
					}
				}

				Console.WriteLine (biggest);
				for (int j = 0; j < biggest; j++)
				{
					Console.WriteLine (resultString);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

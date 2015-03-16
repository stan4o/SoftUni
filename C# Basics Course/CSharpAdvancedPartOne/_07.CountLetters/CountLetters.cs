using System;
using System.Collections.Generic;

namespace _07.CountLetters
{
	class CountLetters
	{
		public static void Main()
		{
			Console.WriteLine("Enter a sequence of letters to count them!");

			try
			{
				string[] input = Console.ReadLine().Split(' ');
				var characters = new Dictionary<char, int>();

				Array.Sort(input);

				for (int i = 0; i < input.Length; i++)
				{
					char currentChar = Convert.ToChar(input[i]);
					if (characters.ContainsKey(currentChar))
					{
						characters[currentChar]++;
					}
					else
					{
						characters.Add(currentChar, 1);
					}
				}

				foreach (var ch in characters)
				{
					Console.WriteLine ("{0} -> {1}", ch.Key, ch.Value);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

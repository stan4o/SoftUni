using System;

namespace _10.LongestWordInText
{
	class LongestWordInText
	{
		public static void Main()
		{
			Console.WriteLine("Enter text to check for the longest word!");

			try
			{
				string input = Console.ReadLine();
				string[] words = input.Split
				(
					new string[] {" ", ", ", ".", "!", "?", "/", "'", "\"", ":", ";", "-", "(", ")"},
					StringSplitOptions.RemoveEmptyEntries
				);

				int biggestLength = 0;
				string biggestWord = "";

				foreach (var word in words)
				{
					int currentWordLength = word.Length;
					if (currentWordLength > biggestLength)
					{
						biggestLength = currentWordLength;
						biggestWord = word;
					}
				}

				Console.WriteLine ("Biggest word in the text is: " + biggestWord);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
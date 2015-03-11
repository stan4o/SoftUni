using System;

namespace _12.CountingWordInText
{
	class CountingWordInText
	{
		public static void Main()
		{
			Console.WriteLine("Enter a word to find her occurrences!");

			try
			{
				string wordToSearch = Console.ReadLine();
				string textToSearchIn = Console.ReadLine();
				int counter = 0;
				string[] words = textToSearchIn.Split
					(
						// there are more characters to add
						new char[]{' ', ',', '\'', '"', '“', '”', '.', '!', '?', '/', '\\', ';', '|', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+'},
						StringSplitOptions.RemoveEmptyEntries
					);

				foreach (var word in words)
				{
					// Case insensitive search -> use of ToLower() method
					if (wordToSearch.ToLower() == word.ToLower())
					{
						counter++;
					}
				}

				char plural = (counter == 1) ? ' ' : 's';

				Console.WriteLine (Environment.NewLine + "Occurrences of the word \"{0}\": {1} time{2}", wordToSearch, counter, plural);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

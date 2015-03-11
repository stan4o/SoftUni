using System;
using System.Collections.Generic;

namespace _11.ExtractURLsFromText
{
	class ExtractURLsFromText
	{
		public static void Main()
		{
			Console.WriteLine("Enter text from which to extract URL's!");

			try
			{
				string input = Console.ReadLine();
				var urlSet = new HashSet<string>();

				string[] words = input.Split
					(
						new string[] {" ", ", ", "!", "?", "'", "\"",";", "(", ")"},
						StringSplitOptions.RemoveEmptyEntries
					);

				foreach (var word in words)
				{
					if (word.Contains("www.") || word.Contains("http://"))
					{
						urlSet.Add
						(
							word.
							TrimStart('.').
							TrimEnd('.')
						);
					}
				}

				Console.WriteLine ("URL's: \r\n{0}", string.Join("\r\n", urlSet));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

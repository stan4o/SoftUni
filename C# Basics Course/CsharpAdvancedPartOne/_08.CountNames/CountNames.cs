using System;
using System.Collections.Generic;

namespace _08.CountNames
{
	class CountNames
	{
		public static void Main()
		{
			Console.WriteLine("Enter a sequence of names to count them!");

			try
			{
				string[] input = Console.ReadLine().Split(' ');
				var names = new Dictionary<string, int>();

				Array.Sort(input);

				foreach (var currentName in input)
				{
					if (names.ContainsKey(currentName))
					{
						names[currentName]++;
					}
					else
					{
						names.Add(currentName, 1);
					}
				}

				foreach (var name in names)
				{
					Console.WriteLine ("{0} -> {1}", name.Key, name.Value);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

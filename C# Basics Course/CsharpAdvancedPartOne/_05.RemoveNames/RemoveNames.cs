using System;
using System.Collections.Generic;

namespace _05.RemoveNames
{
	class RemoveNames
	{
		public static void Main()
		{
			Console.WriteLine("Enter list of names separated by space!");

			try
			{
				string[] arrayOfNames = Console.ReadLine().Split(' ');
				var firstList = new List<string>();

				foreach (var name in arrayOfNames)
				{
					firstList.Add(name);
				}

				Console.WriteLine ("Enter a list of names to remove from the original list");

				string[] namesToRemove = Console.ReadLine().Split(' ');

				for (int i = 0; i < firstList.Count; i++)
				{
					for (int j = 0; j < namesToRemove.Length; j++)
					{
						if (firstList.Contains(namesToRemove[j]))
						{
							firstList.Remove(namesToRemove[j]);
						}
					}
				}

				Console.WriteLine (string.Join(" ", firstList));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

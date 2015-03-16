using System;
using System.Collections.Generic;

namespace _09.AverageLoadTimeCalculator
{
	class AverageLoadTimeCalculator
	{
		public static void Main()
		{
			Console.WriteLine("Enter load time reports! If you want to stop just hit enter!");

			try
			{
				string input = "";
				var loadTimeSet = new Dictionary<string, double[]>();

				while (true)
				{
					if ((input = Console.ReadLine()) != "")
					{
						string[] currentLoadTimeString = input.Split(' ');

						if (loadTimeSet.ContainsKey(currentLoadTimeString[2]))
						{

							loadTimeSet[currentLoadTimeString[2]][0] += double.Parse(currentLoadTimeString[3]);
							loadTimeSet[currentLoadTimeString[2]][1]++;
						}
						else
						{
							loadTimeSet.Add
							(
								currentLoadTimeString[2],
								new double[]{double.Parse(currentLoadTimeString[3]), 1d}
							);
						}
					}
					else
					{
						break;
					}
				}

				foreach (var loadTime in loadTimeSet)
				{
					string siteName = loadTime.Key;
					double avgLoadTime = loadTime.Value[0] / loadTime.Value[1];

					Console.WriteLine (siteName + " -> " + avgLoadTime);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

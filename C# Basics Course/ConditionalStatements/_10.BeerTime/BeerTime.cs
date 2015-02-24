using System;

namespace _10.BeerTime
{
	class BeerTime
	{
		public static void Main()
		{
			Console.WriteLine("Enter a time in the following format [hh:mm tt] -> 12:59 AM / PM!");
			Console.WriteLine("Beer time: from 01:00 PM till 03:00 AM!");

			try
			{
				DateTime dt = DateTime.Parse(Console.ReadLine());
				string designator = dt.ToString("tt").ToLower();
				DateTime beerTimePMStart = DateTime.Parse("1:00 PM");
				DateTime beerTimePMEnd = DateTime.Parse("11:59 PM");
				DateTime beerTimeAMStart = DateTime.Parse("00:00 AM");
				DateTime beerTimeAMEnd = DateTime.Parse("3:00 AM");
				string outputString = "non-beer time";

				if (designator == "am")
				{
					if (beerTimeAMStart <= dt && dt < beerTimeAMEnd)
					{
						outputString = "beer time";
					}
				}
				else
				{
					if (beerTimePMStart <= dt && dt <= beerTimePMEnd)
					{
						outputString = "beer time";
					}
				}

				Console.WriteLine (outputString);
			}
			catch (Exception)
			{
				Console.WriteLine("invalid time");
			}
		}
	}
}

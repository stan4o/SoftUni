using System;

namespace Volleyball
{
	class Volleyball
	{
		public static void Main ()
		{
			int weekends = 48;
			double plays = 0d;
			string year = Console.ReadLine ();
			double holidayPlays = double.Parse(Console.ReadLine ()) * (2d / 3d);
			int hometownPlays = int.Parse (Console.ReadLine ());
			double normalPlays = (weekends - hometownPlays) * (3d / 4d);

			plays = holidayPlays + hometownPlays + normalPlays;

			if (year == "leap") {
				plays += plays * (15d / 100d);
			}

			Console.WriteLine ((int) plays);
		}
	}
}
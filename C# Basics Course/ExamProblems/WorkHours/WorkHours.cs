using System;

namespace WorkHours
{
	class MainClass
	{
		public static void Main()
		{
			int requiredWorkHours = int.Parse(Console.ReadLine());
			double projectDays = double.Parse(Console.ReadLine());
			double productivity = double.Parse(Console.ReadLine()) / 100d;
			double workHours = 12d;
			double workingTime = 90d / 100d;
			int efficientHours = (int)(projectDays * workingTime * workHours * productivity);
			int difference = efficientHours - requiredWorkHours;

			if (difference < 0)
			{
				Console.WriteLine("No");
			}
			else
			{
				Console.WriteLine("Yes");
			}

			Console.WriteLine(difference);

		}
	}
}

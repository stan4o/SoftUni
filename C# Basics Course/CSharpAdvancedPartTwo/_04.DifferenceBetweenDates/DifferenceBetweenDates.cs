using System;

namespace _04.DifferenceBetweenDates
{
	class DifferenceBetweenDates
	{
		public static void Main()
		{
			Console.WriteLine("Please enter first date! Expected input dd.MM.yyyy!");

			try
			{
				string firstDateString = Console.ReadLine();
				var startDate = GetDate(firstDateString, '.');

				Console.WriteLine ("Please enter second date!");

				string secondDateString = Console.ReadLine();
				var endDate = GetDate(secondDateString, '.');

				Console.WriteLine ("Difference: " + (endDate - startDate).TotalDays);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		static DateTime GetDate(string dateString, char separator)
		{
			string[] dateArray = dateString.Split(separator);

			int year = int.Parse(dateArray[2]);
			int month = int.Parse(dateArray[1]);
			int day = int.Parse(dateArray[0]);

			var date = new DateTime(year, month, day);

			return date;
		}
	}
}

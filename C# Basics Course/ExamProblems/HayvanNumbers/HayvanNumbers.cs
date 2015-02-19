using System;

namespace HayvanNumbers
{
	class HayvanNumbers
	{
		public static void Main()
		{
			int sum = int.Parse(Console.ReadLine());
			int diff = int.Parse(Console.ReadLine());
			bool foundNumber = false;


			for (int i = 555; i <= 999; i++)
			{
				int abc = i;
				int def = abc + diff;
				int ghi = def + diff;

				if (ghi > 999)
				{
					continue; 
				}

				string currNum = "" + abc + def + ghi;

				if (currNum.Contains("0") || currNum.Contains("1") || currNum.Contains("2") || currNum.Contains("3") || currNum.Contains("4"))
				{
					continue;
				}

				int currNumSum = 0;

				for (int j = 0; j < currNum.Length; j++)
				{
					currNumSum += Convert.ToInt32(Convert.ToString(currNum[j]));
				}

				if (currNumSum == sum)
				{
					Console.WriteLine(currNum);
					foundNumber = true;
				}
			}

			if (!foundNumber)
			{
				Console.WriteLine("No");
			}
		}
	}
}

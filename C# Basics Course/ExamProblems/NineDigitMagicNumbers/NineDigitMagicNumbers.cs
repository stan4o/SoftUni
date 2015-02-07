using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int resultsCount = 0;

        for (int abc = 111; abc <= 777; abc++)
        {
            int def = abc + diff;
            int ghi = def + diff;

            if (ghi <= 777 && isAllowed(abc) && isAllowed(def) && isAllowed(ghi) && (CalculateSum(abc) + CalculateSum(def) + CalculateSum(ghi) == sum))
            {
                Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                resultsCount++;
            }
        }

        if (resultsCount == 0)
        {
            Console.WriteLine("No");
        }

    }

    private static bool isAllowed(int num)
    {
        string digits = num.ToString();

        foreach (var digit in digits)
        {
            if (digit < '1' || digit > '7')
            {
                return false;
            }
        }

        return true;
    }

    private static int CalculateSum(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }

        return sum;
    }
}
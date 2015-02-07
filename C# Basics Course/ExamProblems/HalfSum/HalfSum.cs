using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;

        // first n sequence
        for (int i = 0; i < n; i++)
        {
            int currInt = int.Parse(Console.ReadLine());
            sum1 += currInt;
        }

        // second n sequence
        for (int i = 0; i < n; i++)
        {
            int currInt = int.Parse(Console.ReadLine());
            sum2 += currInt;
        }

        if (sum1 == sum2)
        {
            Console.Write("Yes, sum={0}", sum1);
        }
        else
        {
            Console.Write("No, diff={0}", Math.Abs(sum1 - sum2));
        }
    }
}
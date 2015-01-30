using System;

class ComparingFloats
{
    static void Main()
    {
        double difference = 0.000001;
        
        Console.WriteLine(Compare(5.3, 6.01, difference));
        Console.WriteLine(Compare(5.00000001, 5.00000003, difference));
        Console.WriteLine(Compare(5.00000003, 5.00000001, difference));
        Console.WriteLine(Compare(-0.0000007, 0.00000007, difference));
        Console.WriteLine(Compare(-4.999999, -4.999998, difference));
        Console.WriteLine(Compare(4.999999, 4.999998, difference));
    }

    static bool Compare(double num1, double num2, double difference)
    {
        return Math.Abs(num1 - num2) < difference;
    }
}

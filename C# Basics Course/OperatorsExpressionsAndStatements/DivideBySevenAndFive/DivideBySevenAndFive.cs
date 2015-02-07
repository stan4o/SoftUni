using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        int n = 3;
        Console.WriteLine("{0} is it divided by 7 and 5? {1}.", n, (n % 7 == 0) && (n % 5 == 0) && (n != 0));

        n = 0;
        Console.WriteLine("{0} is it divided by 7 and 5? {1}.", n, (n % 7 == 0) && (n % 5 == 0) && (n != 0));

        n = 5;
        Console.WriteLine("{0} is it divided by 7 and 5? {1}.", n, (n % 7 == 0) && (n % 5 == 0) && (n != 0));

        n = 7;
        Console.WriteLine("{0} is it divided by 7 and 5? {1}.", n, (n % 7 == 0) && (n % 5 == 0) && (n != 0));

        n = 35;
        Console.WriteLine("{0} is it divided by 7 and 5? {1}.", n, (n % 7 == 0) && (n % 5 == 0) && (n != 0));

        n = 140;
        Console.WriteLine("{0} is it divided by 7 and 5? {1}.", n, (n % 7 == 0) && (n % 5 == 0) && (n != 0));
    }
}
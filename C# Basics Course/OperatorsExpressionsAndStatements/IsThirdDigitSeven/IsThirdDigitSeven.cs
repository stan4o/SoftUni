using System;

class IsThirdDigitSeven
{
    static void Main()
    {
        int n = 5;
        Console.WriteLine("Is third digit of {0} equal to '7': {1}", n, (n / 100) % 10 == 7);

        n = 701;
        Console.WriteLine("Is third digit of {0} equal to '7': {1}", n, (n / 100) % 10 == 7);

        n = 9703;
        Console.WriteLine("Is third digit of {0} equal to '7': {1}", n, (n / 100) % 10 == 7);

        n = 877;
        Console.WriteLine("Is third digit of {0} equal to '7': {1}", n, (n / 100) % 10 == 7);

        n = 777877;
        Console.WriteLine("Is third digit of {0} equal to '7': {1}", n, (n / 100) % 10 == 7);

        n = 9999799;
        Console.WriteLine("Is third digit of {0} equal to '7': {1}", n, (n / 100) % 10 == 7);
    }
}
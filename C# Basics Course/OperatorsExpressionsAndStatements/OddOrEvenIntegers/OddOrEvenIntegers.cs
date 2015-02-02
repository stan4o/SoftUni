using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int n = 3;
        Console.WriteLine("Is {0} odd? {1}", n, n % 2 != 0);

        n = 2;
        Console.WriteLine("Is {0} odd? {1}", n, n % 2 != 0);

        n = -2;
        Console.WriteLine("Is {0} odd? {1}", n, n % 2 != 0);

        n = -1;
        Console.WriteLine("Is {0} odd? {1}", n, n % 2 != 0);

        n = 0;
        Console.WriteLine("Is {0} odd? {1}", n, n % 2 != 0);
    }
}
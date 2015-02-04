using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int baundary = 100;
        int n = 1;
        Console.WriteLine("Is {0} a prime number? {1}", n, isPrime(n));

        n = 2;
        Console.WriteLine("Is {0} a prime number? {1}", n, isPrime(n));

        n = 3;
        Console.WriteLine("Is {0} a prime number? {1}", n, isPrime(n));

        n = 4;
        Console.WriteLine("Is {0} a prime number? {1}", n, isPrime(n));

        n = 9;
        Console.WriteLine("Is {0} a prime number? {1}", n, isPrime(n));

        n = 97;
        Console.WriteLine("Is {0} a prime number? {1}", n, isPrime(n));

        n = 51;
        Console.WriteLine("Is {0} a prime number? {1}", n, isPrime(n));

        n = -3;
        Console.WriteLine("Is {0} a prime number? {1}", n, isPrime(n));

        n = 0;
        Console.WriteLine("Is {0} a prime number? {1}", n, isPrime(n));
        
    }

    private static bool isPrime(int n)
    {
        bool isPrime = false;
        int i;
        int k = 0;

        for (i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                k++;
            }
        }

        if (k == 2)
        {
            isPrime = true;
        }

        return isPrime;
    }
}
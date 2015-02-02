using System;

class FourDigitNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = ((n / 1000) % 10);
        int b = ((n / 100) % 10);
        int c = ((n / 10) % 10);
        int d = (n % 10);
        int sum = a + b + c + d;

        if (a == 0)
        {
            Console.WriteLine("Please enter four-digit number that is not starting with 0!");
        }
        else
        {
            Console.WriteLine("Sum of digits: {0}", sum);
            Console.WriteLine("Reversed: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Last digit in front: {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", a, c, b, d);   
        }
    }
}
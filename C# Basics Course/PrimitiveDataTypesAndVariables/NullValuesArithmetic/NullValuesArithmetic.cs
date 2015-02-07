using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(new string('-',20));
        Console.WriteLine(a + 1);
        Console.WriteLine(b + 1);
        Console.WriteLine(new string('-', 20));
        Console.WriteLine(a + null);
        Console.WriteLine(b + null);
    }
}

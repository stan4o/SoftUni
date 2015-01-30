using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
        byte length = 255;

        for (int i = 0; i < length; i++)
        {
            char character = (char) i;
            Console.WriteLine("{0} -> {1}", i, character);
        }
    }
}

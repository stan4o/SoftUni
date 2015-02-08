using System;

class QuotesInStrings
{
    static void Main()
    {
        string withoutQuotes = "The use of quotations causes difficulties.";
        string withDoubleQuotes = "The \"use\" of quotations causes difficulties.";
        string withSingleQuotes = "The 'use' of quotations causes difficulties.";

        Console.WriteLine(withoutQuotes);
        Console.WriteLine(withDoubleQuotes);
        Console.WriteLine(withSingleQuotes);
    }
}

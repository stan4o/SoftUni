using System;

class Rectangles
{
    static void Main()
    {
        double width = 3d;
        double height = 4d;

        Console.WriteLine("Rectangular's perimeter is {0} and his area is {1}.", 2 * width + 2 * height, width * height);

        width = 2.5d;
        height = 3d;

        Console.WriteLine("Rectangular's perimeter is {0} and his area is {1}.", 2 * width + 2 * height, width * height);

        width = 5d;
        height = 5d;

        Console.WriteLine("Rectangular's perimeter is {0} and his area is {1}.", 2 * width + 2 * height, width * height);
    }
}
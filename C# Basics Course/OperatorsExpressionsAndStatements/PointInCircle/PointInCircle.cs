using System;

class PointInCircle
{
    static void Main()
    {
        double px = 0;
        double py = 1;

        Console.WriteLine("Is the point ({0}, {1}) in the circle K((0, 0), 2)? {2}", px, py, InCircle(px, py));

        px = -2;
        py = 0;

        Console.WriteLine("Is the point ({0}, {1}) in the circle K((0, 0), 2)? {2}", px, py, InCircle(px, py));

        px = -1;
        py = 2;

        Console.WriteLine("Is the point ({0}, {1}) in the circle K((0, 0), 2)? {2}", px, py, InCircle(px, py));

        px = 1.5d;
        py = -1;

        Console.WriteLine("Is the point ({0}, {1}) in the circle K((0, 0), 2)? {2}", px, py, InCircle(px, py));

        px = -1.5d;
        py = -1.5d;

        Console.WriteLine("Is the point ({0}, {1}) in the circle K((0, 0), 2)? {2}", px, py, InCircle(px, py));

        px = 100;
        py = -30;

        Console.WriteLine("Is the point ({0}, {1}) in the circle K((0, 0), 2)? {2}", px, py, InCircle(px, py));

        px = 0;
        py = 0;

        Console.WriteLine("Is the point ({0}, {1}) in the circle K((0, 0), 2)? {2}", px, py, InCircle(px, py));

        px = 0.2d;
        py = -0.8d;

        Console.WriteLine("Is the point ({0}, {1}) in the circle K((0, 0), 2)? {2}", px, py, InCircle(px, py));

        px = 0.9d;
        py = -1.93d;

        Console.WriteLine("Is the point ({0}, {1}) in the circle K((0, 0), 2)? {2}", px, py, InCircle(px, py));

        px = 1;
        py = 1.655;

        Console.WriteLine("Is the point ({0}, {1}) in the circle K((0, 0), 2)? {2}", px, py, InCircle(px, py));
    }

    private static bool InCircle(double x, double y)
    {
        // Circle K({cx, cy}, cr)
        int cx = 0; // circle x
        int cy = 0; // circle y
        int cr = 2; // circle radius

        if (Math.Pow((x - cx), 2) + Math.Pow((y - cy), 2) <= Math.Pow(cr, 2))
        {
            return true;
        }

        return false;
    }
}
using System;
using System.Windows;

class PointInCircleAndOutOfRectangle
{
    static void Main()
    {
        double x = 1d;
        double y = 2d;
        string result = InCircle(x, y) && !InRectangle(x, y) ? "yes" : "no";
        Console.WriteLine("Is the point ({0}, {1}) in the circle and outside the rectangle? {2}", x, y, result);

        x = 2.5d;
        y = 2d;
        result = InCircle(x, y) && !InRectangle(x, y) ? "yes" : "no";
        Console.WriteLine("Is the point ({0}, {1}) in the circle and outside the rectangle? {2}", x, y, result);

        x = 0d;
        y = 1d;
        result = InCircle(x, y) && !InRectangle(x, y) ? "yes" : "no";
        Console.WriteLine("Is the point ({0}, {1}) in the circle and outside the rectangle? {2}", x, y, result);

        x = 2.5d;
        y = 1d;
        result = InCircle(x, y) && !InRectangle(x, y) ? "yes" : "no";
        Console.WriteLine("Is the point ({0}, {1}) in the circle and outside the rectangle? {2}", x, y, result);

        x = 2d;
        y = 0d;
        result = InCircle(x, y) && !InRectangle(x, y) ? "yes" : "no";
        Console.WriteLine("Is the point ({0}, {1}) in the circle and outside the rectangle? {2}", x, y, result);

        x = 4d;
        y = 0d;
        result = InCircle(x, y) && !InRectangle(x, y) ? "yes" : "no";
        Console.WriteLine("Is the point ({0}, {1}) in the circle and outside the rectangle? {2}", x, y, result);

        x = 2.5d;
        y = 1.5d;
        result = InCircle(x, y) && !InRectangle(x, y) ? "yes" : "no";
        Console.WriteLine("Is the point ({0}, {1}) in the circle and outside the rectangle? {2}", x, y, result);

        x = 2d;
        y = 1.5d;
        result = InCircle(x, y) && !InRectangle(x, y) ? "yes" : "no";
        Console.WriteLine("Is the point ({0}, {1}) in the circle and outside the rectangle? {2}", x, y, result);

        x = 1d;
        y = 2.5d;
        result = InCircle(x, y) && !InRectangle(x, y) ? "yes" : "no";
        Console.WriteLine("Is the point ({0}, {1}) in the circle and outside the rectangle? {2}", x, y, result);

        x = -100d;
        y = -100d;
        result = InCircle(x, y) && !InRectangle(x, y) ? "yes" : "no";
        Console.WriteLine("Is the point ({0}, {1}) in the circle and outside the rectangle? {2}", x, y, result);
    }

    private static bool InCircle(double x, double y)
    {
        // Circle K({cx, cy}, cr)
        double cx = 1d; // circle x
        double cy = 1d; // circle y
        double cr = 1.5d; // circle radius

        // Check if point is in circle;
        if (Math.Pow((x - cx), 2) + Math.Pow((y - cy), 2) <= Math.Pow(cr, 2))
        {
            return true;
        }

        return false;
    }

    private static bool InRectangle(double x, double y)
    {
        double top = 1d;
        double left = -1d;
        double width = 6d;
        double height = 2d;

        // Initialize rectangle
        Rect Rectangle = new Rect();

        // Set location
        Rectangle.Location = new Point(top, left);

        // Set width and height
        Rectangle.Size = new Size(width, height);

        // Check if point is in rectangle
        bool inRectangle = Rectangle.Contains(new Point(x, y));

        return inRectangle;
    }
}
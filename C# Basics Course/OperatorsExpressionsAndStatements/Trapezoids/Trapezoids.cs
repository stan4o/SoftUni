using System;

class Trapezoids
{
    static void Main()
    {
        double sideA = 5d;
        double sideB = 7d;
        double height = 12d;

        Console.WriteLine("The area of trapezoid with a={0}, b={1} and h={2} is: {3}", sideA, sideB, height, ((sideA + sideB) * height) / 2d);

        sideA = 2d;
        sideB = 1d;
        height = 33d;
        Console.WriteLine("The area of trapezoid with a={0}, b={1} and h={2} is: {3}", sideA, sideB, height, ((sideA + sideB) * height) / 2d);

        sideA = 8.5d;
        sideB = 4.3d;
        height = 2.7d;
        Console.WriteLine("The area of trapezoid with a={0}, b={1} and h={2} is: {3}", sideA, sideB, height, ((sideA + sideB) * height) / 2d);

        sideA = 100d;
        sideB = 200d;
        height = 300d;
        Console.WriteLine("The area of trapezoid with a={0}, b={1} and h={2} is: {3}", sideA, sideB, height, ((sideA + sideB) * height) / 2d);

        sideA = .222d;
        sideB = .333d;
        height = .555d;
        Console.WriteLine("The area of trapezoid with a={0}, b={1} and h={2} is: {3}", sideA, sideB, height, ((sideA + sideB) * height) / 2d);
    }
}
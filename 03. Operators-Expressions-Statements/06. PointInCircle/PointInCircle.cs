/* Write an expression that checks if given point (x,  y) is within a circle K(O, 5). */

using System;

class PodoubleInCircle
{
    static void Main()
    {
        Console.Write("Please set a value of x: ");
        double xCoord = double.Parse(Console.ReadLine());
        Console.Write("Please set a value of y: ");
        double yCoord = double.Parse(Console.ReadLine());
        double radius = 5;

        if ((xCoord * xCoord) + (yCoord * yCoord) <= radius * radius) // Pythagorean theorem
        {
            Console.WriteLine("The given point is inside the circle");
        }
        else
        {
            Console.WriteLine("The given point is outside the circle");
        }
    }
}

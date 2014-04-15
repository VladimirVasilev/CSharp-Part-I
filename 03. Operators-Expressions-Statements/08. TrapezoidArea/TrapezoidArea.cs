/* Write an expression that calculates trapezoid's area by given sides a and b and height h. */

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("a = ");
        int aSide = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int bSide = int.Parse(Console.ReadLine());
        Console.Write("h = ");
        int height = int.Parse(Console.ReadLine());

        int area = ((aSide + bSide) / 2) * height;
        Console.WriteLine("Trapezoid's area is: {0}", area);
    }
}

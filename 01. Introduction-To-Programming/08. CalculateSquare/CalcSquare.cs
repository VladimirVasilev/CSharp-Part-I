/* Create a console application that calculates and prints the square of the number 12345. */

using System;

class CalcSquare
{
    static void Main()
    {
        double result = Math.Pow(12345, 2);
        Console.WriteLine("Square of the number 12345 is {0}", result);
    }
}

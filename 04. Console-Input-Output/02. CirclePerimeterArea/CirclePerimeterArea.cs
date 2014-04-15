/*  Write a program that reads the radius r of a circle and prints its perimeter and area. */

using System;

class CirclePerimeterArea
{
    static void Main()
    {
        Console.Write("r = ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;

        Console.WriteLine("The perimeter of the circle is {0}", perimeter);
        Console.WriteLine("The area of the circle is {0}" , area);
    }
}

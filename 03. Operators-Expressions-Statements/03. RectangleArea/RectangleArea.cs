/* Write an expression that calculates rectangle’s area by given width and height. */

using System;

class RectangleArea
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue; //Change background color of the console
        Console.WriteLine("Hello, this program calculates rectangle's area. \nPlease set a values for width and height:");
        Console.BackgroundColor = ConsoleColor.Black; //Return default background color of the console

        //Input
        Console.Write("width = ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("height = ");
        int height = int.Parse(Console.ReadLine());

        //Rectangle's area formulas
        int area = width * height;

        //Output
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("The rectangle's area is: {0}", area);
        Console.BackgroundColor = ConsoleColor.Black;
    }
}

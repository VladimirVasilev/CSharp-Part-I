/* Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
   and out of the rectangle R(top=1, left=-1, width=6, height=2). */

using System;

class WithinCircleOutRectangle
{
    static void Main()
    {
        Console.Write("Enter a value for x: ");
        double xCoord = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for y: ");
        double yCoord = double.Parse(Console.ReadLine());

        bool innerCircle = ((xCoord - 1) * (xCoord - 1) + (yCoord - 1) * (yCoord - 1)) <= 9;
        bool innerRectangle = ((-1 <= xCoord) && (xCoord <= 5)) && ((-1 <= yCoord) && (yCoord <= 1));
        
        Console.Write("The given point is ");
        Console.Write(innerCircle ? "within the circle and " : "outside the circle and ");
        Console.WriteLine(innerRectangle ? "inside the rectangle." : "outside the rectangle.");
    }
}

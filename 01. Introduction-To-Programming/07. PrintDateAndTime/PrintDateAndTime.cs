/* Create a console application that prints the current date and time. */

using System;

class PrintDateAndTime
{
    static void Main()
    {
        DateTime currentDateTime = DateTime.Now;
        Console.WriteLine("Current date and time: {0}", currentDateTime);
    }
}

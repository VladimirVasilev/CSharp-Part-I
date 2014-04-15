/* Modify the previous application to print your name. */

using System;

class PrintName
{
    static void Main()
    {
        Console.Write("Please input your name: ");
        string nameToPrint = Console.ReadLine();

        Console.WriteLine("Hello {0}!", nameToPrint);
    }
}

/* Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2 --> value=1. */

using System;

class ExtractBitValue
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Set a number of bit: ");
        int b = int.Parse(Console.ReadLine());

        int mask = 1 << b;
        Console.Write("Value of bit number is: ");
        Console.WriteLine((i & mask) != 0 ? 1 : 0);
    }
}

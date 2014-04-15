/* Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0. */

using System;

class FindBitValue
{
    static void Main()
    {
        Console.WriteLine("Please enter a number to find the value of it's third bit (counting from 0):");
        int inputNum = int.Parse(Console.ReadLine());

        int mask = 1 << 3;
        int bitValue = (inputNum & mask) >> 3;

        Console.WriteLine("Binary representation of given number {0} is: {1}", inputNum, Convert.ToString(inputNum, 2));
        Console.WriteLine("The third bit value (counting from 0) is: {0}", bitValue);
    }
}

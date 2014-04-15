/* Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. */

using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Please enter a number /unsigned integer/: ");
        uint number = uint.Parse(Console.ReadLine());

        uint bit3 = (number & (1 << 3)) >> 3;
        uint bit4 = (number & (1 << 4)) >> 4;
        uint bit5 = (number & (1 << 5)) >> 5;
        uint bit24 = (number & (1 << 24)) >> 24;
        uint bit25 = (number & (1 << 25)) >> 25;
        uint bit26 = (number & (1 << 26)) >> 26;
        uint modifyNumber = Convert.ToUInt32(number & (~(1 << 3)) & (~(1 << 4)) & (~(1 << 5)) & (~(1 << 24)) & (~(1 << 25)) & (~(1 << 26)));
        uint result = modifyNumber | (bit3 << 24) | (bit4 << 25) | (bit5 << 26) | (bit24 << 3) | (bit25 << 4) | (bit26 << 5);
        
        Console.WriteLine("The binary representation of the number {0} is : {1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("The binary representation of modify number {0} is : {1}", result, Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}

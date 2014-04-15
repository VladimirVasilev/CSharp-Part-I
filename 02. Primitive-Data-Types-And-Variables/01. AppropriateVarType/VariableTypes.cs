/* Declare five variables choosing for each of them the most appropriate of the types
   byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
   52130, -115, 4825932, 97, -10000. */

using System;

class VariableTypes
{
    static void Main()
    {
        ushort typeUshort = 52130;
        sbyte typeSbyte = -115;
        int typeInt = 4825932;
        byte typeByte = 97;
        short typeShort = -10000;

        Console.WriteLine("ushort: {0} \nsbyte: {1} \nint: {2} \nbyte: {3} \nshort: {4}", typeUshort, typeSbyte, typeInt, typeByte, typeShort);
    }
}

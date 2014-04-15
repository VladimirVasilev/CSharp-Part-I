/* Create a program that assigns null values to an integer and to double variables. Try to print
   them on the console, try to add some values or the null literal to them and see the result. */

using System;

class NullValue
{
    static void Main()
    {
        int? someInt = null;
        double? someDouble = null;

        Console.WriteLine(someInt);
        Console.WriteLine(someDouble);
        Console.WriteLine(someInt + someDouble);
        Console.WriteLine(someInt + 666);
        Console.WriteLine(someDouble + 666);
    }
}

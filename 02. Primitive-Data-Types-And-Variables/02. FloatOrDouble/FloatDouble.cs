﻿/* Which of the following values can be assigned to a variable of type float and which
   to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? */

using System;

class FloatDouble
{
    static void Main()
    {
        double firstDouble = 34.567839023;
        float firstFloat = 12.345f;
        double secondDouble = 8923.1234857;
        float secondFloat = 3456.091f;

        Console.WriteLine("Type double: {0} and {1}", firstDouble, secondDouble);
        Console.WriteLine("Type float: {0} and {1}", firstFloat, secondFloat);
    }
}

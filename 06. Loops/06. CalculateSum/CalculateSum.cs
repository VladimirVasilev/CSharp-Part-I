/* Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N */

using System;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Set the value of\n N = ");
        decimal n = decimal.Parse(Console.ReadLine());
        Console.Write("Set the value of\n X = ");
        decimal x = decimal.Parse(Console.ReadLine());

        decimal factorialN = 1;
        decimal poweredX = 1;
        decimal sum = 0;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            poweredX *= x;
        }

        sum += 1 + factorialN / poweredX;
        Console.WriteLine("1 + N!/X^N = {0}", sum);
    }
}

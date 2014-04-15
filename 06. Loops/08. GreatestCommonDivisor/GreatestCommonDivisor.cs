/* Write a program that calculates the greatest common divisor (GCD) of given two numbers.
 * Use the Euclidean algorithm (find it in Internet). */

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.WriteLine("Let's calculate the GCD of two given numbers:");
        Console.Write("a = ");
        int inputA = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int inputB = int.Parse(Console.ReadLine());
        if (inputA == 0 || inputB == 0)
        {
            Console.WriteLine("Please set a positive values of the numbers \"a\" and \"b\"");
            Main();
        }
        else
        {
            while (inputA > inputB || inputB > inputA)
            {
                while ((inputA - inputB) > 0)
                {
                    inputA = inputB - inputB;

                }
                while ((inputB - inputA) > 0)
                {
                    inputB = inputB - inputA;
                }

            }
            Console.WriteLine("The Greatest Common Divisor of \"a\" and \"b\" is: {0}", inputA);
        }
    }
}

/* Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K). */

using System;
using System.Numerics;

class MoreFactorials
{
    static void Main()
    {
        Console.WriteLine("Please set a values of N and K - (1<N<K)");
        Console.Write("N = ");
        int inputN = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int inputK = int.Parse(Console.ReadLine());

        if (inputN > 1 && inputK > inputN)
        {
            BigInteger factorialN = 1;
            for (int i = 1; i <= inputN; i++) // Calculates N!
            {
                factorialN *= i;
            }

            BigInteger factorialK = 1;
            for (int j = 1; j <= inputK; j++) // Calculates K!
            {
                factorialK *= j;
            }

            BigInteger factorialDifference = 1;
            for (int k = 1; k <= (inputK - inputN); k++)
            {
                factorialDifference *= k;
            }

            BigInteger multiplicFactorials = factorialN * factorialK;
            BigInteger result = multiplicFactorials / factorialDifference;

            Console.WriteLine("N! * K! / (K - N)! = {0}", result);
        }
        else
        {
            Console.WriteLine("Error! Please enter a correct input values - (1<N<K)!");
        }
    }
}

/* Write a program that calculates N!/K! for given N and K (1<K<N). */

using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        Console.WriteLine("Please set a values of N and K - (1<K<N)");
        Console.Write("N = ");
        int inputN = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int inputK = int.Parse(Console.ReadLine());

        if (inputK > 1 && inputN > inputK)
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

            Console.WriteLine("N!/K! = {0} / {1} = {2}", factorialN, factorialK, factorialN / factorialK);
        }
        else
        {
            Console.WriteLine("Error! Please enter a correct input - (1<K<N)!");
        }
    }
}

/* Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … */

using System;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        BigInteger firstNum = 0;
        BigInteger secondNum = 1;
        BigInteger nextNum;

        Console.WriteLine(firstNum);
        Console.WriteLine(secondNum);

        for (int i = 0; i <= 98; i++)
        {
            nextNum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = nextNum;
            
            Console.WriteLine(nextNum);
        }
    }
}

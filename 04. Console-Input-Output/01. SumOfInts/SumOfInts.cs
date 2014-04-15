/* Write a program that reads 3 integer numbers from the console and prints their sum. */

using System;

class SumOfInts
{
    static void Main()
    {
        Console.Write("a = ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int thirdNum = int.Parse(Console.ReadLine());

        int sum = firstNum + secondNum + thirdNum;
        Console.WriteLine("The sum is {0}", sum);
    }
}

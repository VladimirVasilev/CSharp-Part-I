﻿/* Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. */

using System;

class NumbersSum
{
    static void Main()
    {
        Console.Write("How many numbers we will sum: ");
        int input = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i < input; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            sum += numbers;
        }

        Console.WriteLine("The sum of the numbers is: {0}", sum);
    }
}

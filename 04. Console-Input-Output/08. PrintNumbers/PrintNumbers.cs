﻿/* Write a program that reads an integer number n from the console and 
   prints all the numbers in the interval [1..n], each on a single line. */

using System;

class PrintNumbers
{
    static void Main()
    {
        Console.Write("Set a value of \"n\" to define a interval [1, n] \nn = ");
        int inputNum = int.Parse(Console.ReadLine());

        for (int i = 1; i <= inputNum; i++)
        {
            Console.WriteLine(i);
        }
    }
}

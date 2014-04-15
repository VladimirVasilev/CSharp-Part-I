/* Write a program that prints all the numbers from 1 to N. */

using System;
using System.Text;

class PrintNumbers
{
    static void Main()
    {
        Console.Write("Please input a value of N: ");
        int inputN = int.Parse(Console.ReadLine());
        StringBuilder builder = new StringBuilder();

        // Append "i" to the StringBuilder.
        for (int i = 1; i <= inputN; i++)
        {
            builder.Append(i).Append(" ");
        }

        Console.WriteLine(builder);
    }
}

﻿/* Create console application that prints your first and last name. */

using System;

class PrintFullName
{
    static void Main()
    {
        Console.Write("First name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Your full name is: {0} {1}", firstName, lastName);
    }
}

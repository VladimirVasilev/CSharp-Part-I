/* *Write a program to read your age from the console and print how old you will be after 10 years. */

using System;

class AgeAfter10Years
{ 
    static void Main()
    {
        Console.Write("Please enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("After 10 years your age will be {0}", age + 10);
    }
}

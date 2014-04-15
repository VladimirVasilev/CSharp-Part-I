/* Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements. */

using System;

class GreaterNumber
{
    static void Main()
    {
        Console.Write("a = ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int secondNum = int.Parse(Console.ReadLine());

        int greaterNum = firstNum > secondNum ? firstNum : secondNum;

        Console.WriteLine("The greater number is {0}", greaterNum);
    }
}

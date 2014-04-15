/* Write a program that safely compares floating-point numbers with precision of 0.000001. 
   Examples:(5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true */

using System;

class CompareWithPrecision
{
    static void Main()
    {
        Console.WriteLine("Please input the values of two floating-point \nnumbers to compare them with precision of 0.000001");
        Console.WriteLine();

        Console.Write("First number: ");
        decimal firstNum = decimal.Parse(Console.ReadLine());
        firstNum = Math.Round(firstNum, 6);

        Console.Write("Second number: ");
        decimal secondNum = decimal.Parse(Console.ReadLine());
        secondNum = Math.Round(secondNum, 6);

        Console.WriteLine();
        Console.WriteLine("Are the numbers equal?! {0}", firstNum == secondNum);
    }
}

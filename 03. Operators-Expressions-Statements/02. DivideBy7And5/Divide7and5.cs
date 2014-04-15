/* Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. */

using System;

class Divide7and5
{
    static void Main()
    {
        Console.WriteLine("Please input a number to check if it can be \ndivided (without remainder) by 7 and 5 in the same time.");
        int inputNum = int.Parse(Console.ReadLine());

        bool isDivided = ((inputNum % 5 == 0) && (inputNum % 7 == 0));
        Console.WriteLine("The given number {0} can be divided by 7 and 5 without remainder: {1}", inputNum, isDivided);
    }
}

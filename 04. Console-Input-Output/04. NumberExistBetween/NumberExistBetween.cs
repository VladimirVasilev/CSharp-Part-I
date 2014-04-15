/* Write a program that reads two positive integer numbers and prints how many numbers p exist 
   between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2. */

using System;

class NumberExistBetween
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        
        int counter = 0;
        for (int i = firstNum; i <= secondNum; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }

        Console.WriteLine("All the numbers \"p\" that exist between interval of p({0}, {1}) such that the reminder of the division by 5 is 0 are: {2}", firstNum, secondNum, counter);
    }
}

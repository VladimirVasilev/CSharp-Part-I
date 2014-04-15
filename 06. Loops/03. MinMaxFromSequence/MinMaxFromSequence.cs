/* Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them. */

using System;

class MinMaxFromSequence
{
    static void Main()
    {
        // SOLUTION 1 - using an Array
        Console.Write("Please input a value of N to define the length of the sequence: ");
        int countNums = int.Parse(Console.ReadLine());

        int[] allNumbers = new int[countNums]; //Initialize the array

        for (int i = 0; i < countNums; i++)
        {
            Console.Write("Please enter a number: ");
            int inputNum = int.Parse(Console.ReadLine());
            allNumbers[i] = inputNum;
        }

        Array.Sort(allNumbers); //Sort the array

        Console.WriteLine("MIN number from the sequence is: {0}", allNumbers[0]);
        Console.WriteLine("MAX number from the sequence is: {0}", allNumbers[allNumbers.Length - 1]);

        // SOLUTION 2 - using If Statements 
        /*
        Console.Write("How many numbers you will check? ");
        int countOfNums = int.Parse(Console.ReadLine());
        int min, max, inputNum;
        
        Console.Write("Please enter your first number: ");
        inputNum = int.Parse(Console.ReadLine());
        min = max = inputNum;
        for (int i = 1; i <= countOfNums; i++)
        {
            Console.Write("Please enter your next number: ");
            inputNum = int.Parse(Console.ReadLine());

            if (inputNum > max)
            {
                max = inputNum;
            }
            if (inputNum < min)
            {
                min = inputNum;
            }
        }

        Console.WriteLine("The MIN value in the given sequence is: {0}", min);
        Console.WriteLine("The MAX value in the given sequence is: {0}", max);
        */
    }
}

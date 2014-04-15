/* Sort 3 real values in descending order using nested if statements. */

using System;

class Sort3Numbers
{
    static void Main()
    {
        // SOLUTION 1 - using an Array, For Loop and Foreach
        int[] myArr = new int[3]; // Initialize an array

        for (int index = 0; index < 3; index++)
        {
            Console.Write("number {0} = ", index + 1);
            myArr[index] = int.Parse(Console.ReadLine());
        }

        Array.Sort(myArr); // Sorting array in ascending order
        Array.Reverse(myArr); // Reverse an array to become sorted in descending order

        // Print the numbers in descending order
        Console.WriteLine("Given numbers in descending order are: ");
        foreach (var item in myArr)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        // SOLUTION 2 - using If Statements
        /*
        Console.Write("Enter the first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int thirdNum = int.Parse(Console.ReadLine());

        if ((firstNum == secondNum) || (firstNum == thirdNum) || (thirdNum == secondNum))
        {
            Console.WriteLine("There are some equal numbers");
        }
        if (firstNum > secondNum)
        {
            if (firstNum > thirdNum)
            {
                if (secondNum > thirdNum)
                {
                    Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                        firstNum, secondNum, thirdNum); // 1,2,3
                }
                else
                {
                    Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                        firstNum, thirdNum, secondNum); // 1,3,2
                }
            }
            else
            {
                Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                    thirdNum, firstNum, secondNum); // 3,1,2
            }
        }
        else if ((secondNum > firstNum) && (thirdNum > secondNum))
        {
            Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                thirdNum, secondNum, firstNum); // 3,2,1
        }
        else if ((secondNum > firstNum && firstNum > thirdNum))
        {
            Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                secondNum, firstNum, thirdNum); // 2,1,3
        }
        else if ((secondNum > firstNum && thirdNum > firstNum))
        {
            Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                secondNum, thirdNum, firstNum); // 2,3,1
        }
        */
    }
}

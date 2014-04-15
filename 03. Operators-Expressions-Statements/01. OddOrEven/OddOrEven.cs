/* Write an expression that checks if given integer is odd or even. */

using System;

class OddOrEven
{
    static void Main()
    {                 
        Console.WriteLine("Please input a number to check it if it's ODD or EVEN");
        int inputNum = int.Parse(Console.ReadLine());

        //SOLUTION 1 - with ternary operator
        //Console.WriteLine(inputNum % 2 == 0 ? "EVEN" : "ODD" );

        //SOLUTION 2 - with expression
        /*
        bool isEven = (inputNum % 2 == 0);
        Console.WriteLine("The given number {0} is even: {1}", inputNum, isEven);
        */

        //SOLUTION 3 - with If-Else construction        
        if (inputNum % 2 == 0)
        {
            Console.WriteLine("The given number {0} is EVEN!", inputNum);
        }
        else
        {
            Console.WriteLine("The given number {0} is ODD", inputNum);
        }   
    }
}

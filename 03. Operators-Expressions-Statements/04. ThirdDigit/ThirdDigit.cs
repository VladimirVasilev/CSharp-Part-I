/* Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 --> true. */

using System;

class ThirdDigit
{
    static void Main()
    {
        //SOLUTION 1 - with expression
        Console.Write("Input a number and press Enter: ");
        int inputNum = int.Parse(Console.ReadLine());

        inputNum /= 100;
        bool isSeven = (inputNum % 10 == 7);

        Console.WriteLine("Is the third digit (right-to-left) is 7? {0}", isSeven);

        //SOLUTION 2 - with If-Else construction
        /*
        int inputNum = int.Parse(Console.ReadLine());
        
        bool isSeven;
        inputNum /= 100;

        if (inputNum % 10 == 7)
        {
            isSeven = true;
        }
        else
        {
            isSeven = false;
        }

        Console.WriteLine("The third digit (right-to-left) is seven: {0}", isSeven);
        */
    }
}

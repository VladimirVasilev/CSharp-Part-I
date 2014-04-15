/* Declare  two integer variables and assign them with 5 and 10 and after that exchange their values. */

using System;

class ExchangeValues
{
    static void Main()
    {
        int firstNum = 5;
        int secondNum = 10;

        Console.WriteLine("Before exchange we have: \n a = {0} and b = {1}", firstNum, secondNum);

        int additionalVar;

        //Exchange values
        additionalVar = firstNum;
        firstNum = secondNum;
        secondNum = additionalVar;

        Console.WriteLine("After exchange we have: \n a = {0} and b = {1}", firstNum, secondNum);
    }
}

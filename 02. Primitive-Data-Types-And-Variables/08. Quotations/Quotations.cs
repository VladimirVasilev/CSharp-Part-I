/* Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
   Do the above in two different ways: with and without using quoted strings. */

using System;

class Quotations
{
    static void Main()
    {
        string firstStr = "The \"use\" of quotations causes difficulties.";
        string secondStr = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine("{0} \n{1}", firstStr, secondStr);
    }
}

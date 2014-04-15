/* Declare a character variable and assign it with the symbol that has Unicode code 72.
   Hint: first use the Windows Calculator to find the hexadecimal representation of 72. */

using System;

class DeclareChar
{
    static void Main()
    {
        char symbol = '\u0048';
        Console.WriteLine("The symbol that has Unicode code 72 is: {0}", symbol);
    }
}

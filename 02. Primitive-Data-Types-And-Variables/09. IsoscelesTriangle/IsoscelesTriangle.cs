/* Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map
  to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly. */

using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; //It helps to display copyright symbol correctly

        char copyrightSymbol = '\u00a9';

        int rows = 3;
        int cols = 5;

        for (int i = 0; i < rows; i++)
        {
            //Prints left part of the triangle
            for (int j = 0; j < cols / 2 + 1; j++)
            {
                if (j >= cols / 2 - i)
                {
                    Console.Write(copyrightSymbol);
                }
                else
                {
                    Console.Write(" ");
                }
            }

            //Prints right part of the triangle
            for (int j = cols / 2 + 1; j < cols; j++)
            {
                if (j > cols / 2 + i)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(copyrightSymbol);
                }
            }

            Console.WriteLine();
        }
    }
}
/* Declare two string variables and assign them with “Hello” and “World”. Declare an object
   variable and assign it with the concatenation of the first two variables (mind adding an interval).
   Declare a third string variable and initialize it with the value of the object variable (you should perform type casting). */

using System;

class StringAndObject
{
    static void Main()
    {
        string firstStr = "Hello";
        string secondStr = "World";

        object myObject = firstStr + " " + secondStr; //Concatenation of the first two string variables and adding an interval between them

        string thirdStr = (string)myObject; //Performing type casting

        Console.WriteLine(thirdStr);
    }
}

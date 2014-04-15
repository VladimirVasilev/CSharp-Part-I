/* A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, 
   family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables needed 
   to keep the information for a single employee using appropriate data types and descriptive names. */

using System;

class EmployeesInfo
{
    static void Main()
    {
        string firstName = "Pesho";
        string familyName = "Peshev";
        byte age = 95;
        char gender = 'm';
        uint id = 345756567;
        uint employeeNumber = 57565757;

        Console.WriteLine("First name: {0} \nFamily name: {1} \nAge: {2} \nGender: {3} \nID: {4} \nEmployee number: {5}", 
            firstName, familyName, age, gender, id, employeeNumber);
    }
}

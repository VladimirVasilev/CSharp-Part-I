/* A company has name, address, phone number, fax number, web site and manager. 
   The manager has first name, last name, age and a phone number. Write a program 
   that reads the information about a company and its manager and prints them on the console. */

using System;

class CompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Set a information about your company");
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Company phone: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Company fax: ");
        string companyFax = Console.ReadLine();
        Console.Write("Company website: ");
        string website = Console.ReadLine();
        Console.Write("Manager name: ");
        string managerName = Console.ReadLine();
        Console.Write("Manager age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("=========================");
        Console.WriteLine("Company name - {0} \nCompany address - {1} \nCompany phone - {2} \nCompany fax - {3} \nCompany website - {4} \nManager name - {5} \nManager age - {6} \nManager phone - {7}", 
           companyName, companyAddress, companyPhone, companyFax, website, managerName, managerAge, managerPhone);
        Console.WriteLine("=========================");
    }
}

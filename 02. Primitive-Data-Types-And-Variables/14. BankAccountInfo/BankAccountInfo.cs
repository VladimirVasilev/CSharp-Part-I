/* A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
   bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed 
   to keep the information for a single bank account using the appropriate data types and descriptive names. */

using System;

class BankAccountInfo
{
    static void Main()
    {
        string firstName = "Pesho";
        string middleName = "Peshev";
        string lastName = "Peshov";
        decimal moneyBalance = 3750.75M;
        string bankName = "DSK";
        string IBAN = "BG33 AAАА 1231 1012 3456 78";
        string BIC = "OKOYFIHH";

        Console.WriteLine("Full Name: {0} {1} {2} \n Balance: {3} \n Bank: {4} \n IBAN: {5} \n BIC: {6}",
                           firstName, middleName, lastName, moneyBalance, bankName, IBAN, BIC);
    }
}

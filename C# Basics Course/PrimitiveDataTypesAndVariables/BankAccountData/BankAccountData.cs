using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Stanimir";
        string middleName = "Hristov";
        string lastName = "Panayotov";
        int balance = 2003643;
        string bankName = "DSK Bank";
        string IBAN = "BG12STSA93000198745623";
        ulong visaCard = 4916309994259398;
        ulong masterCard = 5305122772509629;
        ulong discoverCard = 6011832665478475;

        Console.WriteLine("Name: " + firstName + " " + middleName + " " + lastName);
        Console.WriteLine("Balance: {0} лв", balance);
        Console.WriteLine("Bank name: " + bankName);
        Console.WriteLine("Bank account number (IBAN): " + IBAN);
        Console.WriteLine("Credit card numbers:\nVisa - {0}\nMasterCard - {1}\nDiscover - {2}", visaCard, masterCard, discoverCard);
    }
}

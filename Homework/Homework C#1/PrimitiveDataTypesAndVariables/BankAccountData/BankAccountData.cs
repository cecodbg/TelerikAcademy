// A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
// bank name, IBAN, 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account using the appropriate
// data types and descriptive names.

using System;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Petar";
            string middleName = "Ivanov";
            string lastName = "Gigov";
            decimal balance = 110000M;
            string bankName = "FiBank";
            string iban = "BG29FINV915010BGN0QHTZ";
            string bic = "FINVBGSF";
            string ccn1 = "1111 1111 1111 1111";
            string ccn2 = "2222 2222 2222 2222";
            string ccn3 = "3333 3333 3333 3333";
            Console.WriteLine("Name: {0} {1} {2}\nBalance: {3}lv\nBank name: {4}\nIBAN: {6}\ncredit card number: {7}\ncredit card number: {8}\ncredit card number: {9}", firstName, middleName, lastName, balance, bankName, iban, bic, ccn1, ccn2, ccn3);
        }
    }
}

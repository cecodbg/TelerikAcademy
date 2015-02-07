// A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Enter company name: ");
            string nameCompany = Console.ReadLine();
            Console.Write("Enter company address: ");
            string addressCompamy = Console.ReadLine();
            Console.Write("Enrer company phone number: ");
            int phoneNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter company fax number: ");
            int fexNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter company web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Enter first name of the manager: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name of the manager: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter age of the manager: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter phone number of the manager: ");
            int managerNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}" + "\n" + "Address: {1}" + "\n" + "Phone. {2}" + "\n" + "Fax: {3}" + "\n" + "Web site: {4}" + "\n" + "Manager: {5} {6} (age; {7}, tel. {8})", nameCompany, addressCompamy, phoneNumber, fexNumber, webSite, firstName, lastName, age, managerNumber);
        }
    }
}

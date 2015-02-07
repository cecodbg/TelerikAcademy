// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Enter your birthday; dd.mm.yyyy");

            DateTime birthday = DateTime.Parse(Console.ReadLine());

            int age = 0;
            age = DateTime.Today.Year - birthday.Year;

            if (birthday.Month > DateTime.Today.Month)
            {
                age--;
            }

            Console.WriteLine("You are now " + age);
            Console.WriteLine("After 10 years you will be " + (age + 10));
        }
    }
}

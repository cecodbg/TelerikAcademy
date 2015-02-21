// Write a method that returns the last digit of given integer as an English word.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDigit
{
    class EnglishDigit
    {
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Last digit says {0}", GetWord(number));
        }

        static string GetWord(int number)
        {
            string[] words =
            {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

            number = number % 10;
            string word = words[number];
            return word;
        }

    }
}

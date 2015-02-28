// Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
// Print the result string into the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class StringLength
    {
        static void Main()
        {
            Console.WriteLine("Enter given text maximum 20 characters:");
            string text = Console.ReadLine();

            if (text.Length > 20)
            {
                Console.WriteLine("Incorrect input");
            }
            else
            {
                //Console.WriteLine(text.PadLeft(20,'*'));
                string result1 = text.PadLeft(20, '*');
                Console.WriteLine(result1);
                string result = text.PadRight(20, '*');
                Console.WriteLine(result);
            }

            
        }
    }
}

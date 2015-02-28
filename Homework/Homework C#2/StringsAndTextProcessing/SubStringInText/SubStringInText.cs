// Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStringInText
{
    class SubStringInText
    {
        static void Main()
        {
            Console.WriteLine("Enter given text:");
            string text = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter sub-string:");
            string subString = Console.ReadLine();

            int index = 0;
            int count = 0;
            int faund = 0;
            while (true)
            {
                faund = text.IndexOf(subString, index);
                if (faund < 0)
                {
                    break;
                }
                count++;
                index = faund + 1;
            }
            Console.WriteLine("The result is: {0}", count);
        }
    }
}

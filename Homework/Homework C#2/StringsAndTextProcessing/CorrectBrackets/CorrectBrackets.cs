// Write a program to check if in a given expression the brackets are put correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            string inputString = Console.ReadLine();

            int count = 0;
            foreach (var item in inputString)
            {
                if (item == '(')
                {
                    count++;
                }
                else if (item == ')')
                {
                    count--;
                }
                if (count < 0)
                {
                    Console.WriteLine("Incorrect brackets");
                    break;
                }
            }

            if (count > 0)
            {
                Console.WriteLine("Incorrect brackets");
            }
            else if (count == 0)
            {
                Console.WriteLine("Correct brackets");
            }
        }
    }
}

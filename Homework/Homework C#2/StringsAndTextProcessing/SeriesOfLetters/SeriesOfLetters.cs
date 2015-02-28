// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string inputString = "aaaaabbbbbcdddeeeedssaa";

            StringBuilder resultString = new StringBuilder();

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (inputString[i] != inputString[i + 1])
                {
                    resultString.Append(inputString[i]);
                }
                if (i == inputString.Length - 2 && inputString[i] == inputString[i + 1])
                {
                    resultString.Append(inputString[i]);
                }
            }

            Console.WriteLine(resultString);
        }
    }
}

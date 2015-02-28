// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            string[] inputString = Console.ReadLine().Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
                                                     .ToArray();

            StringBuilder resultString = new StringBuilder();
            foreach (var str in inputString)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != str[str.Length - i - 1])
                    {
                        break;
                    }
                    if (i == str.Length / 2)
                    {
                        resultString.Append(str);
                    }
                }
            }
            Console.WriteLine(resultString);
        }
    }
}

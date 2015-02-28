// Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCount
{
    class WordsCount
    {
        static void Main()
        {
            string inputString = "Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements. Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.";

            string[] strings = inputString.Split(new char[] { '.', ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(x => x.ToString())
                                          .Select(x => x.ToLower())
                                          .ToArray();

            int count = 0;
            int found = 0;
            int index = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                count = 0;
                index = 0;
                while (true)
                {
                    found = Array.IndexOf(strings, strings[i], index);
                    if (found >= 0)
                    {
                        count++;
                        index = found + 1;
                    }
                    else
                    {
                        Console.WriteLine("The word \"{0}\" is found {1} time/s.", strings[i], count);
                        break;
                    }
                }
            }
        }
    }
}

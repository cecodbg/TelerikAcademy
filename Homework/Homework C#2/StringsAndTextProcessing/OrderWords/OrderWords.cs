// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWords
{
    class OrderWords
    {
        static void Main()
        {
            List<string> resultStrings = new List<string>();

            resultStrings = Console.ReadLine().Split(' ')
                                              .OrderBy(x => x)
                                              .ToList();

            foreach (var item in resultStrings)
            {
                Console.WriteLine(item);
            }
        }
    }
}

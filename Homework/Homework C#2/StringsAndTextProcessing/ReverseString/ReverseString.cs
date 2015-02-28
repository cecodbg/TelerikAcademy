// Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            Console.WriteLine("Enter string to rverse:");
            string[] str = Console.ReadLine()
                                  .Select(x => x.ToString())
                                  .Reverse()
                                  .ToArray();

            Console.WriteLine(string.Join("", str));
        }
    }
}

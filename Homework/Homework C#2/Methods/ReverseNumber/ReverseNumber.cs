// Write a method that reverses the digits of given decimal number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            var reverse = input.Reverse();
            Console.WriteLine(string.Join("", reverse));
        }
    }
}

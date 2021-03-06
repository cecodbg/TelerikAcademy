﻿// Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
// Format the output aligned right in 15 symbols.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNumber
{
    class FormatNumber
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            string text = string.Format("{0, 15}", number);
            Console.WriteLine("{0, 15}", number);
            text = string.Format("{0, 15:X}", number);
            Console.WriteLine("{0, 15:X}", number);
            text = string.Format("{0, 15:P}", number);
            Console.WriteLine("{0, 15:P}", number / 100);
            text = string.Format("{0, 15:E}", number);
            Console.WriteLine("{0, 15:E}", number);
        }
    }
}

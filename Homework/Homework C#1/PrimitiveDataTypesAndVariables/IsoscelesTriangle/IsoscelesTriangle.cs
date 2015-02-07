// Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

using System;
using System.Text;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("    \u00A9");
            Console.WriteLine("   \u00A9 \u00A9");
            Console.WriteLine("  \u00A9   \u00A9");
            Console.WriteLine(" \u00A9 \u00A9 \u00A9 \u00A9 ");
        }
    }
}

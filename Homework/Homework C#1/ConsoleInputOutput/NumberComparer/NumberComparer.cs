// Write a program that gets two numbers from the console and prints the greater of them.
// Try to implement this without if statements.

using System;
using System.Globalization;
using System.Threading;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter number a and number b: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double greater = Math.Max(a, b);

            Console.WriteLine("Greater is {0}", greater);
        }
    }
}

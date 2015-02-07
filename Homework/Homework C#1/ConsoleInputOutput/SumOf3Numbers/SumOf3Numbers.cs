// Write a program that reads 3 real numbers from the console and prints their sum.

using System;
using System.Globalization;
using System.Threading;

namespace SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter real number 1:");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter real number 2:");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter real number 3:");
            double number3 = double.Parse(Console.ReadLine());

            Console.WriteLine("The sum of {0}, {1}, {2} is {3}", number1, number2, number3, number1 + number2 + number3);
        }
    }
}

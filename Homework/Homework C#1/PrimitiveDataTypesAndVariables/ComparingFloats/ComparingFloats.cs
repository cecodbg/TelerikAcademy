// Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;
using System.Globalization;
using System.Threading;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            bool result = false;
            Console.WriteLine("Enter the first number:");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double secondNumber = double.Parse(Console.ReadLine());

            double eps = firstNumber - secondNumber;
            eps = Math.Abs(eps);
            if (eps < 0.000001)
            {
                result = true;
            }
            Console.WriteLine("({0};{1})\u2192{2}", firstNumber, secondNumber, result);
        }   
    }
}

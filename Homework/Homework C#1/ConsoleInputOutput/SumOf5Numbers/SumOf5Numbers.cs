// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;
using System.Globalization;
using System.Threading;

namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter five number: ");
            string inString = Console.ReadLine();

            string[] str = inString.Split(' ');
            double[] num = new double[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                num[i] = double.Parse(str[i]);
            }

            double result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                result += num[i];
            }
            Console.WriteLine(result);
        }
    }
}

// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

using System;
using System.Globalization;
using System.Threading;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter the number of integers: ");
            double n = double.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter {0} integer: ", i);
                double input = double.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}

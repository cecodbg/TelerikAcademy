// Write a program that finds the biggest of three numbers.

using System;
using System.Globalization;
using System.Threading;

namespace TheBiggestOfThreeNumbers
{
    class TheBiggestOfThreeNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            double biggest = 0;

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                biggest = firstNumber;
                Console.WriteLine("Biggest is {0}", biggest);
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                biggest = secondNumber;
                Console.WriteLine("Biggest is {0}", biggest);
            }
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                biggest = thirdNumber;
                Console.WriteLine("Biggest is {0}", biggest);
            }
        }
    }
}

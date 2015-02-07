// Write a program that enters 3 real numbers and prints them sorted in descending order.
// Use nested if statements.

using System;
using System.Globalization;
using System.Threading;

namespace SortThreeNumbersWithNestedIfs
{
    class ProgramSortThreeNumbersWithNestedIfs
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


            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine("{0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", firstNumber, thirdNumber, secondNumber);
                }
            }

            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("{0}, {1}, {2}", secondNumber, firstNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {}", secondNumber, thirdNumber, firstNumber);
                }
            }

            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine("{0}, {1}, {2}", thirdNumber, firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", thirdNumber, secondNumber, firstNumber);
                }

            }

        }
    }
}

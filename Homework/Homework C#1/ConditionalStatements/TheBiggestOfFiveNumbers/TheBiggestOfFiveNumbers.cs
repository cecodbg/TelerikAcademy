// Write a program that finds the biggest of five numbers by using only five if statements.

using System;
using System.Globalization;
using System.Threading;

namespace TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
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
            Console.Write("Enter fourth number: ");
            double fourthNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            double fifthNumber = double.Parse(Console.ReadLine());
            double biggest = 0;

            if ((firstNumber > secondNumber) && (firstNumber > thirdNumber) && (firstNumber > fourthNumber) && (firstNumber > fifthNumber))
            {
                biggest = firstNumber;
                Console.WriteLine("Biggest is {0}", biggest);
            }
            else if ((secondNumber > firstNumber) && (secondNumber > thirdNumber) && (secondNumber > fourthNumber) && (secondNumber > fifthNumber))
            {
                biggest = secondNumber;
                Console.WriteLine("Biggest is {0}", biggest);
            }
            else if ((thirdNumber > firstNumber) && (thirdNumber > secondNumber) && (thirdNumber > fourthNumber) && (thirdNumber > fifthNumber))
            {
                biggest = thirdNumber;
                Console.WriteLine("Biggest is {0}", biggest);
            }
            else if ((fourthNumber > firstNumber) && (fourthNumber > secondNumber) && (fourthNumber > thirdNumber) && (fourthNumber > fifthNumber))
            {
                biggest = fourthNumber;
            }
            else
            {
                biggest = fifthNumber;
                Console.WriteLine("Biggest is {0}", biggest);
            }
        }
    }
}

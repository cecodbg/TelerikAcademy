// Write a program that reads an integer number and calculates and prints its square root.
// If the number is invalid or negative, print Invalid number.
// In all cases finally print Good bye.
// Use try-catch-finally block.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            Console.Write("Enter number: ");

            double result = 0;
            try
            {
                double number = ReadPositiveNumber();
                result = Math.Sqrt(number);
                Console.WriteLine(result);
            }
            catch
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }

        static double ReadPositiveNumber()
        {
            double number = double.Parse(Console.ReadLine());
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Invalid number");
            }
            return number;
        }
    }
}

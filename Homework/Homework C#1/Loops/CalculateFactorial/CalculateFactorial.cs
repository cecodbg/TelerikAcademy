// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
// Use only one loop. Print the result with 5 digits after the decimal point.

using System;

namespace CalculateFactorial
{
    class CalculateFactorial
    {
        static void Main()
        {
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter number x: ");
            int x = int.Parse(Console.ReadLine());

            int factorial = 1;
            double sum = 1;
            double del = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                del = Math.Pow(x, i);
                sum += (factorial / del);
            }
            Console.WriteLine("Sum is {0:F5}", sum);
        }
    }
}

// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;
using System.Globalization;
using System.Threading;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter coefficient a (different from 0): ");
            double a;
            bool isCorrect = double.TryParse(Console.ReadLine(), out a);

            while (a == 0 || isCorrect == false)
            {
                Console.Write("{0,-40}", "In correct input! Try again: ");
                isCorrect = double.TryParse(Console.ReadLine(), out a);
            }

            Console.Write("{0,-40}", "Enter coefficient b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("{0,-40}", "Enter coefficient c: ");
            double c = double.Parse(Console.ReadLine());

            double d;  // Discriminant
            d = (b * b) - (4 * (a * c));

            double x1;
            double x2;

            if (d == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("x1 = x2 = {0}", x1);
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
            }
            else if (d < 0)
            {
                Console.WriteLine("No real roots");
            }
        }
    }
}

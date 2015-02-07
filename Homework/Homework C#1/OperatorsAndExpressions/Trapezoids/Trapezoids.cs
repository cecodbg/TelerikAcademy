//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
using System.Globalization;
using System.Threading;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter side A");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height H");
            double heightH = double.Parse(Console.ReadLine());

            double area = 0.5 * heightH * (sideA + sideB);

            Console.WriteLine(area);
        }
    }
}

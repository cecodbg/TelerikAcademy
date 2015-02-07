//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;
using System.Globalization;
using System.Threading;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter coordinate X:");
            double coorX = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate Y:");
            double coorY = double.Parse(Console.ReadLine());
            int radius = 2;

            bool inCircle = ((coorX * coorX) + (coorY * coorY)) <= (radius * radius);

            Console.WriteLine(inCircle);
        }
    }
}

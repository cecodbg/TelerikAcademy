// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;
using System.Globalization;
using System.Threading;

namespace PointInsideACircleAndOutsideOfARectangle
{
    class PointInsideACircleAndOutsideOfARectangle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enteer coordinate X:");
            double coordinateX = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter ccoordinate Y:");
            double coordinateY = double.Parse(Console.ReadLine());
            double radius = 1.5;

            bool inCircle = ((coordinateX - 1) * (coordinateX - 1) + (coordinateY - 1) * (coordinateY - 1)) <= radius * radius;
            bool outRectangle = ((coordinateX < -1) || (coordinateX > 5)) || ((coordinateY > 1) || (coordinateY < -1));

            if (inCircle && outRectangle)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

// Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;
using System.Globalization;
using System.Threading;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            double height = double.Parse(Console.ReadLine());

            double perimeter = (width * 2) + (height * 2);
            double area = width * height;

            Console.WriteLine("Perimeter is {0} and area is {1}", perimeter, area);
        }
    }
}

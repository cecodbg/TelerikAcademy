namespace Shapes
{
    using System;
    using System.Globalization;
    using System.Threading;

    class ShapesTest
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Shape[] shapes = new Shape[]
            {
                new Square(2.5), 
                new Rectangle(2, 5),
                new Triangle(5.5, 5)
            };

            foreach (var item in shapes)
            {
                Console.WriteLine(item.CalculateSurface());
            }
        }
    }
}

// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it;
// Three sides;
// Two sides and an angle between them;
// Use System.Math.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TriangleSurface
{
    class TriangleSurface
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("For calculate the surface of a triangle by given:\nSide and an altitude to it enter 1:\nThree sides enter 2:\nTwo sides and an angle between them enter 3:");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter side: ");
                    double sideA = double.Parse(Console.ReadLine());
                    Console.Write("Enter altitude to it: ");
                    double altitude = double.Parse(Console.ReadLine());
                    Console.WriteLine("The surface is: {0}", SurfaceSideAltitude(sideA, altitude));
                    break;
                case 2:
                    Console.Write("Enter side A: ");
                    sideA = double.Parse(Console.ReadLine());
                    Console.Write("Enter side B: ");
                    double sideB = double.Parse(Console.ReadLine());
                    Console.Write("Enter side C: ");
                    double sideC = double.Parse(Console.ReadLine());
                    Console.WriteLine("The surface is: {0}", SurfaceTreeSides(sideA, sideB, sideC));
                    break;
                case 3:
                    Console.Write("Enter side A: ");
                    sideA = double.Parse(Console.ReadLine());
                    Console.Write("Enter side B: ");
                    sideB = double.Parse(Console.ReadLine());
                    Console.Write("Enter angle in degrees: ");
                    double angle = double.Parse(Console.ReadLine());
                    Console.WriteLine("The surface is: {0}", SurfaceTweSidesAndAngle(sideA, sideB, angle));
                    break;
                default:
                    break;
            }
        }

        static double SurfaceTreeSides(double sideA, double sideB, double sideC)
        {
            double result = 0;
            double perimeter = (sideA + sideB + sideC) / 2;
            result = Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));

            return result;
        }

        static double SurfaceSideAltitude(double side, double altitude)
        {
            double result = (side * altitude) / 2;

            return result;
        }

        static double SurfaceTweSidesAndAngle(double sideA, double sideB, double angleDegrees)
        {
            double result = 0;
            double angle = (Math.PI * angleDegrees) / 180.0;
            result = (sideA * sideB * Math.Sin(angle)) / 2;

            return result;
        }
    }
}

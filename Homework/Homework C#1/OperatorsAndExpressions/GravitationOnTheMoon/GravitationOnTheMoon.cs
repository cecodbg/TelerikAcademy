// The gravitational field of the Moon is approximately 17% of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;
using System.Globalization;
using System.Threading;

namespace GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter the weight of a men on the Earth: ");
            double weightEarth = double.Parse(Console.ReadLine());
            double moonIsApproximately = 17.0 / 100;
            double weightMoon = weightMoon = moonIsApproximately * weightEarth;

            Console.WriteLine("Weight on the Moon is: {0}", weightMoon);
        }
    }
}

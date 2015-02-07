// A beer time is after 1:00 PM and before 3:00 AM.
// Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

using System;
using System.Globalization;
using System.Threading;

namespace BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter time now in format (hh:mm tt) example 9:22 am: ");
            DateTime beerTime = DateTime.Parse(Console.ReadLine());
            
            DateTime lowTime = Convert.ToDateTime("1:00 pm");
            DateTime highTime = Convert.ToDateTime("3:00 pm");
            if ((beerTime > lowTime) && (beerTime < highTime))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
    }
}

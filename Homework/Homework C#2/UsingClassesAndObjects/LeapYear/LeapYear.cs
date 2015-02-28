// Write a program that reads a year from the console and checks whether it is a leap one.
// Use System.DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            Console.Write("Enter year to check: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Year {0} {1} a leap", year, DateTime.IsLeapYear(year) ? "is" : "not");
        }
    }
}

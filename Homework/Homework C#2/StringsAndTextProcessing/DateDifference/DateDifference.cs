// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDifference
{
    class DateDifference
    {
        static void Main()
        {
            Console.Write("Enter first date in the format dd.MM.yyyy: ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Console.Write("Enter second date in the format dd.MM.yyyy: ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            double days = (secondDate - firstDate).TotalDays;
            Console.WriteLine(days);
        }
    }
}

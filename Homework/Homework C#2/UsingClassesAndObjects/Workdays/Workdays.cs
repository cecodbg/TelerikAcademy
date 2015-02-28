// Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified    preliminary as array.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Workdays
{
    class Workdays
    {
        static DateTime[] Holidays =
            {
             new DateTime(2015,01,01),
             new DateTime(2015,03,03),
             new DateTime(2015,04,10),
             new DateTime(2015,04,13),
             new DateTime(2015,05,01),
             new DateTime(2015,05,06),
             new DateTime(2015,09,21),
             new DateTime(2015,12,24),
             new DateTime(2015,12,25),
            };

        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Enter date for check in format m. d. yyyy: ");
            DateTime dateCheck = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Working days: {0}", CalculatesWorkdays(dateCheck));

        }

        static int CalculatesWorkdays(DateTime dateCheck)
        {
            DateTime endDate = new DateTime(2015, 12, 31);
            DateTime dateNow = DateTime.Now;
            int counter = 0;

            for (int i = 0; i < 366; i++)
            {
                dateNow = dateNow.AddDays(1);
                if (dateNow.DayOfWeek != DayOfWeek.Sunday && dateNow.DayOfWeek != DayOfWeek.Saturday)
                {
                    counter++;
                    for (int j = 0; j < Holidays.Length; j++)
                    {
                        if (dateNow.Date.CompareTo(Holidays[j].Date) == 0)
                        {
                            counter--;
                        }   
                    }
                }
                if (endDate.Date.CompareTo(dateNow.Date) == 0)
                {
                    break;
                }
            }

            return counter;
        }
    }
}

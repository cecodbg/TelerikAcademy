// Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DateInBulgarian
{
    class DateInBulgarian
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            CultureInfo culture = CultureInfo.GetCultureInfo("bg-BG");

            Console.Write("Enter first date in the format dd.MM.yyyy HH:mm:ss: ");
            string format = "dd.MM.yyyy HH:mm:ss";
            DateTime inputDate = DateTime.ParseExact(Console.ReadLine(), format, culture)
                                         .AddHours(6)
                                         .AddMinutes(30);

            Console.Write("{0} ", inputDate);

            switch (inputDate.DayOfWeek)
            {
                case DayOfWeek.Friday: Console.WriteLine("Петък");
                    break;
                case DayOfWeek.Monday: Console.WriteLine("Понеделник");
                    break;
                case DayOfWeek.Saturday: Console.WriteLine("Събота");
                    break;
                case DayOfWeek.Sunday: Console.WriteLine("Неделя");
                    break;
                case DayOfWeek.Thursday: Console.WriteLine("Четвъртък");
                    break;
                case DayOfWeek.Tuesday: Console.WriteLine("Вторник");
                    break;
                case DayOfWeek.Wednesday: Console.WriteLine("Сряда");
                    break;
                default:
                    break;
            }
        }
    }
}

// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
// Display them in the standard date format for Canada.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace DatesFromTextInCanada
{
    class DatesFromTextInCanada
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string text = "02.11.2015 05.5.2015 2.1.2015 2.10.2015";
            string format = "d.M.yyyy";

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            CultureInfo culture = Thread.CurrentThread.CurrentCulture;

            foreach (var match in Regex.Matches(text, @"[\d]{1,2}.[\d]{1,2}.[\d]{4}"))
            {
                try
                {
                    DateTime check = DateTime.ParseExact(match.ToString(), format, culture);
                    Console.WriteLine(check.ToShortDateString());
                }
                catch (FormatException)
                {
                    continue;
                }
            } 
        }
    }
}

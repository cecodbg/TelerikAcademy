// Write a program for extracting all email addresses from given text.
// All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace ExtractEMails
{
    class ExtractEMails
    {
        static void Main()
        {
            string inputString = "Here is my email @ gmail - e.georgieva@gmail.com ! You can find me also at emi20@abv.bg";

            foreach (var match in Regex.Matches(inputString, @"[A-Za-z._0-9]+@[A-Za-z0-9]+.[A-Z a-z]{2,3}"))
            {
                try
                {
                    MailAddress address = new MailAddress(match.ToString());
                    Console.WriteLine(address);
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }
    }
}

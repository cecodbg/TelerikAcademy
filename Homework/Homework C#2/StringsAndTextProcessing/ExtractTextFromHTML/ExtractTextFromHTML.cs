// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractTextFromHTML
{
    class ExtractTextFromHTML
    {
        static void Main()
        {
            string inputString = @"<html>
<head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practical training for young people who want to turn intoskilful .NET software engineers.</p></body></html>";

            MatchCollection str = Regex.Matches(inputString, @"(?<=^|>)[^><]+?(?=<|$)");
            
            int counter = 1;
            foreach (Match st in str)
            {
                if (counter == 1)
                {
                    Console.WriteLine("Title: {0}", st);
                    Console.Write("Text:  ");
                }
                else
                {
                    Console.Write(st + " ");
                }
                counter++;
            }
        }
    }
}

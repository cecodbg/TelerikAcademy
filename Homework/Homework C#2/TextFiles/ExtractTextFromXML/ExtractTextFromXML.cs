// Write a program that extracts from given XML file all the text without the tags.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractTextFromXML
{
    class ExtractTextFromXML
    {
        static void Main()
        {
            string inString = @"<?xml version=""1.0""><student><name>Pesho</name><age>21</age><interests count=""3""><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>";
            var result = new StringBuilder();

            bool inTag = false;
            bool outTag = true;

            foreach (var ch in inString)
            {
                if (outTag)
                {
                    if (ch == '<')
                    {
                        inTag = true;
                        outTag = false;
                    }
                    else
                    {
                        result.Append(ch);
                    }
                }
                else if (inTag)
                {
                    if (ch == '>')
                    {
                        inTag = false;
                        outTag = true;
                    }
                }
            }

            //for (int i = 0; i < inString.Length - 2; i++)
            //{
            //    if (inString[i] == '<')
            //    {
            //        inTag = false;
            //        outTag = false;
            //    } 
            //    if (inString[i] == '>' && inString[i + 1] != '<')
            //    {
            //        outTag = true;
            //        inTag = true;
            //    }
            //    if (inTag && outTag)
            //    {
            //        result.Append(inString[i]);
            //    }
            //}
            //result.Replace('>', ' ');
            //result.Remove(0, 1);
            Console.WriteLine(result);
        }
    }
}

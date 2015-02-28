// You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
// The tags cannot be nested.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class ParseTags
    {
        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            StringBuilder sb = new StringBuilder(text.Length);

            string start = "<upcase>";
            string end = "</upcase>";
            int foundStart = text.IndexOf(start);
            int foundEnd = text.IndexOf(end);

            sb.Append(text.Substring(0, foundStart));
            sb.Append(text.Substring(foundStart + start.Length, foundEnd - foundStart - start.Length).ToUpper());
            foundStart = text.IndexOf(start, foundStart + start.Length);
            sb.Append(text.Substring(foundEnd + end.Length, foundStart - foundEnd - end.Length));
            foundEnd = text.IndexOf(end, foundStart + start.Length);
            sb.Append(text.Substring(foundStart + start.Length, foundEnd - foundStart - start.Length).ToUpper());
            sb.Append(text.Substring(foundEnd + end.Length, text.Length - foundEnd - end.Length));

            Console.WriteLine(sb.ToString());
        }
    }
}

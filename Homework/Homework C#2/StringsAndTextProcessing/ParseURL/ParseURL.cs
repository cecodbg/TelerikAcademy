// Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
// http://telerikacademy.com/Courses/Courses/Details/212

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Enter URL sddress:");
            string inputString = Console.ReadLine();

            int index = inputString.IndexOf(':');
            string protocol = inputString.Substring(0, index);
            int index2 = inputString.IndexOf('/', index + 3);
            string server = inputString.Substring(index + 3, index2 - (index + 3));
            int end = inputString.Length - index - index2 + 4;
            string resource = inputString.Substring(index2, end);
            Console.WriteLine("[protocol] {0}", protocol);
            Console.WriteLine("[server]   {0}", server);
            Console.WriteLine("[resource] {0}", resource);

            //Uri instr = new Uri(inputString);
            //string protocol = instr.Scheme;
            //string server = instr.Host;
            //string resource = instr.AbsolutePath;

            //Console.WriteLine("[protocol]  {0}\n[server]    {1}\n[resource]  {2}", protocol, server, resource);
        }
    }
}

// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter file path to read:");
            string readPath = Console.ReadLine();
            Console.WriteLine("Enter file path to write:");
            string writePath = Console.ReadLine();
            
            StreamReader reader = new StreamReader(readPath);
            StreamWriter writer = new StreamWriter(writePath);
            string[] str = reader.ReadToEnd().Split('\n');
            for (int i = 0; i < str.Length; i++)
            {
                writer.Write("{0}.", i + 1);
                writer.WriteLine(str[i]);
            }
            writer.Close();
            reader.Close();
        }
    }
}

// Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    class OddLines
    {
        static void Main()
        {
            Console.WriteLine("Enter file path:");
            string path = Console.ReadLine();

            StreamReader reader = new StreamReader(path);
            string[] text = reader.ReadToEnd().Split('\n');
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(text[i]);
                }
            }
            reader.Close();
        }
    }
}

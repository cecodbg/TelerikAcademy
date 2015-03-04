// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SaveSortedNames
{
    class SaveSortedNames
    {
        static void Main()
        {
            Console.WriteLine("Enter input file path to sort:");
            string inPathString = Console.ReadLine();
            Console.WriteLine("Enter output file path:");
            string outPathString = Console.ReadLine();

            var reader = new StreamReader(inPathString);
            var writer = new StreamWriter(outPathString);
            using (reader)
            {
                using (writer)
                {
                    string[] sorted = reader.ReadToEnd().Split('\n').OrderBy(x => x).ToArray();

                    for (int i = 0; i < sorted.Length; i++)
                    {
                        writer.WriteLine(sorted[i]);
                    }
                }
            }
        }
    }
}

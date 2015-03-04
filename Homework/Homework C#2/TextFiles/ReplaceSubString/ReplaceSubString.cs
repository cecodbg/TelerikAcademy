// Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
// Ensure it will work with large files (e.g. 100 MB).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ReplaceSubString
{
    class ReplaceSubString
    {
        static void Main()
        {
            Console.WriteLine("Enter input file path to sort:");
            string inPathString = Console.ReadLine();
            Console.WriteLine("Enter output file path:");
            string outPathString = Console.ReadLine();
            string subString = "start";
            string subStringReplace = "finish";

            var reader = new StreamReader(inPathString);
            var writer = new StreamWriter(outPathString);
            
            using (reader)
            {
                using (writer)
                {
                    bool isTrue = true;
                    while (isTrue)
                    {
                        string replace = reader.ReadLine().Replace(subString, subStringReplace);
                        writer.WriteLine(replace);
                        if (reader.Peek() < 0)
                        {
                            isTrue = false;
                        }
                    }
                }
            }
        }
    }
}

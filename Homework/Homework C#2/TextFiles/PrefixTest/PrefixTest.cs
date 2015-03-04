// Write a program that deletes from a text file all words that start with the prefix test.
// Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixTest
{
    class PrefixTest
    {
        static void Main()
        {
            string prefix = "test";

            using (StreamReader reader = new StreamReader(@"..\..\Files\input.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\Files\output.txt"))
                {
                    string line = string.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                             .Where(x => !x.StartsWith(prefix))
                                             .ToArray();
                        writer.WriteLine(string.Join(" ", words));
                    }
                }
            }
        }
    }
}

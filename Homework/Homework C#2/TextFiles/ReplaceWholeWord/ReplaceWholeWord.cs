// Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceWholeWord
{
    class ReplaceWholeWord
    {
        static void Main()
        {
            Console.WriteLine("Enter input file path to sort:");
            string inPathString = Console.ReadLine();
            Console.WriteLine("Enter output file path:");
            string outPathString = Console.ReadLine();
            string subString = " start";
            string subStringReplace = " finish";

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

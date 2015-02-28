// Write a program that reverses the words in given sentence.
// C# is not C++, not PHP and not Delphi!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentence
{
    class ReverseSentence
    {
        static void Main()
        {
            Console.WriteLine("Enter text:");
            string inputString = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            int found = inputString.IndexOf(',');
            string firstResult = inputString.Substring(0, found);
            int foundMidle = inputString.IndexOf("not");
            string midleResult = inputString.Substring(found, 6);
            int lastFound = inputString.IndexOf('!');
            string lastResult = inputString.Substring(foundMidle + found, lastFound - foundMidle - found);

            result.Append(Reverse(lastResult));
            result.Append(midleResult);
            result.Append(Reverse(firstResult));
            result.Append('!');
            Console.WriteLine(result);
        }

        static string Reverse(string reverse)
        {
            string[] array = reverse.Split(' ')
                                    .Select(x => x.ToString())
                                    .Reverse()
                                    .ToArray();
            string text = string.Empty;
            return text = string.Join(" ", array);
        }
    }
}

// Write a program that converts a string to a sequence of C# Unicode character literals.
// Use format strings.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            foreach (var item in text)
            { 
            Console.Write(string.Format("\\{0:X4}", (int)item));
            Console.WriteLine();
            }
        }
    }
}

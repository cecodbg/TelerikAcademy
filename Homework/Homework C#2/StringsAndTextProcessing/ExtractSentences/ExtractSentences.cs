// Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences
{
    class ExtractSentences
    {
        static void Main()
        {
            Console.WriteLine("Enter given text:");
            string[] inputText = Console.ReadLine()
                                   .Split(new char[] { '.', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(x => x.ToString())
                                   .ToArray();
            Console.WriteLine();
            Console.WriteLine("Enter given word:");
            string word = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < inputText.Length; i++)
            {
                string[] chec = inputText[i].Split(' ').ToArray();
                foreach (var text in chec)
                {
                    
                    if (text == word)
                    {
                        sb.Append(inputText[i]);
                        sb.Append('.');
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

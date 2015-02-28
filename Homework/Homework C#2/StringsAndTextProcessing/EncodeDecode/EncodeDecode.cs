// Write a program that encodes and decodes a string using given encryption key (cipher).
// The key consists of a sequence of characters.
// The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string  with the first of the key, the second – with the second, etc. When the last key character is reached, the     next is the first.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeDecode
{
    class EncodeDecode
    {
        static void Main()
        {
            Console.WriteLine("For encoding enter 1\nFor decoding emter 2");
            int choice = int.Parse(Console.ReadLine());
            string key = string.Empty;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter text to encoding:");
                    string inputString = Console.ReadLine();
                    Console.WriteLine("Enter key:");
                    key = Console.ReadLine();
                    Console.WriteLine("Encoding text is:\n{0}", Encoding(inputString, key));
                    break;
                case 2:
                    Console.WriteLine("Enter text to decoding:");
                    int[] numbers = Console.ReadLine()
                                           .Split(new char[] { '.', ' ', ',', '\t' },               StringSplitOptions.RemoveEmptyEntries)
                                           .Select(x => int.Parse(x))
                                           .ToArray();
                    Console.WriteLine("Enter key:");
                    key = Console.ReadLine();
                    Console.WriteLine("Decoding text is:\n{0}", Decoding(numbers, key));
                    break;
                default:
                    break;
            }
        }

        static string Encoding(string inputString, string key)
        {
            StringBuilder encodString = new StringBuilder();
            int j = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (j < key.Length)
                {
                    encodString.Append(inputString[i] ^ key[j]);
                    encodString.Append(".");
                    j++;
                }
                else
                {
                    encodString.Append(inputString[i] ^ key[0]);
                    encodString.Append(".");
                    j = 1;
                }
            }
            string result = encodString.ToString();
            return result;
        }

        static string Decoding(int[] numbers, string key)
        {
            StringBuilder decoding = new StringBuilder();
            int j = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (j < key.Length)
                {
                    char ch = (char)(numbers[i] ^ key[j]);
                    decoding.Append(ch);
                    j++;
                }
                else
                {
                    char ch = (char)(numbers[i] ^ key[0]);
                    decoding.Append(ch);
                    j = 1;
                }
            }
            string result = decoding.ToString();
            return result;
        }
    }
}


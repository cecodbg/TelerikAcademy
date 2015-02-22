// Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToBinary
{
    class HexadecimalToBinary
    {
        static void Main()
        {
            Console.Write("Enter number to convert 0x... : ");
            string[] str = Console.ReadLine()
                                  .Select(x => x.ToString())
                                  .ToArray();
            
            Dictionary<string, string> hexBin = new Dictionary<string, string>()
            {
            {"0", "0000"}, {"1", "0001"}, {"2", "0010"}, {"3", "0011"}, 
            {"4", "0100"}, {"5", "0101"}, {"6", "0110"}, {"7", "0111"},
            {"8", "1000"}, {"9", "1001"}, {"A", "1010"}, {"a", "1010"}, 
            {"B", "1011"}, {"b", "1011"}, {"c", "1100"}, {"C", "1100"}, 
            {"D", "1101"}, {"d", "1101"}, {"E", "1110"}, {"e", "1110"},
            {"F", "1111"}, {"f", "1111"},
            };

            List<string> result = new List<string>();
            for (int i = 2; i < str.Length; i++)
            {
                foreach (var pair in hexBin)
                {
                    if (str[i] == pair.Key)
                    {
                        result.Add(pair.Value);
                    }
                }
            }

            Console.WriteLine("After convert number is:\n{0}", string.Join(" ", result));
        }
    }
}

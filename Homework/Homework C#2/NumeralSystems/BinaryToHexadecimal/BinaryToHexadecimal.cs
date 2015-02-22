// Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main()
        {
            Console.WriteLine("Eneter numbers to convert: ");
            List<string> numbers = Console.ReadLine()
                                   .Select(x => Convert.ToString(x))
                                   //.Reverse()
                                   .ToList();
            while (numbers.Count % 4 != 0)
            {
                numbers.Insert(0, "0");
            }

           // numbers.Reverse();
            List<string> result = new List<string>();
            string strings = string.Empty;

            Dictionary<string, string> hexBin = new Dictionary<string, string>()
            {
            {"0", "0000"}, {"1", "0001"}, {"2", "0010"}, {"3", "0011"}, 
            {"4", "0100"}, {"5", "0101"}, {"6", "0110"}, {"7", "0111"},
            {"8", "1000"}, {"9", "1001"}, {"A", "1010"}, {"B", "1011"}, 
            {"C", "1100"}, {"D", "1101"}, {"E", "1110"}, {"F", "1111"},
            };

            for (int i = 0; i < numbers.Capacity; i += 4)
            {
                for (int j = i; j < i + 4; j++)
                {
                    strings += numbers[j];
                }
                if (strings == "0000")
                {
                    break;
                }
                foreach (var pair in hexBin)
                {
                    if (strings == pair.Value)
                    {
                        result.Add(pair.Key);
                    }
                }
                strings = string.Empty;
            }
            //result.Reverse(); 
            Console.WriteLine("After vonvert number is: 0x{0}", string.Join("", result));
        }
    }
}

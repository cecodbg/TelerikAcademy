// Write a program that concatenates two text files into another text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main()
        {
            Console.WriteLine("Enter first text file path:");
            string firstText = Console.ReadLine();
            Console.WriteLine("Enter second text file path:");
            string secondText = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            StreamReader firstReader = new StreamReader(firstText);
            StreamReader secondReader = new StreamReader(secondText);

            result.Append(firstReader.ReadToEnd());
            result.Append(secondReader.ReadToEnd());
            Console.WriteLine(result);
            firstReader.Close();
            secondReader.Close();
        }
    }
}

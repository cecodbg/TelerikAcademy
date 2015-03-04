// Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
// Assume the files have equal number of lines.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompareTextFiles
{
    class CompareTextFiles
    {
        static void Main()
        {
            Console.WriteLine("Enter first file path to compare:");
            string firstText = Console.ReadLine();
            Console.WriteLine("Enter first file path to compare:");
            string secondText = Console.ReadLine();

            StreamReader firstReader = new StreamReader(firstText);
            StreamReader secondReader = new StreamReader(secondText);
            int countSame = 0;
            int countDiff = 0;
            bool isTrue = true;

            while (isTrue)
            {
                string[] firstString = firstReader.ReadLine().Split(' ');
                string[] secondString = secondReader.ReadLine().Split(' ');
                if (firstString.Length == secondString.Length)
                {
                    for (int i = 0; i < firstString.Length; i++)
                    {
                        if (firstString[i] == secondString[i])
                        {
                            if (i == firstString.Length - 1)
                            {
                                countSame++;
                            }
                        }
                        else
                        {
                            countDiff++;
                            break;
                        }
                    }
                }
                else
                {
                    countDiff++;
                }
                if (firstReader.Peek() < 0)
                {
                    isTrue = false;
                }
            }

            firstReader.Close();
            secondReader.Close();
            Console.WriteLine("The number of lines that are the same is: {0}\nThe number of lines that are different is: {1}", countSame, countDiff);
        }
    }
}

// Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCount
{
    class LettersCount
    {
        static void Main()
        {
            string inputString = "Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.";
            string lowerString = inputString.ToLower();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            int found = 0;
            int count = 0;
            int index = 0;
            for (int i = 0; i < alphabet.Length; i++)
            {
                count = 0;
                index = 0;
                while (true)
                {
                    found = lowerString.IndexOf(alphabet[i], index);
                    if (found >= 0)
                    {
                        count++;
                        index = found + 1;
                    }
                    else
                    {
                        if (count > 0)
                        {
                            Console.WriteLine("The letter \"{0}\" is found {1} time/s", alphabet[i], count);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}

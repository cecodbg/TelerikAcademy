// Find online more information about ASCII and write a program that prints the entire ASCII table
// of characters on the console (characters from 0 to 255).

using System;

namespace PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main()
        {
           // Console.OutputEncoding = System.Text.Encoding.UTF8;
           // Console.OutputEncoding = System.Text.Encoding.Unicode;
            for (int i = 0; i <= 255; i++)
            {
                char c = Convert.ToChar(i);

                if (!char.IsControl(c))
                {
                    Console.WriteLine(i + "\t" + c);
                }
            }
        }
    }
}

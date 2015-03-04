// Write a program that deletes from given text file all odd lines.
// The result should be in the same file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main()
        {
            string inPathString = Console.ReadLine();
            string tempPath = Console.ReadLine();
            var reader = new StreamReader(inPathString);
            var tempWriter = new StreamWriter(tempPath);

            ReadFile(reader, tempWriter);

            var readerTemp = new StreamReader(tempPath);
            var writer = new StreamWriter(inPathString);

            WriteFile(readerTemp, writer);
        }

        static void ReadFile(StreamReader reader, StreamWriter tempWriter)
        {
            bool isTrue = true;
            int count = 1;

            using (reader)
            {
                using (tempWriter)
                {
                    string tempString = string.Empty;
                    while (isTrue)
                    {
                        if (count % 2 != 0)
                        {
                            tempString = reader.ReadLine();
                            tempWriter.WriteLine(tempString);
                            tempString = reader.ReadLine();
                        }
                        count++;
                        if (reader.Peek() < 0)
                        {
                            isTrue = false;
                        }
                    }
                }
            }
        }

        static void WriteFile(StreamReader readerTemp, StreamWriter writer)
        {
            string read = string.Empty;
            using (readerTemp)
            {
                using (writer)
                {
                    while (read != null)
                    {
                        read = readerTemp.ReadLine();
                        writer.WriteLine(read);
                    }
                }
            }
        }
    }
}

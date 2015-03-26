using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
        
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var numberAsString = line.Split(' ');
                int[] array = new int[numberAsString.Length];

                for (int j = 0; j < numberAsString.Length; j++)
                {
                    array[j] = int.Parse(numberAsString[j]);
                }

                int[] result = new int[array.Length - 1];

                for (int h = 0; h < array.Length - 1; h++)
                {
                    int resultMax = Math.Max(array[h], array[h + 1]);
                    int resultMin = Math.Min(array[h], array[h + 1]);
                    int totalResult = resultMax - resultMin;
                    result[h] = totalResult;
                }

                bool isTrue = true;

                for (int r = 0; r < result.Length - 1; r++)
                {
                    if ((result[r] - result[r + 1]) != 1 && (result[r] - result[r + 1]) != 0)
                    {
                        isTrue = false;
                        break;
                    }
                }
                Console.WriteLine("{0}", isTrue);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                               .Select(x => x.ToString())
                                               .ToArray();

            string alfabeth = "abcdefghijklmnopqrstuvwxyz";

            StringBuilder result = new StringBuilder();
            StringBuilder res = new StringBuilder();
           
            
            foreach (var item in input)
            {
            int[] decimalA = new int[item.Length];
                var strWord = item;

                for (int i = 0; i < item.Length; i++)
                {
                    for (int j = 0; j < alfabeth.Length; j++)
                    {
                        if (item[i] == alfabeth[j])
                        {
                            decimalA[i] = j;
                        }
                    }
                }

                BigInteger decimalRepresentation = 0;
                for (int i = 0; i < item.Length; i++)
                {
                    decimalRepresentation *= 17;
                    decimalRepresentation += decimalA[i];
                }

                List<BigInteger> binary = new List<BigInteger>();
                while (decimalRepresentation > 0)
                {
                    binary.Add(decimalRepresentation % 26);
                    decimalRepresentation /= 26;
                }

                binary.Reverse();

                for (int i = 0; i < binary.Count; i++)
                {
                    for (int j = 0; j < alfabeth.Length; j++)
                    {
                        if (binary[i] == j)
                        {
                            res.Append(alfabeth[j].ToString());
                        }
                    }
                }
                res.Append(" ");

                binary.Clear();
                

            }
           
                result.Append(res);
                Console.WriteLine(result);
        }
    }
}

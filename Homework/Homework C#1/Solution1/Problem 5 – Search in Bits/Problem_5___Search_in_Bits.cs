using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5___Search_in_Bits
{
    class Problem_5___Search_in_Bits
    {
        static void Main(string[] args)
        {
            //reshenie s bitove 1
            //int s = int.Parse(Console.ReadLine());
            //int[] digits = new int[n];
            //int count = 0;
            //int result = 0;
           
            //do
            //{
            //    digits[count] = int.Parse(Console.ReadLine());
            //    count++;
            //} while (count < n);

            ////int mask = Convert.ToInt32(int.Parse(sBin));
            //int mask = s;
            //for (int i = 0; i < digits.Length; i++)
            //{
            //    mask = s;

            //    for (int j = 0; j < 27; j++)
            //    {
            //        //long chec = digits[i] & mask;
            //        if (((digits[i] >> j) & 15) == (mask & 15))
            //        {
            //            result++;
            //        }
            //        //mask = mask << 1;
            //    }
            //}
            //Console.WriteLine(result);

            // reshenie s stringove
            /*string s = Console.ReadLine();
            string sBin = Convert.ToString(int.Parse(s), 2).PadLeft(4, '0');



            //int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string str = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(30, '0');
                int lastIndexOf = str.IndexOf(sBin);
                while (lastIndexOf != -1)
                {
                    count++;
                    lastIndexOf = str.IndexOf(sBin, lastIndexOf + 1);
                }
            }

            Console.WriteLine(count);*/
        }
    }
}

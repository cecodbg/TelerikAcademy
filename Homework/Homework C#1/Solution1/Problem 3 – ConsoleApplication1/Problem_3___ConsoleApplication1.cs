using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Problem_3___ConsoleApplication1
{
    class Problem_3___ConsoleApplication1
    {
        static void Main(string[] args)
        {
            //int a;
            //List<int> numbers = new List<int>();
            //bool isCorrect = false;

            //isCorrect = int.TryParse(Console.ReadLine(), out a);
            //while (isCorrect)
            //{
            //    numbers.Add(int.Parse(Console.ReadLine()));
            //}
            BigInteger a;
            //long sum = 1;
            //long counter = 0;
            List<BigInteger> numbers = new List<BigInteger>();
            bool isCorrect = BigInteger.TryParse(Console.ReadLine(), out a);
            while (isCorrect)
            {
                if (a == 0)
                {
                    a = 1;
                }
                BigInteger sum = 1;
                while (a > 0)
                {
                    while (a % 10 == 0)
                    {
                        a /= 10;
                    }
                    sum *= a % 10;
                    a /= 10;
                }
                //counter++;
                numbers.Add(sum);
                isCorrect = BigInteger.TryParse(Console.ReadLine(), out a);
            }

            BigInteger bigSum1 = 1;
            BigInteger bigSum2 = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i < 10 && i % 2 != 0)
                {
                    bigSum1 *= numbers[i];
                }
                else if (i > 10 && i % 2 != 0)
                {
                    bigSum2 *= numbers[i];
                }

            }
            if (numbers.Count <= 10)
            {
                Console.WriteLine(bigSum1);
            }
            else
            {
                Console.WriteLine(bigSum1);
                Console.WriteLine(bigSum2);
            }
        }
    }
}

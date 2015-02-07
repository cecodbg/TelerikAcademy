using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double biggest = 0;
            double smallest = 0;
            double sum = 0;

            biggest = Math.Max(Math.Max(a, b), c);
            smallest = Math.Min(Math.Min(a, b), c);
            sum = (a + b + c) / 3;

            Console.WriteLine(biggest);
            Console.WriteLine(smallest);
            Console.WriteLine("{0:0.00}", sum);
        }
    }
}

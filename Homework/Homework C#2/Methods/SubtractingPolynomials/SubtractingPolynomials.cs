// Extend the previous program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtractingPolynomials
{
    class SubtractingPolynomials
    {
        static void Main()
        {
            Console.WriteLine("Eneter coefficients first polynomial separated by a comma: ");
            double[] firstPolynomial = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .Reverse()
                .ToArray();

            Console.WriteLine("Eneter coefficients second polynomial, separated by a comma: ");
            double[] secondPolynomial = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .Reverse()
                .ToArray();

            Console.WriteLine(string.Join(", ", AddPolynomials(firstPolynomial, secondPolynomial)));
        }

        static List<double> AddPolynomials(double[] firstPolynomial, double[] secondPolynomial)
        {
            List<double> result = new List<double>();
            for (int i = 0; i < firstPolynomial.Length; i++)
            {
                for (int j = i; j < secondPolynomial.Length; j++)
                {
                    result.Add(firstPolynomial[i] + -secondPolynomial[j]);
                    break;
                }
            }
            return result;
        }
    }
}

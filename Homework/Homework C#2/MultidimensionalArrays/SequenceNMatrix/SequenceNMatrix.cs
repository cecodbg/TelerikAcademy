// We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
// Write a program that finds the longest sequence of equal strings in the matrix.
//       matrix	          result	
// ha	fifi  ho	hi
// fo	ha	  hi	xx   ha, ha, ha
// xxx	ho	  ha	xx


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceNMatrix
{
    class SequenceNMatrix
    {
        static void Main(string[] args)
        {
            string[,] matrix = new string[,]
            {{"ha", "fifi", "ho", "hi"},
             {"fo", "ha", "ho", "xx"},
             {"xxx", "h", "h", "xx"},
             {"hi", "ho", "xx", "xx"},
            };

            int counter = 1;

            int lineResult = 0;
            string lineString = string.Empty;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                counter = 1;
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    if (matrix[r, c] == matrix[r, c + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > lineResult)
                    {
                        lineResult = counter;
                        lineString = matrix[r, c];
                    }
                }
            }

            int columnResult = 0;
            string columnString = string.Empty;
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                counter = 1;
                for (int r = 0; r < matrix.GetLength(0) - 1; r++)
                {
                    if (matrix[r, c] == matrix[r + 1, c])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > columnResult)
                    {
                        columnResult = counter;
                        columnString = matrix[r, c];
                    }
                }
            }

            int leftDiagonalResult = 0;
            string leftDiagonalString = string.Empty;
            for (int i = 0; i < matrix.GetLength(1) - 1; i++)
            {
                counter = 1;
                for (int r = 0, c = 0 + i; r < matrix.GetLength(0) - 1 && c < matrix.GetLength(1) - 1; r++, c++)
                {
                    if (matrix[r, c] == matrix[r + 1, c + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > leftDiagonalResult)
                    {
                        leftDiagonalResult = counter;
                        leftDiagonalString = matrix[r, c];
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int r = 1 + i, c = 0; r < matrix.GetLength(0) - 1 && c < matrix.GetLength(1); r++, c++)
                {
                    if (matrix[r, c] == matrix[r + 1, c + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > leftDiagonalResult)
                    {
                        leftDiagonalResult = counter;
                        leftDiagonalString = matrix[r, c];
                    }
                }
            }

            int rightDiagonalResult = 0;
            string rightDiagonalString = string.Empty;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int r = 0, c = matrix.GetLength(1) - 1 - i; c > 0; r++, c--)
                {
                    if (matrix[r, c] == matrix[r + 1, c - 1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > rightDiagonalResult)
                    {
                        rightDiagonalResult = counter;
                        rightDiagonalString = matrix[r, c];
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int c = matrix.GetLength(1) - 1, r = 1 + i; r < matrix.GetLength(0) - 1; c--, r++)
                {
                    if (matrix[r, c] == matrix[r + 1, c - 1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > rightDiagonalResult)
                    {
                        rightDiagonalResult = counter;
                        rightDiagonalString = matrix[r, c];
                    }
                }
            }

            if (lineResult > Math.Max(columnResult, Math.Max(leftDiagonalResult, rightDiagonalResult)))
            {
                Console.WriteLine("{0}, line", lineResult);
                Console.WriteLine(lineString);
            }
            else if (columnResult > Math.Max(lineResult, Math.Max(leftDiagonalResult, rightDiagonalResult)))
            {
                Console.WriteLine("{0}, column", columnResult);
                Console.WriteLine(columnString);
            }
            else if (leftDiagonalResult > Math.Max(lineResult, Math.Max(columnResult, rightDiagonalResult)))
            {
                Console.WriteLine("{0}, leftDiagonal", leftDiagonalResult);
                Console.WriteLine(leftDiagonalString);
            }
            else if (rightDiagonalResult > Math.Max(lineResult, Math.Max(columnResult, leftDiagonalResult)))
            {
                Console.WriteLine("{0}, rightDiagonal", rightDiagonalResult);
                Console.WriteLine(rightDiagonalString);
            }
        }
    }
}



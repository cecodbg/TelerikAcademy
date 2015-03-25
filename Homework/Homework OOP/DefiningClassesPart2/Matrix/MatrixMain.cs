namespace Matrix
{
    using System;

    public class MatrixMain
    {
        public static void Main()
        {
            Matrix<int> firstMatrix = new Matrix<int>(5, 5);
            Matrix<int> secondMatrix = new Matrix<int>(5, 5);

            for (int i = 0; i <= firstMatrix.Row - 1; i++)
            {
                for (int j = 0; j <= firstMatrix.Row - 1; j++)
                {
                    firstMatrix[i, j] = i + j + 1;
                    secondMatrix[i, j] = j + 2;
                }
            }

            Console.WriteLine(firstMatrix);

            Console.WriteLine(secondMatrix);

            Console.WriteLine(secondMatrix - firstMatrix);

            Console.WriteLine(firstMatrix + secondMatrix);

            Console.WriteLine(firstMatrix * secondMatrix);
        }
    }
}

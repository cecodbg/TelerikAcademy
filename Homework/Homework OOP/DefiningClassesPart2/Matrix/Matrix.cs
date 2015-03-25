namespace Matrix
{
    using System;
    using System.Text;

    public class Matrix<T> where T : IComparable
    {
        private int row;
        private int col;
        private T[,] matrix;

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.matrix = new T[this.Row, this.Col];
        }

        public int Row
        {
            get
            {
                return this.col;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.row = value;
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.col = value;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= this.matrix.GetLength(0) ||
                    col < 0 || col >= this.matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException();
                }

                return this.matrix[row, col];
            }

            set
            {
                if (row < 0 || row >= this.matrix.GetLength(0) ||
                    col < 0 || col >= this.matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException();
                }

                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.matrix.GetLength(0) != secondMatrix.matrix.GetLength(0)) ||
                (firstMatrix.matrix.GetLength(1) != secondMatrix.matrix.GetLength(1)))
            {
                throw new ArgumentException();
            }

            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.matrix.GetLength(0), firstMatrix.matrix.GetLength(1));

            for (int row = 0; row < firstMatrix.row; row++)
            {
                for (int col = 0; col < firstMatrix.col; col++)
                {
                    resultMatrix[row, col] = (dynamic)firstMatrix[row, col] - secondMatrix[row, col];
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.matrix.GetLength(0) != secondMatrix.matrix.GetLength(0)) ||
                (firstMatrix.matrix.GetLength(1) != secondMatrix.matrix.GetLength(1)))
            {
                throw new ArgumentException();
            }

            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.matrix.GetLength(0), firstMatrix.matrix.GetLength(1));

            for (int row = 0; row < firstMatrix.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < firstMatrix.matrix.GetLength(1); col++)
                {
                    resultMatrix[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.matrix.GetLength(1) != secondMatrix.matrix.GetLength(0))
            {
                throw new ArgumentException();
            }

            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.matrix.GetLength(0), secondMatrix.matrix.GetLength(1));
            
            for (int row = 0; row < resultMatrix.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < resultMatrix.matrix.GetLength(1); col++)
                {
                    dynamic temp = 0;
                    for (int i = 0; i < resultMatrix.matrix.GetLength(1); i++)
                    {
                        temp += (dynamic)firstMatrix[row, i] * secondMatrix[i, col];
                    }

                    resultMatrix[row, col] = temp;
                }
            }

            return resultMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder printMatrix = new StringBuilder();

            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                     printMatrix.Append(this.matrix[row, col] + " ");
                }

                printMatrix.AppendLine();
            }

            return printMatrix.ToString();
        }
    }
}

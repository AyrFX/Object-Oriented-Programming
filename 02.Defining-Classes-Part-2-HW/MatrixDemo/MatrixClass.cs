namespace MatrixDemo
{
    using System;

    public class Matrix<T> where T : struct
    {
        ////Fields
        private int cols;
        private int rows;
        private T[,] array;

        ////Constructors
        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.array = new T[rows, cols];
        }

        ////Properties
        public int Rows
        {
            get
            {
                return this.rows;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
        }

        ////Indexer
        public T this[int rIndex, int cIndex]
        {
            get
            {
                if (rIndex > this.rows - 1 || cIndex > this.cols - 1)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.array[rIndex, cIndex];
            }

            set
            {
                if (rIndex > this.rows - 1 || cIndex > this.cols - 1)
                {
                    throw new IndexOutOfRangeException();
                }

                this.array[rIndex, cIndex] = value;
            }
        }

        ////Operators
        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new ArgumentException("The matrices must be with same size!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(m1.Rows, m1.Cols);
            for (int i = 0; i < resultMatrix.Rows; i++)
            {
                for (int j = 0; j < resultMatrix.Cols; j++)
                {
                    resultMatrix[i, j] = (dynamic)m1[i, j] + m2[i, j];
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new ArgumentException("The matrices must be with same size!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(m1.Rows, m1.Cols);
            for (int i = 0; i < resultMatrix.Rows; i++)
            {
                for (int j = 0; j < resultMatrix.Cols; j++)
                {
                    resultMatrix[i, j] = (dynamic)m1[i, j] - m2[i, j];
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Cols != m2.Rows)
            {
                throw new ArgumentException("The number of columns of the first matrix must be equal to the number of rows of the second matrix!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(m1.Rows, m1.Cols);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m2.Cols; j++)
                {
                    T resultElement = (dynamic)0;
                    for (int k = 0; k < m1.Cols; k++)
                    {
                        resultElement += (dynamic)m1[i, k] * m2[k, j];
                    }

                    resultMatrix[i, j] = resultElement;
                }
            }

            return resultMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}

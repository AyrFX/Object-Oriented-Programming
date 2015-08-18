namespace MatrixDemo
{
    public class MatrixDemoMain
    {
        public static void Main()
        {
            Matrix<int> m1 = new Matrix<int>(2, 2);
            Matrix<int> m2 = new Matrix<int>(2, 2);
            m1[0, 0] = 1;
            m1[0, 1] = 2;
            m1[1, 0] = 3;
            m1[1, 1] = 4;
            m2[0, 0] = 5;
            m2[0, 1] = 6;
            m2[1, 0] = 7;
            m2[1, 1] = 8;
            Matrix<int> m3 = m1 * m2;
            for (int i = 0; i < m3.Rows; i++)
            {
                for (int j = 0; j < m3.Cols; j++)
                {
                    System.Console.Write(m3[i, j] + " ");
                }

                System.Console.WriteLine();
            }

            System.Console.WriteLine(new string('=', 30));
            if (m1)
            {
                System.Console.WriteLine("m1=true");
            }
            else
            {
                System.Console.WriteLine("m1=false");
            }

            System.Console.WriteLine(new string('=', 30));
        }
    }
}

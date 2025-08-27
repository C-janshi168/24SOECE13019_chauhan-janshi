using System;

namespace MatrixSearchApp
{
    internal class MatrixSearch
    {
        public static int Search(int[,] matrix, int rows, int cols, int target)
        {
            int i = 0, j = cols - 1;

            while (i < rows && j >= 0)
            {
                if (matrix[i, j] == target) return 1;
                if (matrix[i, j] > target) j--;
                else i++;
            }

            return 0;
        }

        static void Main()
        {
            int[,] matrix1 = { { 3, 30, 38 }, { 44, 52, 54 }, { 57, 60, 69 } };
            Console.WriteLine(Search(matrix1, 3, 3, 62));

            int[,] matrix2 = { { 18, 21, 27, 38, 55, 67 } };
            Console.WriteLine(Search(matrix2, 1, 6, 55));
        }
    }
}

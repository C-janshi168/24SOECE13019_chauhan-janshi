using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class A_10
    {
        static void Main(String[] args)
        {
            int[,] A = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] B = { { 7, 8, 9 }, { 1, 2, 3 } };

            int[,] sum = new int[2, 3]; // result matrix (2 rows, 3 cols)

            // add two matrices
            for (int i = 0; i < 2; i++) // 2 rows
            {
                for (int j = 0; j < 3; j++) // 3 columns
                {
                    sum[i, j] = A[i, j] + B[i, j];
                }
            }

            // print result
            Console.WriteLine("Result of Matrix Addition:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
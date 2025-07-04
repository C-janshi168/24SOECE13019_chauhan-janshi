using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_demo7
    {
        public static void Main(string[] args)
        {
            int rows = 5;

            // Upper half
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j < rows; j++)
                    Console.Write(" ");
                for (int k = 1; k <= (2 * i - 1); k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            // Lower half
            for (int i = rows - 1; i >= 1; i--)
            {
                for (int j = rows; j > i; j--)
                    Console.Write(" ");
                for (int k = 1; k <= (2 * i - 1); k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}

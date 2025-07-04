using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class demo4
    {
        public static void Main(string[] args)
        {
            int rows = 4;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j < rows; j++)
                    Console.Write(" ");
                for (int k = 1; k <= i; k++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
    }
}


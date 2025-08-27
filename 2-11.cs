using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class _2_11
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int sum = 0;

            foreach (int num in arr)
            {
                sum += num;
            }

            Console.WriteLine("Sum of array elements: " + sum);
            Console.ReadLine();  // Keeps console window open
        }
    }
}

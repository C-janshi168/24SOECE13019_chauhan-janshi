using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class A_8
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 8, 1, 9, 3 };

            // sort array in ascending order first
            Array.Sort(numbers);

            // print in descending order
            Console.WriteLine("Array in descending order:");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class A_2
    {
        static void Main(String[] args)
        {
            int[] numbers = new int[5];

            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);

            Console.WriteLine("Sorted numbers in ascending order:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

    }
}

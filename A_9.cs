using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class A_9
    {
        static void Main(String[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int n = numbers.Length;

            Console.WriteLine("Original array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.Write("\n\nEnter position to delete (1 to " + n + "): ");
            int pos = Convert.ToInt32(Console.ReadLine());

            if (pos < 1 || pos > n)
            {
                Console.WriteLine("Invalid position!");
            }
            else
            {
                // shift elements to left
                for (int i = pos - 1; i < n - 1; i++)
                {
                    numbers[i] = numbers[i + 1];
                }
                n--; // reduce size

                Console.WriteLine("\nArray after deleting element:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
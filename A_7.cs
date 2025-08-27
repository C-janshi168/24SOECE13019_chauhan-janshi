using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class A_7
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] even = new int[numbers.Length];
            int[] odd = new int[numbers.Length];
            int evenCount = 0;
            int oddCount = 0;

            // separate odd and even
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even[evenCount] = numbers[i];
                    evenCount++;
                }
                else
                {
                    odd[oddCount] = numbers[i];
                    oddCount++;
                }
            }
            //print original array
            Console.WriteLine("Original array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // print even numbers
            Console.WriteLine("\nEven numbers:");
            for (int i = 0; i < evenCount; i++)
            {
                Console.Write(even[i] + " ");
            }

            // print odd numbers
            Console.WriteLine("\nOdd numbers:");
            for (int i = 0; i < oddCount; i++)
            {
                Console.Write(odd[i] + " ");
            }
        }
    }
}

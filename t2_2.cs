using System;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class SortArrayDemo
    {
        public static void Main(string[] args)
        {
            // Declare an integer array of size 5
            int[] arr = new int[5];

            // Ask user to enter 5 integers
            Console.WriteLine("Enter 5 integers:");

            // Read each integer and store in the array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Sort the array in ascending order
            Array.Sort(arr);

            // Display the sorted array
            Console.WriteLine("\nSorted numbers:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Index " + i + ": " + arr[i]);
            }

            Console.ReadLine(); // Keep the console window open
        }
    }
}

using System;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class ArrayInputDemo
    {
        public static void Main(string[] args)
        {
            // Create an array of size 5
            int[] arr = new int[5];

            // Ask user to enter 5 numbers
            Console.WriteLine("Enter 5 numbers:");

            // Loop to take input for each element
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine()); // Read and store the number
            }

            // Print all entered numbers
            Console.WriteLine("\nYou entered:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Element at index " + i + ": " + arr[i]);
            }

            Console.ReadLine(); // Keep the console open after output
        }
    }   
}

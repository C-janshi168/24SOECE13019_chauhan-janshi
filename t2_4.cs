using System;

namespace _24SOECE13019_Chauhan_janshi
{
    public class Class1
    {
        // Main method: entry point of the program
        public static void Main(string[] args)
        {
            // Let user decide how many elements they want
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] originalArray = new int[size];
            int[] copiedArray = new int[size];

            // Getting elements for the first array
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                originalArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Copying elements to the second array
            for (int i = 0; i < size; i++)
            {
                copiedArray[i] = originalArray[i];
            }

            // Displaying the copied array
            Console.WriteLine("\nCopied array elements:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Element {i + 1}: {copiedArray[i]}");
            }

            Console.ReadLine(); // Keep console open
        }
    }
}

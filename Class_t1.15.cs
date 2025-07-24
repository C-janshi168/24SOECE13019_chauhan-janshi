using System;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_tdemo
    {
        public static void Main(string[] args)
        {
            // Ask the user to enter a number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine()); // Read number as integer

            int original = number; // Keep original number for comparison
            int sum = 0;

            // Loop through each digit of the number
            while (number > 0)
            {
                int digit = number % 10; // Get last digit
                sum += digit * digit * digit; // Add cube of the digit to sum
                number /= 10; // Remove last digit
            }

            // Check if the sum of cubes equals the original number
            if (sum == original)
                Console.WriteLine(original + " is an Armstrong number.");
            else
                Console.WriteLine(original + " is not an Armstrong number.");

            Console.ReadLine(); // Wait for user before closing
        }
    }
}

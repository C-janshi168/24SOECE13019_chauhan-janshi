using System;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class demo5
    {
        public static void Main(string[] args)
        {
            int rows = 4;     // Total number of rows to print
            int num = 1;      // Starting number to print

            // Outer loop for each row
            for (int i = 1; i <= rows; i++)
            {
                // Print spaces to align numbers in pyramid shape
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }

                // Print numbers with a space, and increase the number
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(num++ + " ");
                }

                Console.WriteLine(); // Move to next line after each row
            }

            Console.ReadLine(); // Hold the screen open after output
        }
    }
}

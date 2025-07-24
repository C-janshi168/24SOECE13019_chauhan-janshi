using System;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class demo4
    {
        public static void Main(string[] args)
        {
            int rows = 4; // Total number of rows for the pyramid

            // Outer loop controls the number of rows
            for (int i = 1; i <= rows; i++)
            {
                // Print spaces before stars to form pyramid shape
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }

                // Print stars with a space after each
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine(); // Move to the next line after each row
            }

            Console.ReadLine(); // Keep the console open
        }
    }
}

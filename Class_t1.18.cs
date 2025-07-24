using System;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_demo3
    {
        public static void Main(string[] args)
        {
            int num = 1; // Starting number to print

            // Loop for rows (4 total)
            for (int i = 1; i <= 4; i++)
            {
                // Loop to print numbers in each row
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num++ + " "); // Print number and increase it
                }

                Console.WriteLine(); // Go to next line after each row
            }

            Console.ReadLine(); // Keeps the console open until user presses Enter
        }
    }
}

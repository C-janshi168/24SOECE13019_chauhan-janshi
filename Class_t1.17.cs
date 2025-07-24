using System;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_demo2
    {
        public static void Main(string[] args)
        {
            // Outer loop for number of rows
            for (int i = 1; i <= 4; i++)
            {
                // Inner loop to print numbers from 1 to i
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " "); // Print current number with space
                }

                Console.WriteLine(); // Move to next line after each row
            }

            Console.ReadLine(); // Pause console so output stays visible
        }
    }
}

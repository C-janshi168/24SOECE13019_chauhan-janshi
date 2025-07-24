using System;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_demo1
    {
        public static void Main(string[] args)
        {
            // Loop to control number of rows
            for (int i = 1; i <= 4; i++)
            {
                // Loop to print stars in each row
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                // Move to next line after each row
                Console.WriteLine();
            }

            Console.ReadLine(); // Wait for user input before closing
        }
    }
}

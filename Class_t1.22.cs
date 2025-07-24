using System;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_demo7
    {
        public static void Main(string[] args)
        {
            int rows = 5;  // Total rows for the upper half of the diamond

            // Print upper triangle part
            for (int i = 1; i <= rows; i++)
            {
                // Print spaces before stars
                for (int space = i; space < rows; space++)
                    Console.Write(" ");

                // Print stars in odd count (1, 3, 5, ...)
                for (int star = 1; star <= (2 * i - 1); star++)
                    Console.Write("*");

                Console.WriteLine(); // Move to next line
            }

            // Print lower inverted triangle part
            for (int i = rows - 1; i >= 1; i--)
            {
                // Print spaces before stars
                for (int space = rows; space > i; space--)
                    Console.Write(" ");

                // Print stars in decreasing odd count
                for (int star = 1; star <= (2 * i - 1); star++)
                    Console.Write("*");

                Console.WriteLine(); // Move to next line
            }

            Console.ReadLine(); // Keep console window open
        }
    }
}

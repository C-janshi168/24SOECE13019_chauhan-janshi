using System;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_t0
    {
        public static void Main(string[] args)
        {
            // Declare first two numbers of the Fibonacci series
            int first = 0, second = 1, next, i;

            // Print the first two numbers directly
            Console.Write(first + " " + second + " ");

            // Start loop from 2 because first two numbers are already printed
            for (i = 2; i < 11; i++) // Loop will run until we have 11 terms
            {
                next = first + second;     // Add the previous two numbers
                Console.Write(next + " "); // Print the next number

                // Shift values to prepare for next iteration
                first = second;
                second = next;
            }

            Console.ReadLine(); // Keeps the console window open (optional)
        }
    }
}

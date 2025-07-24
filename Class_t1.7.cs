using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_t3
    {
        // Main method - entry point of the program
        static void Main(string[] args)
        {
            int number, result, i;

            // Asking user to enter a number
            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());  // Read and convert input to integer

            i = 1;  // Start value for multiplication loop

            // Loop to print multiplication table up to 10
            while (i <= 10)
            {
                result = number * i;  // Multiply number with current i
                Console.WriteLine(number + " x " + i + " = " + result);  // Display result

                i++;  // Increase counter by 1
            }

            Console.ReadLine();  // Keeps the console window open
        }
    }
}

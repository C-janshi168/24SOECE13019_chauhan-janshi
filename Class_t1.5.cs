using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_t1
    {
        // Main method - starting point of execution
        static void Main(string[] args)
        {
            int number, factorial = 1;  // 'number' stores user input, 'factorial' holds the result

            // Asking the user to input a number
            Console.Write("Enter Number : ");
            string userInput = Console.ReadLine();  // Read input as string

            // Convert the input to integer
            number = Convert.ToInt32(userInput);

            // Loop to calculate factorial
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;  // multiply current value with i
            }

            // Display the final factorial result
            Console.WriteLine("Factorial : " + factorial);

            Console.Read();  // keep console open until user presses a key
        }
    }
}

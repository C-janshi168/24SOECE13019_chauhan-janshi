using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_tdeatils
    {
        // Main method - entry point of the program
        public static void Main(string[] args)
        {
            // asking user to enter a number
            Console.Write("Enter a number: ");

            // reading input and converting it to integer
            int num = Convert.ToInt32(Console.ReadLine());

            // checking if the number is even using modulus
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is Even.");  // print if even
            }
            else
            {
                Console.WriteLine(num + " is Odd.");   // print if odd
            }

            // wait for user input so con
        }
    }
}
}
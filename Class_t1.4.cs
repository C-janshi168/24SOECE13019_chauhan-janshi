using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Classt1
    {
        // Main method - starting point of the program
        public static void Main(string[] args)
        {
            // Asking user to input a number
            Console.WriteLine("Enter Number : ");

            // Reading the input as string
            string input = Console.ReadLine();

            // Converting string to integer
            int num = Convert.ToInt32(input);

            // Checking if number is even or odd using % operator
            if (num % 2 == 0)
                Console.WriteLine("Number is Even");
            else
                Console.WriteLine("Number is Odd");

            // Prevents console from closing immediately
            Console.Read();
        }
    }
}

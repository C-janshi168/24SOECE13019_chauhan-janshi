using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_t4
    {
        // Main method - execution starts from here
        static void Main(string[] args)
        {
            // Asking user to enter their full name
            Console.WriteLine("Enter your full name:");

            string nameInput = Console.ReadLine(); // Read name from user

            // Converting name to uppercase format
            string upperName = nameInput.ToUpper();

            // Displaying the name in uppercase
            Console.WriteLine("Name in uppercase:");
            Console.WriteLine(upperName);

            Console.ReadLine(); // Waits for user to press Enter before closing
        }
    }
}

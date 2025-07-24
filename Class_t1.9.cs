using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class ToggleCaseProgram
    {
        static void Main(string[] args)
        {
            // Ask the user to enter their full name
            Console.Write("Enter your full name: ");
            string inputName = Console.ReadLine(); // Get input from user

            string convertedName = ""; // This will hold the final toggle case result

            // Loop through each character in the input
            foreach (char c in inputName)
            {
                // If character is uppercase, convert it to lowercase
                if (char.IsUpper(c))
                {
                    convertedName += char.ToLower(c);
                }
                // If character is lowercase, convert it to uppercase
                else if (char.IsLower(c))
                {
                    convertedName += char.ToUpper(c);
                }
                else
                {
                    // Leave other characters (like spaces) as they are
                    convertedName += c;
                }
            }

            // Show the name in toggle case format
            Console.WriteLine("Name in toggle case:");
            Console.WriteLine(convertedName);

            Console.ReadLine(); // Keep the console open after output
        }
    }
}

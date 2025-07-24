using System;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class GenderTitleApp
    {
        public static void Main(string[] args)
        {
            // Ask the user to enter their name
            Console.Write("Enter Name: ");
            string userName = Console.ReadLine(); // Read the name

            // Ask the user to enter gender (M/F)
            Console.Write("Enter Gender (M/F): ");
            char userGender = Convert.ToChar(Console.ReadLine().ToUpper()); // Convert input to uppercase char

            // Check gender and display appropriate title
            if (userGender == 'M')
            {
                Console.WriteLine("Mr. " + userName); // For male
            }
            else if (userGender == 'F')
            {
                Console.WriteLine("Ms. " + userName); // For female
            }
            else
            {
                // If input is not M or F
                Console.WriteLine("Invalid gender input.");
            }
        }
    }
}

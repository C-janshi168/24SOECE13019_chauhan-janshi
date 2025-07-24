using System;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class MaskMobileNumber
    {
        public static void Main(string[] args)
        {
            // Step 1: Ask the user to enter a mobile number
            Console.Write("Enter Mobile Number: ");
            string inputNumber = Console.ReadLine(); // Read number from console

            // Step 2: Check if the input has at least 5 digits
            if (inputNumber.Length >= 5)
            {
                // Keep all digits except the last 5, and replace them with 'X's
                string maskedNumber = inputNumber.Substring(0, inputNumber.Length - 5) + "XXXXX";

                // Step 3: Show the masked number
                Console.WriteLine("Masked Number: " + maskedNumber);
            }
            else
            {
                // If the number is too short, show a warning
                Console.WriteLine("Mobile number is too short.");
            }
        }
    }
}

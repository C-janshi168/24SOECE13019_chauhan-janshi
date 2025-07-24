using System;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_t10
    {
        public static void Main(string[] args)
        {
            // Ask user to input a number
            Console.Write("Enter Number: ");
            string inputNumber = Console.ReadLine(); // Read number as a string

            // Go through each character in the string
            foreach (char ch in inputNumber)
            {
                // Use switch to check the digit and print its word form
                switch (ch)
                {
                    case '0':
                        Console.Write("Zero ");
                        break;
                    case '1':
                        Console.Write("One ");
                        break;
                    case '2':
                        Console.Write("Two ");
                        break;
                    case '3':
                        Console.Write("Three ");
                        break;
                    case '4':
                        Console.Write("Four ");
                        break;
                    case '5':
                        Console.Write("Five ");
                        break;
                    case '6':
                        Console.Write("Six ");
                        break;
                    case '7':
                        Console.Write("Seven ");
                        break;
                    case '8':
                        Console.Write("Eight ");
                        break;
                    case '9':
                        Console.Write("Nine ");
                        break;
                    default:
                        Console.Write("Invalid "); // For any non-digit character
                        break;
                }
            }

            Console.ReadLine(); // Pause the console so output stays visible
        }
    }
}

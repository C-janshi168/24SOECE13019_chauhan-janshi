using System;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class demo6
    {
        public static void Main(string[] args)
        {
            // Ask user how many terms they want in the series
            Console.Write("Enter the number of terms: ");
            int totalTerms = Convert.ToInt32(Console.ReadLine());

            // Ask for the digit to be repeated (base number)
            Console.Write("Enter the base number: ");
            int digit = Convert.ToInt32(Console.ReadLine());

            int currentTerm = 0;  // Stores each new term in the pattern (like 2, 22, 222)
            int sum = 0;          // Stores total sum of all terms

            Console.Write("Series: ");

            // Loop to generate the series and sum the values
            for (int i = 1; i <= totalTerms; i++)
            {
                currentTerm = currentTerm * 10 + digit;  // Builds terms like 2 → 22 → 222
                sum += currentTerm;                      // Add term to total sum

                Console.Write(currentTerm);

                // Print plus symbol between terms, but not after the last one
                if (i != totalTerms)
                    Console.Write(" + ");
            }

            // Print the final sum of the series
            Console.WriteLine("\nThe Sum is: " + sum);

            Console.ReadLine(); // Keep console open after output
        }
    }
}

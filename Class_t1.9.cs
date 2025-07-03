using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_t5
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter your name:");
                string input = Console.ReadLine(); // Read user input

            string toggleCase = "";

            foreach (char ch in input)
            {
                if (char.IsUpper(ch))
                {
                    toggleCase += char.ToLower(ch); // Convert to lowercase
                    }
                    else if (char.IsLower(ch))
                    {
                        toggleCase += char.ToUpper(ch); // Convert to uppercase
                    }
                    else
                    {
                        toggleCase += ch; // Keep spaces and other characters as is
                    }
                }

                Console.WriteLine("Name in toggle case:");
                Console.WriteLine(toggleCase); // Display result

                Console.ReadLine(); // Pause console
            }
        }
    }



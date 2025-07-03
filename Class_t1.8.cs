using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_t4
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter your full name:");
                string name = Console.ReadLine(); // Read the input

                string upperName = name.ToUpper(); // Convert to uppercase

                Console.WriteLine("Name in uppercase:");
                Console.WriteLine(upperName); // Display output

                Console.ReadLine(); // Keep console open
            }
        }
    }

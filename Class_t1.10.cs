using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_t9
    {
            public static void Main(string[] args)
            {
                Console.Write("Enter Mobile Number: ");
                string mobile = Console.ReadLine();

                // Check if the mobile number is at least 5 digits
                if (mobile.Length >= 5)
                {
                    string masked = mobile.Substring(0, mobile.Length - 5) + "XXXXX";
                    Console.WriteLine("Masked Number: " + masked);
                }
                else
                {
                    Console.WriteLine("Mobile number is too short.");
                }
            }
        }
    }


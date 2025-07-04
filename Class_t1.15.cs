using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_tdemo
    {
        public static void Main(string[] args)
        {
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                int sum = 0, temp = num;
                while (temp > 0)
                {
                    int digit = temp % 10;
                    sum += digit * digit * digit;
                    temp /= 10;
                }

                if (sum == num)
                    Console.WriteLine(num + " is an Armstrong number.");
                else
                    Console.WriteLine(num + " is not an Armstrong number.");
            }
        }

    }

}


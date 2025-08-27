using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class A_3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: "); int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Reverse:" + String.Join(", ", a.Reverse()));

        }
    }
} 

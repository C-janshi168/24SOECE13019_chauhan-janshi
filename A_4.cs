using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class A_4
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 }; int[] copy = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                copy[i] = a[i];
            }

            Console.WriteLine("Original Array: " + string.Join(", ", a));
            Console.WriteLine("Copied Array: " + string.Join(", ", copy));
        }

    }
}

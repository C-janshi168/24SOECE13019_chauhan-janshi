using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class A_5
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 3, 4, 4, 7, 9, 9 };
            int dup = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] == a[i + 1])
                {
                    dup++;
                }
            }
            Console.WriteLine("count of duplicate elements in : " + dup);
        }
    }
}

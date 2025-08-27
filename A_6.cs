using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class A_6
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 44, 33 };

            //built in function
            Console.WriteLine("max:" + a.Max());
            Console.WriteLine("min:" + a.Min());

            //user define function to find max and min
            int max = a[0];
            int min = a[0];
            foreach (int i in a)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }

            Console.WriteLine("max from foreach loop: " + max);
            Console.WriteLine("min from foreach loop: " + min);

        }
    }
}

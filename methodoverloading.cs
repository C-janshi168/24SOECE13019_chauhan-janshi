using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class methodoverloading

    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine(methodoverloading.Add(2, 3));
            Console.WriteLine(methodoverloading.Add(1, 2, 3));
            Console.WriteLine(methodoverloading.Add(2.5, 9.5));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_t0
    {
        public static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i;
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < 11; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}


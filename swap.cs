using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class swap 
    {
        static void Swap (ref int a, ref int b)
        {
            a = a + b; //30 b=20
            b = a - b; //a=30 b=10
            a = a - b; //a=20 b=10
        }

        static void Main() // <-- fixed: Main must be capitalized
        {
            int a = 10, b = 20;
            //int x = 10, y = 20;
            Console.WriteLine("Before Swap: a = " + a + ", b =" + b);
            Swap(ref a, ref b); // <-- fixed: call the correct method name
            Console.WriteLine("After Swap: a = " + a + ", b =" + b);
        }
    }
}
 

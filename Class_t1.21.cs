using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class demo6
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of terms: ");
            int terms = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the base number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int termValue = 0;

            Console.Write("Series: ");
            for (int i = 1; i <= terms; i++)
            {
                termValue = termValue * 10 + num;
                sum += termValue;

                Console.Write(termValue);
                if (i != terms) Console.Write(" + ");
            }

            Console.WriteLine("\nThe Sum is: " + sum);
        }
    }
}

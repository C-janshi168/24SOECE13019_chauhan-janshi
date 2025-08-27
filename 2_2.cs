using System;

namespace IfElseConditionApp
{
    internal class IfElseDemo
    {
        static void Main(string[] args)
        {
            int number = 100;

            if (number < 20)
            {
                Console.WriteLine("Number is less than 20");
            }
            else
            {
                Console.WriteLine("Number is not less than 20");
            }

            Console.WriteLine($"Value of number: {number}");
            Console.ReadLine();
        }
    }
}

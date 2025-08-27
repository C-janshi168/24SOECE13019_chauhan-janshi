using System;

namespace IfConditionApp
{
    internal class IfConditionDemo
    {
        static void Main(string[] args)
        {
            int number = 10;

            if (number < 20)
            {
                Console.WriteLine("Number is less than 20");
            }

            Console.WriteLine($"Value of number: {number}");
            Console.ReadLine();
        }
    }
}

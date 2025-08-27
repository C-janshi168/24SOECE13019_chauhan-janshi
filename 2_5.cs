using System;

namespace ArraySumInputApp
{
    internal class ArraySumCalculator
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int number in numbers)
            {
                total += number;
            }

            Console.WriteLine($"Sum of elements: {total}");
            Console.ReadLine();
        }
    }
}

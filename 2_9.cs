using System;
using System.Collections.Generic;

namespace UniqueElementFinder
{
    internal class UniqueFinder
    {
        private static void PrintUniqueElements(int[] numbers)
        {
            var frequency = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (frequency.ContainsKey(number))
                    frequency[number]++;
                else
                    frequency[number] = 1;
            }

            foreach (var entry in frequency)
            {
                if (entry.Value == 1)
                    Console.Write(entry.Key + " ");
            }
        }

        static void Main()
        {
            int[] firstArray = { 1, 2, 3, 2, 1, 4 };
            Console.WriteLine("Unique elements in first array:");
            PrintUniqueElements(firstArray);
            Console.WriteLine();

            int[] secondArray = { 2, 1, 3, 2 };
            Console.WriteLine("Unique elements in second array:");
            PrintUniqueElements(secondArray);
            Console.WriteLine();
        }
    }
}

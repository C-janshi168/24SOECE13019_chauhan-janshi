using System;

namespace ArrayPrograms
{
    internal class 2_11
    {
        static void Main(string[]args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int sum = 0;

            foreach (int num in arr)
            {
                sum += num;
            }

            Console.WriteLine("Sum of array elements: " + sum);
            Console.ReadLine();  // Keeps console window open
        }
    }
}

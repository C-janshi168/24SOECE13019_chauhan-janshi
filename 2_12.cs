using System;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_12   // ✅ Class name fixed
    {
        static void Main()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.Write("Enter element to search: ");
            int target = Convert.ToInt32(Console.ReadLine());

            bool isFound = false;
            foreach (int number in numbers)
            {
                if (number == target)
                {
                    isFound = true;
                    break;
                }
            }

            Console.WriteLine(isFound ? 1 : 0);  // ✅ Prints 1 if found, else 0
            Console.ReadLine(); // Keep console open
        }
    }
}

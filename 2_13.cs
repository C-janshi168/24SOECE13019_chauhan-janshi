using System;

namespace CurrencyNotesApp
{
    internal class CurrencyBreakdown
    {
        static void Main()
        {
            int amount = 5748;
            int[] denominations = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            foreach (int note in denominations)
            {
                int count = amount / note;
                amount %= note;
                Console.WriteLine($"Notes of Rs.{note} = {count}");
            }
        }
    }
}

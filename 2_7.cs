using System;

namespace SwapExample
{
    internal class Swapper
    {
        public void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var swapper = new Swapper();

            int numberA = 100;
            int numberB = 200;

            Console.WriteLine($"Before swap: A = {numberA}, B = {numberB}");

            swapper.Swap(ref numberA, ref numberB);

            Console.WriteLine($"After swap:  A = {numberA}, B = {numberB}");

            Console.ReadLine();
        }
    }
}

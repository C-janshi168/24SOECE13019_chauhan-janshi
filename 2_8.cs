using System;

namespace ValuesWithOutParameters
{
    internal class ValueCollector
    {
        public int GetValues(out int first, out int second, out int third)
        {
            Console.Write("Enter the first value: ");
            first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second value: ");
            second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third value: ");
            third = Convert.ToInt32(Console.ReadLine());

            return first + second + third;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var collector = new ValueCollector();

            int a, b, c;
            int sum = collector.GetValues(out a, out b, out c);

            Console.WriteLine($"After method call, first value  = {a}");
            Console.WriteLine($"After method call, second value = {b}");
            Console.WriteLine($"After method call, third value  = {c}");
            Console.WriteLine($"Sum = {sum}");

            Console.ReadLine();
        }
    }
}

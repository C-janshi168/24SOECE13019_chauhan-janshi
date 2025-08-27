using System;

namespace EchoInputApp
{
    internal class EchoProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");
            string input = Console.ReadLine();

            Console.WriteLine("Output:");
            Console.WriteLine(input);
        }
    }
}

using System;

namespace NameUpdateApp
{
    internal class NameUpdater
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";

            Console.WriteLine($"Name: {firstName} {lastName}");

            Console.Write("Please enter a new first name: ");
            firstName = Console.ReadLine();

            Console.WriteLine($"New name: {firstName} {lastName}");

            Console.ReadLine();
        }
    }
}

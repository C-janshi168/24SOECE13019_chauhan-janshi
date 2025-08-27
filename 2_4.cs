using System;

namespace ArithmeticOperationsApp
{
    internal class ArithmeticDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number (A): ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number (B): ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n--- Integer Operations ---");
            Console.WriteLine($"A + B = {firstNumber + secondNumber}");
            Console.WriteLine($"A - B = {firstNumber - secondNumber}");
            Console.WriteLine($"A * B = {firstNumber * secondNumber}");
            Console.WriteLine($"A / B = {firstNumber / secondNumber}");
            Console.WriteLine($"A % B = {firstNumber % secondNumber}");

            float floatA = firstNumber, floatB = secondNumber;
            Console.WriteLine("\n--- Float Operations ---");
            Console.WriteLine($"A / B = {floatA / floatB}");

            double doubleA = firstNumber, doubleB = secondNumber;
            Console.WriteLine("\n--- Double Operations ---");
            Console.WriteLine($"Power (A^B) = {Math.Pow(doubleA, doubleB)}");

            decimal decimalA = firstNumber, decimalB = secondNumber;
            Console.WriteLine("\n--- Decimal Operations ---");
            Console.WriteLine($"A * B = {decimalA * decimalB}");

            Console.ReadLine();
        }
    }
}

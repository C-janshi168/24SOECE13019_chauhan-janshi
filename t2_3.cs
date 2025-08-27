using System;

public class Class1
{
    // Main method: Entry point of the program
    public static void Main(string[] args)
    {
        // Ask user for total number of elements
        Console.Write("How many numbers you want to enter? ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[size];

        // Taking input from user
        Console.WriteLine("Enter the numbers one by one:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Displaying array in reverse
        Console.WriteLine("\nNumbers in reverse order:");
        for (int i = size - 1; i >= 0; i--)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}

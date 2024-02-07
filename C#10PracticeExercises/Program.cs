using System;

public class Program
{
    public static void Main(string[] args)
    {
        string name = string.Empty;

        while (string.IsNullOrEmpty(name))
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty. Please try again.");
            }
        }

        Console.WriteLine("Hello, " + name + "! Welcome to the program.");
    }
}

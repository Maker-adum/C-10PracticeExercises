using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        string message = $"Hello {name}, you are {age} years old!";
        Console.WriteLine(message);

        Console.ReadKey();
    }
}


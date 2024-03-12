using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine();

        // Set a breakpoint here to observe the value of userInput as it is parsed

        int parsedInput = int.Parse(userInput);

        int result = parsedInput * 2;

        Console.WriteLine($"The result is: {result}");
    }
}
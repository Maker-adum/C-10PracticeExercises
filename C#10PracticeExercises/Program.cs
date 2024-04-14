using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");

        try
        {
            string userInput = Console.ReadLine();

            double number = Convert.ToDouble(userInput);

            Console.WriteLine("The number you entered is : " + number);
        }

        catch (FormatException)
        {
            Console.WriteLine("Error: Input is not a valid number.");
        }
    }
}
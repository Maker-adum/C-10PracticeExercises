using System;

public class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a positive number:");

            string userInput = Console.ReadLine();

            int number = Convert.ToInt32(userInput);

            if (number < 0)
            {
                throw new NegativeNumberException("Error: Input is a negative number.");
            }

            double squareRoot = Math.Sqrt(number);
            Console.WriteLine($"The square root of {number} is: {squareRoot}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Input is not a valid integer.");
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

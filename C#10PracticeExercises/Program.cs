using System;

class Program
{
    static List<int> GetEvenNumbersGreaterThanTen(List<int> numbers)
    {
        List<int> result = new List<int>();

        foreach (int number in numbers)
        {
            if (number >= 10 && number % 2 == 0)
            {
                result.Add(number);
            }
        }

        return result;
    }

    static void Main()
    {
        // Example usage
        List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30 };

        List<int> evenNumbersGreaterThanTen = GetEvenNumbersGreaterThanTen(numbers);

        // Printing the result
        Console.WriteLine("Even numbers greater than or equal to 10:");
        foreach (int number in evenNumbersGreaterThanTen)
        {
            Console.WriteLine(number);
        }
    }
}
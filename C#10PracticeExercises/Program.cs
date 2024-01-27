using System;

public class Calculation
{
    public static int MultiplySumByFirst(int firstNumber, int secondNumber)
    {
        int sum = firstNumber + secondNumber;
        int result = sum * firstNumber;
        return result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int result = Calculation.MultiplySumByFirst(firstNumber, secondNumber);
        Console.WriteLine("result: " + result);  // Output: 40
    }
}
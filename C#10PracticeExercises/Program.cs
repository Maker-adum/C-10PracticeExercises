using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int factorial = CalculateFactorial(number);

        Console.WriteLine($"The factorial of {number} is {factorial}.");
    }

    static int CalculateFactorial(int number)
    {
        // Set a breakpoint here to check the initial value of the number

        if (number == 0 || number == 1)
        {
            // Set a breakpoint here to check the factorial calculation for 0 and 1
            return 1;
        }

        int result = number;

        while (number > 1)
        {
            // Set a breakpoint here to step through the factorial calculation loop
            number--;
            result *= number;
        }

        // Set a breakpoint here to check the final result before returning
        return result;
    }
}
using System;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return (double)a / b;
    }
}

public class Program
{
    static void Main()
    {
        // Instantiate the Calculator class and perform operations
        Calculator calculator = new Calculator();
        int sum = calculator.Add(5, 3);
        int difference = calculator.Subtract(10, 4);
        int product = calculator.Multiply(6, 2);
        double quotient = calculator.Divide(15, 3);

        // Output the results
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");
    }
}
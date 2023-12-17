namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose an operation: ");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the first value: ");
            double value1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            double value2 = double.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"The sum of {value1} and {value2} is: {Add(value1, value2)}");
                    break;
                case 2:
                    Console.WriteLine($"The difference of {value1} and {value2} is: {Subtract(value1, value2)}");
                    break;
                case 3:
                    Console.WriteLine($"The product of {value1} and {value2} is: {Multiply(value1, value2)}");
                    break;
                case 4:
                    double result = Divide(value1, value2);
                    if (result != double.MinValue)
                    {
                        Console.WriteLine($"The division of {value1} by {value2} is: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        static double Add(double a, double b) => a + b;

        static double Subtract(double a, double b) => a - b;

        static double Multiply(double a, double b) => a * b;

        static double Divide(double a, double b) => b != 0 ? a / b : double.MinValue;
    }
}
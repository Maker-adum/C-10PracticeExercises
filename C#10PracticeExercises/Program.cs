
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose an operation by entering a number representing the operation: ");
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
                    Add(value1, value2);
                    break;
                case 2:
                    Subtract(value1, value2);
                    break;
                case 3:
                    Multiply(value1, value2);
                    break;
                case 4:
                    Divide(value1, value2);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        static void Add(double a, double b)
        {
            Console.WriteLine($"The sum of {a} and {b} is: {a + b}");
        }

        static void Subtract(double a, double b)
        {
            Console.WriteLine($"The difference of {a} and {b} is: {a - b}");
        }

        static void Multiply(double a, double b)
        {
            Console.WriteLine($"The product of {a} and {b} is: {a * b}");
        }

        static void Divide(double a, double b)
        {
            if (b != 0)
            {
                Console.WriteLine($"The division of {a} by {b} is: {a / b}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }

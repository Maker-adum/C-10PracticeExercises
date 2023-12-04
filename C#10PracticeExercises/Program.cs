
// numbers
Console.WriteLine("Enter the first number: ");
double x = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
double y = double.Parse(Console.ReadLine());

// addition
double sum = x + y;

// subtraction
double difference = x - y;

// multiplication
double product = x * y;

// division
double quotient = x / y;

// results
Console.WriteLine($"Addition: {x} + {y} = {sum}");
Console.WriteLine($"Subtraction: {x} - {y} = {difference}");
Console.WriteLine($"Multiplication: {x} * {y} = {product}");
Console.WriteLine($"Division: {x} / {y} = {quotient}");

Console.Write("Enter a decimal value: ");
decimal value = decimal.Parse(Console.ReadLine());

string formattedValue = value.ToString("F2");

Console.WriteLine("Formatted value: " + formattedValue);
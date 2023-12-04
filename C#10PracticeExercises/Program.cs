Console.Write("Enter a date (yyyy-mm-dd): ");
DateTime date = DateTime.Parse(Console.ReadLine());

Console.WriteLine(date.DayOfWeek);

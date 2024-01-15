using C_10PracticeExercises;

Console.Write("Please enter your name: ");
string name = Console.ReadLine();

Console.Write("Please enter your activity: ");
string activity = Console.ReadLine();

Console.Write("Please enter your average hours of workout per day: ");
string averageHoursPerDay = Console.ReadLine();

int totalHoursPerWeek = Utility.CalculateTotalHoursPerWeek(averageHoursPerDay);

Console.WriteLine();
Console.WriteLine($"{name}, you're rockin' it! You've practiced {activity} for a total of {totalHoursPerWeek} hours this week! Keep up the amazing work!");

Console.WriteLine($"Here's a shiny medal for your dedication:");

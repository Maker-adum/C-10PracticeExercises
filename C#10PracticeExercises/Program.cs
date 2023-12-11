
int number;

for (; ; )
{
    Console.Write("Enter a number between 1 and 7: ");
    number = int.Parse(Console.ReadLine());

    if (number >= 1 && number <= 7)
        break;

    Console.WriteLine("Invalid input. Please try again.");
}

string dayOfWeek = "";

switch (number)
{
    case 1:
        dayOfWeek = "Monday";
        break;
    case 2:
        dayOfWeek = "Tuesday";
        break;
    case 3:
        dayOfWeek = "Wednesday";
        break;
    case 4:
        dayOfWeek = "Thursday";
        break;
    case 5:
        dayOfWeek = "Friday";
        break;
    case 6:
        dayOfWeek = "Saturday";
        break;
    case 7:
        dayOfWeek = "Sunday";
        break;
    default:
        dayOfWeek = "Invalid input";
        break;
}

Console.WriteLine($"{number} = {dayOfWeek}");
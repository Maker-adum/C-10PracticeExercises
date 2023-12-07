
Console.WriteLine("Please enter your age: ");
string input = Console.ReadLine();
int age = int.Parse(input);

switch (age)
{
    case int myAge when (myAge >= 18 && myAge <= 24):
        Console.WriteLine("You are almost eligible to work.");
        break;

    case int myAge when (myAge >= 25 && myAge <= 70):
        Console.WriteLine("You are eligible to work.");
        break;

    default:
        Console.WriteLine("You are not eligible to work.");
        break;
}


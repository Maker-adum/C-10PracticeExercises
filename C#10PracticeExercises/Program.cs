
Console.Write("Enter a number between 1 and 7: ");
int number = int.Parse(Console.ReadLine());

string dayOfWeek = "";

        if (number == 1)
        {
            dayOfWeek = "Monday";
        }
        else if (number == 2)
        {
            dayOfWeek = "Tuesday";
        }
        else if (number == 3)
        {
            dayOfWeek = "Wednesday";
        }
        else if (number == 4)
        {
            dayOfWeek = "Thursday";
        }
        else if (number == 5)
        {
            dayOfWeek = "Friday";
        }
        else if (number == 6)
        {
            dayOfWeek = "Saturday";
        }
        else if (number == 7)
        {
            dayOfWeek = "Sunday";
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            return;
        }

        Console.WriteLine($"{number} = {dayOfWeek}");


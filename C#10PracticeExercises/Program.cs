
Console.Write("Enter a number between 1 and 7: ");
int number = int.Parse(Console.ReadLine());

        
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
       Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
     return;
}

      Console.WriteLine($"{number} = {dayOfWeek}");

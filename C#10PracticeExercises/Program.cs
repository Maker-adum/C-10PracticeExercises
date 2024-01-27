using System;

public enum Months
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}

public class Program
{
    public static string GetMonthName(int monthNumber)
    {
        if (Enum.IsDefined(typeof(Months), monthNumber))
        {
            Months month = (Months)monthNumber;
            return month.ToString();
        }
        else
        {
            return "Invalid month number";
        }
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a month number (1-12): ");
        int monthNumber = Convert.ToInt32(Console.ReadLine());

        string monthName = GetMonthName(monthNumber);
        Console.WriteLine("Month: " + monthName);
    }
}
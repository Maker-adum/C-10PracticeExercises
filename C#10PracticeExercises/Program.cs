using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the first string:");
            string firstString = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string secondString = Console.ReadLine();

            string concatenatedString = firstString + secondString;

            Console.WriteLine("Concatenated string: " + concatenatedString);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred during concatenation: " + ex.Message);
        }
    }
}

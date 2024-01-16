using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string output = InsertRandomNewlinesAndTabs(input);

        Console.WriteLine("Modified string:");
        Console.WriteLine(output);
    }

    public static string InsertRandomNewlinesAndTabs(string input)
    {
        Random random = new();
        var outputBuilder = new StringBuilder();

        foreach (char c in input)
        {
            outputBuilder.Append(c);

            // Randomly insert '\n' and '\t' characters
            if (random.Next(2) == 0)
            {
                outputBuilder.Append(random.Next(2) == 0 ? '\n' : '\t');
            }
        }

        return outputBuilder.ToString();
    }
}

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = "Hello, world!";
        int length = GetStringLength(input);
        Console.WriteLine(length);
    }

    public static int GetStringLength(string input)
    {
        if (input == null)
        {
            return 0;
        }
        else
        {
            return input.Length;
        }
    }
}

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string str1 = "Hello, ";
        string str2 = "World!";

        string result = String.Concat(str1, str2);

        Console.WriteLine(result);
    }
}
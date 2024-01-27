using System;

public class Program
{
    public static void Main(string[] args)
    {
        string string1 = "Hello Word";

        string string2 = String.Copy(string1);

        Console.WriteLine("Original String (string1): " + string1);
        Console.WriteLine("Copied String (string2): " + string2);
    }
}
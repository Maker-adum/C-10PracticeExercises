using System;

public class Program
{
    public static void Main()
    {
        string str1 = "Hello, World";
        string str2 = "Learn CSharp";

        string str3 = str1.ToUpper();
        string str4 = str2.ToLower();

        Console.WriteLine("Original String: " + str1);
        Console.WriteLine("Uppercase String: " + str3);
        Console.WriteLine("Lowercase String: " + str4);
    }
}
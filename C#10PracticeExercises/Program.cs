using System;

public class Program
{

    public static void Main(string[] args)
    {

        int x = 5;
        int y = 10;

        Console.WriteLine("Before swap:");
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);

        Swap(ref x, ref y);

        Console.WriteLine("\nAfter swap:");
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);

    }

    public static void Swap(ref int a, ref int b)
    {

        int temp = a;

        a = b;
        b = temp;

    }

}
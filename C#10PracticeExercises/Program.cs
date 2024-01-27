using System;

public struct Point
{
    public int X;
    public int Y;
}

public struct Rectangle
{
    public Point Left;
    public Point Right;

    public int CalculateArea()
    {
        int width = Math.Abs(Right.X - Left.X);
        int height = Math.Abs(Right.Y - Left.Y);
        return width * height;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();

        Console.WriteLine("Enter the coordinates of the left point:");
        Console.Write("X: ");
        rect.Left.X = Convert.ToInt32(Console.ReadLine());
        Console.Write("Y: ");
        rect.Left.Y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the coordinates of the right point:");
        Console.Write("X: ");
        rect.Right.X = Convert.ToInt32(Console.ReadLine());
        Console.Write("Y: ");
        rect.Right.Y = Convert.ToInt32(Console.ReadLine());

        int area = rect.CalculateArea();
        Console.WriteLine("Area of the rectangle: " + area);
    }
}
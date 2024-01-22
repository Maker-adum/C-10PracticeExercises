using System;

public class Rectangle
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double CalculateArea()
    {
        return Length * Width;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(length, width);

        double area = rectangle.CalculateArea();
        double perimeter = rectangle.CalculatePerimeter();

        Console.WriteLine("Rectangle area: " + area);
        Console.WriteLine("Rectangle perimeter: " + perimeter);
    }
}
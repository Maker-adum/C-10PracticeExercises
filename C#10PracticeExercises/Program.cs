using System;

public class Circle
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Circle circle = new Circle(radius);

        double area = circle.CalculateArea();
        double circumference = circle.CalculateCircumference();

        Console.WriteLine("Circle area: " + area);
        Console.WriteLine("Circle circumference:" + circumference);

    }
}
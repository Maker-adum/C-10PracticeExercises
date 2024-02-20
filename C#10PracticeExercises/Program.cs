using System;
using System.Collections.Generic;

public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a generic shape.");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

public class Program
{
    public static void Main()
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Rectangle());
        shapes.Add(new Circle());

        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }
}
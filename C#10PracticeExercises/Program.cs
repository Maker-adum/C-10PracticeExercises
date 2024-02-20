public interface IDrawable
{
    void Draw();
}

public class Circle : IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

public class Rectangle : IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}

public class Triangle : IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Drawing a triangle.");
    }
}

public class Program
{
    public static void Main()
    {
        List<IDrawable> shapes = new List<IDrawable>();

        shapes.Add(new Circle());
        shapes.Add(new Rectangle());
        shapes.Add(new Triangle());

        foreach (IDrawable shape in shapes)
        {
            shape.Draw();
        }
    }
}
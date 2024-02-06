using System;
using MyShapes;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine("Circle area: " + circle.CalculateArea());

            Square square = new Square(10);
            Console.WriteLine("Square area: " + square.CalculateArea());

            Rectangle rectangle = new Rectangle(10, 5);
            Console.WriteLine("Rectangle area: " + rectangle.CalculateArea());
        }
    }
}

namespace MyShapes
{
    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Square
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public double CalculateArea()
        {
            return side * side;
        }
    }

    public class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateArea()
        {
            return length * width;
        }
    }
}
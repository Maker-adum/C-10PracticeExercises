using System;
using System.Drawing;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color1 = Colors.GetColor("Red");
            Console.WriteLine("Color 1: " + color1.Name);

            Color color2 = Colors.GetColor("Green");
            Console.WriteLine("Color 2: " + color2.Name);

            Color color3 = Colors.GetColor("Blue");
            Console.WriteLine("Color 3: " + color3.Name);

            Color color4 = Colors.GetColor("Yellow");
            Console.WriteLine("Color 4: " + color4.Name);
        }
    }
}

public class Colors
{
    public static Color Red = Color.Red;
    public static Color Green = Color.Green;
    public static Color Blue = Color.Blue;

    public static Color GetColor(string colorName)
    {
        switch (colorName.ToLower())
        {
            case "red":
                return Red;
            case "green":
                return Green;
            case "blue":
                return Blue;
            default:
                return Color.Black;
        }
    }
}
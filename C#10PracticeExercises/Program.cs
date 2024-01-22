using System;

public class Car
{
    public string Color;
    public int MaxSpeed;

    public void StartEngine()
    {
        Console.WriteLine("Engine started!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Car myCar = new Car();

        Console.Write("Enter the car color: ");
        myCar.Color = Console.ReadLine();

        Console.Write("Enter the car max speed: ");
        string speedInput = Console.ReadLine();
        int.TryParse(speedInput, out myCar.MaxSpeed);

        Console.WriteLine("Car color: " + myCar.Color);
        Console.WriteLine("Car max speed: " + myCar.MaxSpeed);

        myCar.StartEngine();
    }
}
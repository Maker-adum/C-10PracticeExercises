using System;

public class Car
{
    public string ModelName;
    public string Color;
    public int MaxSpeed;

    public Car(string modelName, string color, int maxSpeed)
    {
        ModelName = modelName;
        Color = color;
        MaxSpeed = maxSpeed;
    }

    public void StartEngine()
    {
        Console.WriteLine("Engine started!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the car model name: ");
        string modelName = Console.ReadLine();

        Console.Write("Enter the car color: ");
        string color = Console.ReadLine();

        Console.Write("Enter the car max speed: ");
        string speedInput = Console.ReadLine();
        int.TryParse(speedInput, out int maxSpeed);

        Car myCar = new Car(modelName, color, maxSpeed);

        Console.WriteLine("Car model name: " + myCar.ModelName);
        Console.WriteLine("Car color: " + myCar.Color);
        Console.WriteLine("Car max speed: " + myCar.MaxSpeed);

        myCar.StartEngine();
    }
}
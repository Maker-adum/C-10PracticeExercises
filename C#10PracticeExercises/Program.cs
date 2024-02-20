using System;

public class Engine
{
    public void Start()
    {
        Console.WriteLine("Engine started.");
    }
}

public class Car
{
    private Engine engine;

    public Car()
    {
        engine = new Engine();
    }

    public void StartEngine()
    {
        engine.Start();
    }
}

public class ElectricCar : Car
{
    public int BatteryCapacity { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public int RangePerCharge { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        car.StartEngine();

        ElectricCar electricCar = new ElectricCar();
        electricCar.StartEngine();
    }
}
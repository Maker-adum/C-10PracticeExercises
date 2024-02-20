using System;

public class Animal
{
    public string Name { get; set; }
    public double Weight { get; set; }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }
}

public class Mammals : Animal
{
    public int NumberOfLegs { get; set; }

    public void Move()
    {
        Console.WriteLine($"{Name} is moving on {NumberOfLegs} legs.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Mammals dog = new Mammals();
        dog.Name = "Dog";
        dog.Weight = 15.5;
        dog.NumberOfLegs = 4;

        dog.Eat();
        dog.Sleep();
        dog.Move();
    }
}
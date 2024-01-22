using System;

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    public void GiveRaise(double percentage)
    {
        double raiseAmount = Salary * (percentage / 100);
        Salary += raiseAmount;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter employee name: ");
        string name = Console.ReadLine();

        Console.Write("Enter employee age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter employee salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Employee employee = new Employee(name, age, salary);

        Console.WriteLine("Employee information:");
        Console.WriteLine("Name: " + employee.Name);
        Console.WriteLine("Age: " + employee.Age);
        Console.WriteLine("Salary: " + employee.Salary);

        Console.Write("Enter raise percentage: ");
        double raisePercentage = Convert.ToDouble(Console.ReadLine());

        employee.GiveRaise(raisePercentage);

        Console.WriteLine("Employee information after raise:");
        Console.WriteLine("Name: " + employee.Name);
        Console.WriteLine("Age: " + employee.Age);
        Console.WriteLine("Salary: " + employee.Salary);
    }
}
using System;

public class Person
{
    private string name;
    private int age;
    private string address;

    public string GetName()
    {
        return name;
    }

    public void SetName(string newName)
    {
        name = newName;
    }

    public int GetAge()
    {
        return age;
    }

    public void SetAge(int newAge)
    {
        age = newAge;
    }

    public string GetAddress()
    {
        return address;
    }

    public void SetAddress(string newAddress)
    {
        address = newAddress;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        person.SetName("Abraham Luke");
        person.SetAge(30);
        person.SetAddress("123 Lodwar Town");

        Console.WriteLine($"Name: {person.GetName()}");
        Console.WriteLine($"Age: {person.GetAge()}");
        Console.WriteLine($"Address: {person.GetAddress()}");
    }
}
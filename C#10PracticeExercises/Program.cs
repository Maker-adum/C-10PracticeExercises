using System;
using PersonLibrary;

public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        person.firstName = "Adum";
        person.lastName = "Maker";
        person.age = 30;
        person.emailAddress = "adummaker02@gmail.com";

        string fullName = person.GetFullName();
        Console.WriteLine("Full Name: " + fullName);
    }
}


namespace PersonLibrary
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string emailAddress { get; set; }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
    }
}

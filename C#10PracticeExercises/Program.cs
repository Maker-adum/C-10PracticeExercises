using System;
using PersonLibrary;

public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        person.FirstName = "Adum";
        person.LastName = "Maker";
        person.Age = 30;
        person.EmailAddress = "adummaker02@gmail.com";

        string fullName = person.GetFullName();
        Console.WriteLine("Full Name: " + fullName);
    }
}


namespace PersonLibrary
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}

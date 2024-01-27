using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public string JobTitle { get; set; }
    public decimal Salary { get; set; }
}

class Company
{
    public string Name { get; set; }
    public List<Employee> Employees { get; set; } = new List<Employee>();

    public void ListEmployees()
    {
        Console.WriteLine($"Employees of {Name}:");
        foreach (var employee in Employees)
        {
            Console.WriteLine($"- {employee.Name}, {employee.JobTitle}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Create some Employee instances
        Employee employee1 = new Employee { Name = "adum Maker", JobTitle = "Software Engineer", Salary = 80000 };
        Employee employee2 = new Employee { Name = "James Daniel", JobTitle = "UX Designer", Salary = 70000 };

        // Create a Company instance and add employees
        Company myCompany = new Company { Name = "Learning Lions" };
        myCompany.Employees.Add(employee1);
        myCompany.Employees.Add(employee2);

        // List employees using the ListEmployees method
        myCompany.ListEmployees();
    }
}

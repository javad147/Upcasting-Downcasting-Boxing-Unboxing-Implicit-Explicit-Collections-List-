using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime Birthday { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main()
    {
        // Let's create a list of type Employee
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "John", Surname = "Doe", Birthday = new DateTime(1985, 5, 15), Salary = 2500 },
            new Employee { Name = "Jane", Surname = "Smith", Birthday = new DateTime(1990, 8, 22), Salary = 2200 },
            new Employee { Name = "Alice", Surname = "Johnson", Birthday = new DateTime(1980, 3, 10), Salary = 3000 }
            // You can add other employees as needed
        };

        // For example, let's specify the date range and minimum salary to be passed to the method
        DateTime startDate = new DateTime(1980, 1, 1);
        DateTime endDate = new DateTime(1995, 12, 31);
        double minSalary = 2000;

        // We can call the CountQualifiedEmployees method to find the number of employees that meet the criteria
        int qualifiedEmployeeCount = CountQualifiedEmployees(employees, startDate, endDate, minSalary);

        // Print the result to the console
        Console.WriteLine($"Number of employees meeting the specified criteria: {qualifiedEmployeeCount}");
    }

    // Method to find the number of employees meeting the specified criteria
    static int CountQualifiedEmployees(List<Employee> employees, DateTime startDate, DateTime endDate, double minSalary)
    {
        int count = 0;

        foreach (var employee in employees)
        {
            // Check employees whose birthdate is within the specified range and salary is greater than the specified minimum
            if (employee.Birthday >= startDate && employee.Birthday <= endDate && employee.Salary > minSalary)
            {
                count++;
            }
        }

        return count;
    }
}

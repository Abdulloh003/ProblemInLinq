﻿List<Employee> employees = new List<Employee>
{
    new Employee { Name = "Alice", Department = "Sales", Salary = 50000},
    new Employee { Name = "Bob", Department = "IT", Salary = 60000 },
    new Employee { Name = "Charlie", Department = "Sales", Salary = 55000 },
    new Employee { Name = "Dave", Department = "IT", Salary = 65000 },
    new Employee { Name = "Eve", Department = "HR", Salary = 45000 }
};

var Department = from e in employees
    group e by e.Department into g
    select new
    {
        Department = g.Key,
        AverageSalary = g.Average(e => e.Salary)
    };
foreach (var VARIABLE in Department)
{
    Console.WriteLine(VARIABLE);
}
class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }

    public Employee()
    {
        
    }
}
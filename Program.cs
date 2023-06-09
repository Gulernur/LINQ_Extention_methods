﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class Program
    {
        public static void Main(String[] args)
        {
            List<Employee> employees = new List<Employee>() 
            {
                new Employee { Name = "Güler", Department = "Sales", Salary = 50000.00m },
                new Employee { Name = "Chris", Department = "Marketing", Salary = 45000.00m },
                new Employee { Name = "Lasse", Department = "Sales", Salary = 60000.00m },
                new Employee { Name = "David", Department = "Sales", Salary = 55000.00m },
                new Employee { Name = "Troels", Department = "Marketing", Salary = 40000.00m },
                new Employee { Name = "Kenneth", Department = "Sales", Salary = 70000.00m },
                new Employee { Name = "Maja", Department = "Sales", Salary = 65000.00m },
                new Employee { Name = "Victor", Department = "Marketing", Salary = 42000.00m },
                new Employee { Name = "Niels", Department = "Sales", Salary = 55000.00m },
                new Employee { Name = "Markus", Department = "Sales", Salary = 48000.00m },
            };

            //Where method. 
            var salesEmployees = employees.Where(e => e.Department == "Sales");

            //OrderBy method & ThenBy method. 
            var sortedEmployees = salesEmployees.OrderBy(e => e.Salary).ThenBy(e => e.Name);

            //First employee in the list. 
            var firstEmployee = sortedEmployees.First();
            Console.WriteLine("First employee: {0} ({1}, {2:C})", firstEmployee.Name, firstEmployee.Department, firstEmployee.Salary);

            //Last employee in the list. 
            var lastEmployee = sortedEmployees.Last(); 
            Console.WriteLine("Last employee: {0} ({1}, {2:C})", lastEmployee.Name, lastEmployee.Department, lastEmployee.Salary);

            //Count method. 
            var count = sortedEmployees.Count();
            Console.WriteLine("Number of employees: {0}", count);

            //Min method. 
            var minSalary = sortedEmployees.Min(e => e.Salary);
            Console.WriteLine("Minimum salary: {0:C}", minSalary);

            //Max method. 
            var maxSalary = sortedEmployees.Max(e => e.Salary);
            Console.WriteLine("Maximum salary: {0:C}", maxSalary); 

            Console.ReadLine(); 

        }
    }


    public class Employee
    {
        public string? Name {get; set;}
        public string? Department {get; set;}
        public decimal Salary {get; set;}
    }
}

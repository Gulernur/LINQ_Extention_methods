using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class Program
    {
        public static void Main(String[] args)
        {
            List<Employee> employees = new List<Employee>(); 
            {
                new Employee { Name = "Alice", Department = "Sales", Salary = 50000.00m }; 
                new Employee { Name = "Bob", Department = "Marketing", Salary = 45000.00m };
                new Employee { Name = "Charlie", Department = "Sales", Salary = 60000.00m };
                new Employee { Name = "Dave", Department = "Sales", Salary = 55000.00m };
                new Employee { Name = "Eve", Department = "Marketing", Salary = 40000.00m };
                new Employee { Name = "Frank", Department = "Sales", Salary = 70000.00m };
                new Employee { Name = "Grace", Department = "Sales", Salary = 65000.00m };
                new Employee { Name = "Henry", Department = "Marketing", Salary = 42000.00m };
                new Employee { Name = "Isabelle", Department = "Sales", Salary = 55000.00m };
                new Employee { Name = "Jack", Department = "Sales", Salary = 48000.00m };
            }

            //Where method. 
            var salesEmployees = employees.Where(e => e.Department == "Sales");


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

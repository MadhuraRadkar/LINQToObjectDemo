﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObjectDemo
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Salary { get;set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>()
            {
                new Employee { Id = 1,Name="Rohan",City="Pune",Salary=25000},
                new Employee { Id = 2,Name="Raj",City="Mumbai",Salary=28000},
                new Employee { Id = 3,Name="Meera",City="Delhi",Salary=35000},
                new Employee { Id = 4,Name="Siya",City="Pune",Salary=18000},
                new Employee { Id = 5,Name="Pooja",City="Parli",Salary=32000},
                new Employee { Id = 6,Name="Aarti",City="Ambajogai",Salary=45000},
                new Employee { Id = 7,Name="Priti",City="Pune",Salary=30000},
                new Employee { Id = 8,Name="Neha",City="Parli",Salary=25000},
                new Employee { Id = 9,Name="Sanket",City="Mumbai",Salary=24000},
                new Employee { Id = 10,Name="satyam",City="Pune",Salary=32000}
                
            };


            // Linq 
            var result = from e in Employees
                         where e.City == "Pune"
                         select e;


            //foreach (Employee item in result)
            //{
            //    Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            //}


            var result2 = from e in Employees
                          where e.Name.StartsWith("P")
                          select e;


            //foreach (Employee item in result2)
            //{
            //    Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            //}


            var result3 = from e in Employees
                          where e.Salary > 24000 && e.City == "Pune"
                          select e;


            //foreach (Employee item in result3)
            //{
            //    Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            //}



            //Lambda Expression.
            //var result4 = Employees.Where(x => x.City == "Mumbai").ToList();
            //var result4 = Employees.Where(x => x.City == "Pune").OrderBy(x => x.Salary).ToList();
            //foreach (Employee item in result4)
            //{
            //    Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            //}

        }
    }
}

﻿using Linqer.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Linqer.Clauses
{
    public class GroupingClauses
    {
        private readonly List<Employee> Employees;

        public GroupingClauses()
        {
            var provider = new DataProvider();
            Employees = provider.GenerateEmployee();
        }
        public void GroupByInQuerySyntax()
        {
            var groups = from em in Employees
                         group em by em.EmployeeTypeId; // Groping by EmployeeTypeId
            foreach (var group in groups)
            {
                var counter = 0;
                Console.WriteLine($"Group Key: {group.Key}");
                foreach (var employee in group)
                {
                    Console.WriteLine($"{counter + 1}. Employee Name: {employee.Name}, Salary: {employee.Salary}");
                }
                Console.WriteLine("*********************");
            }
        }
        public void GroupByInMethodSyntax()
        {
            var groups = Employees.GroupBy(m => m.EmployeeTypeId); // Groping by EmployeeTypeId

            foreach (var group in groups)
            {
                var counter = 0;
                Console.WriteLine($"Group Key: {group.Key}");
                foreach (var employee in group)
                {
                    Console.WriteLine($"{counter + 1}. Employee Name: {employee.Name}, Salary: {employee.Salary}");
                }
                Console.WriteLine("*********************");
            }
        }

        // ToLookup is the same as GroupBy; the only difference is GroupBy execution is deferred, whereas ToLookup execution is immediate.
        public void ToLookupInMethodSyntax()
        {
            var groups = Employees.ToLookup(m => m.EmployeeTypeId); // Groping by EmployeeTypeId

            foreach (var group in groups)
            {
                var counter = 0;
                Console.WriteLine($"Group Key: {group.Key}");
                foreach (var employee in group)
                {
                    Console.WriteLine($"{counter + 1}. Employee Name: {employee.Name}, Salary: {employee.Salary}");
                }
                Console.WriteLine("*********************");
            }
        }
    }
}

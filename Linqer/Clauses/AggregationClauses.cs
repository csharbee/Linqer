﻿using Linqer.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linqer.Clauses
{
    public class AggregationClauses
    {
        private readonly List<Employee> Employees;
        private readonly List<EmployeeComparable> EmployeeComparables;

        public AggregationClauses()
        {
            var provider = new DataProvider();
            Employees = provider.GenerateEmployee();
            EmployeeComparables = provider.GenerateEmployeesComparable();
        }
        /// <summary>
        /// Performs a custom aggregation operation on the values in the collection.
        /// </summary>
        public void AggregateMethod()
        {
            var commaSeperatedEmployeeNames = Employees.Aggregate<Employee, string, string>
                                                ("Employee Names: ", (str, em) => str += em.Name + ",",
                                                                     str => str.Substring(0, str.Length - 1));

            Console.WriteLine(commaSeperatedEmployeeNames);
        }

        public void CountMethod()
        {
            var employeeCount = Employees.Count();
            Console.WriteLine($"Employee Count: {employeeCount}");

            var employeeeCountGreaterThanThreeThousandSalary = Employees.Count(m => m.Salary > 3000);
            Console.WriteLine("Employee Count Greater Than $ 3000 : {0}", employeeeCountGreaterThanThreeThousandSalary);
        }
        public void AverageMethod()
        {
            var avgSalary = Employees.Average(m => m.Salary);
            Console.WriteLine($"Average Employees' Salary: {avgSalary}");
        }
        public void MaxMethod()
        {
            var maxSalary = Employees.Max(m => m.Salary);
            Console.WriteLine($"Maximum Salary: {maxSalary}");
        }
        public void MaxMethodWithCollection()
        {
            var maxNamedEmployee = EmployeeComparables.Max(); //  if collection is not implement IComparable interface, you will encounter to runtime error.
            Console.WriteLine(maxNamedEmployee.Name);
        }

        public void SumMethod()
        {
            var sumOfSalary = Employees.Sum(m => m.Salary);
            Console.WriteLine($"Total Salary in a month: {sumOfSalary}");
        }
        public void ZipMethod()
        {
            var salaries = Employees.Select(m => m.Salary);
            var updatedSalaries = UpdateSalary(salaries);

            var zipList = salaries.Zip(updatedSalaries, (oldSalary, newSalary) => (oldSalary, newSalary));

            foreach (var item in zipList)
            {
                Console.WriteLine($"Old Salary: {item.oldSalary} -> New Salary: {item.newSalary}");
            }

        }
        private IEnumerable<int> UpdateSalary(IEnumerable<int> salaries)
        {
            return salaries.Select(m => m = m + (m * 2) / 10);
        }
    }
}

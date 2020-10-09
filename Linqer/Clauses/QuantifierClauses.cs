using Linqer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linqer.Clauses
{
    public class QuantifierClauses
    {
        ////  Quantifier operators are Not Supported with C# query syntax. 

        private readonly List<Employee> Employees;
        private static int MinimumWage => 100;
        private static int MaxSalary => 7500;

        public QuantifierClauses()
        {
            var provider = new DataProvider();
            Employees = provider.GenerateEmployee();
        }
        public void AllMethod()
        {
            var areEmployeesSalaryGreaterThanMinWage = Employees.All(em => em.Salary > MinimumWage); // return bool
            if (areEmployeesSalaryGreaterThanMinWage)
                Console.WriteLine("All Employees' Salary are greater than minimum wage!");
            else
                Console.WriteLine("All Employees' Salary are not greater than minimum wage!");
        }
        public void AnyMethod()
        {
            var isAnyEmployeeSalaryGreaterThanMaxSalary = Employees.Any(em => em.Salary >= MaxSalary); // return bool
            if (isAnyEmployeeSalaryGreaterThanMaxSalary)
                Console.WriteLine("There is some employee who has salary greater than maximum salary value!");
            else
                Console.WriteLine("There is no employee who has salary greater than maximum salary value!");
        }
    }
}

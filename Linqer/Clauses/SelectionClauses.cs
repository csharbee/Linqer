using Linqer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linqer.Clauses
{
    public class SelectionClauses
    {
        private readonly List<Employee> Employees;
        public SelectionClauses()
        {
            var provider = new DataProvider();
            Employees = provider.GenerateEmployee();
        }

        public void SelectAnonymousTypeInQuerySyntax()
        {
            var employeesWithAnnualSalary = from em in Employees
                                            select new { EmployeeName = em.Name, AnnualSalary = em.Salary * 12 };
            foreach (var employee in employeesWithAnnualSalary)
            {
                Console.WriteLine($"Employee Name: {employee.EmployeeName}, Annual Salary: {employee.AnnualSalary}");
            }
        }
        public void SelectAnonymousTypeInMethodSyntax()
        {
            var employeesWithAnnualSalary = Employees.Select(em => new { EmployeeName = em.Name, AnnualSalary = em.Salary * 12 });

            foreach (var employee in employeesWithAnnualSalary)
            {
                Console.WriteLine($"Employee Name: {employee.EmployeeName}, Annual Salary: {employee.AnnualSalary}");
            }
        }
        public void SelectCollectionTypeInMethodSyntax()
        {
            var employeesWithAnnualSalary = Employees.Select(em =>
            {
                em.Salary = em.Salary + (em.Salary * 8) / 100; // IMPORTANT: We are changing current value.
                                                               // If you don't want to do this, You can create new Employee list and assign it to current list.
                return em;  // We are increasing our employees salary :)
            });

            foreach (var employee in employeesWithAnnualSalary)
            {
                Console.WriteLine($"Employee Name: {employee.Name}, New Salary: {employee.Salary}");
            }
        }

    }
}

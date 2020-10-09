using Linqer.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Linqer.Clauses
{
    public class SortingClauses
    {
        private readonly List<Employee> Employees;

        public SortingClauses()
        {
            var provider = new DataProvider();
            Employees = provider.GenerateEmployee();
        }
        public void OrderByInQuerySynax()
        {
            var employeesInOrder = from em in Employees
                                   orderby em.Salary
                                   select em;
            foreach (var employee in employeesInOrder)
            {
                Console.WriteLine("Employee Name: {0}, Salary: {1}", employee.Name, employee.Salary);
            }
        }
        public void OrderByInMethodSynax()
        {
            var employeesInOrder = Employees.OrderBy(m => m.Salary);

            foreach (var employee in employeesInOrder)
            {
                Console.WriteLine("Employee Name: {0}, Salary: {1}", employee.Name, employee.Salary);
            }
        }
        public void OrderByDescendingInQuerySynax()
        {
            var employeesInOrder = from em in Employees
                                   orderby em.Salary descending
                                   select em;
            foreach (var employee in employeesInOrder)
            {
                Console.WriteLine("Employee Name: {0}, Salary: {1}", employee.Name, employee.Salary);
            }
        }
        public void OrderByDescendingInMethodSynax()
        {
            var employeesInOrder = Employees.OrderByDescending(m => m.Salary);

            foreach (var employee in employeesInOrder)
            {
                Console.WriteLine("Employee Name: {0}, Salary: {1}", employee.Name, employee.Salary);
            }
        }
        /// <summary>
        ///  ThenBy allows you to multiple sorting
        /// </summary>
        public void ThenByInMethodSynax()
        {
            var employeesInOrder = Employees.OrderBy(m => m.Salary).ThenBy(m => m.Name);

            foreach (var employee in employeesInOrder)
            {
                Console.WriteLine("Employee Name: {0}, Salary: {1}", employee.Name, employee.Salary);
            }
        }
        public void ThenByDescendingInMethodSynax()
        {
            var employeesInOrder = Employees.OrderBy(m => m.Salary).ThenByDescending(m => m.Name);

            foreach (var employee in employeesInOrder)
            {
                Console.WriteLine("Employee Name: {0}, Salary: {1}", employee.Name, employee.Salary);
            }
        }
    }
}

using Linqer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linqer.Clauses
{
    public class ConcatinationClause
    {
        private readonly List<Employee> Employees;
        public ConcatinationClause()
        {
            var provider = new DataProvider();
            Employees = provider.GenerateEmployee();
        }
        public void ConcatMethod()
        {
            var newEmp = new List<Employee>() {
                                        new Employee() { Id = 124, EmployeeTypeId = 1, Name = "Merry", LastName = "Born", Salary = 3000 },
                                        new Employee() { Id = 125, EmployeeTypeId = 2, Name = "John", LastName = "Sweat", Salary = 4500} };
            var allEmployee = Employees.Concat(newEmp);
            foreach (var employee in allEmployee)
            {
                Console.WriteLine($"Employee Name: {employee.Name}");
            }
        }
    }
}

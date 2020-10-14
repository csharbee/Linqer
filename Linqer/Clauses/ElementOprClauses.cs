using Linqer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linqer.Clauses
{
    public class ElementOprClauses
    {
        private readonly List<Employee> Employees;
        public ElementOprClauses()
        {
            var provider = new DataProvider();
            Employees = provider.GenerateEmployee();
        }
        public void ElementAtMethod()
        {
            var secondIndexedEmployee = Employees.ElementAt(1); // As you know, index numbers begin 0
            Console.WriteLine("Second Indexed Employee Name: {0}, Salary: {1}", secondIndexedEmployee.Name, secondIndexedEmployee.Salary);
        }
        public void ElementOrDefaultAtMethod()
        {
            var employee = Employees.ElementAtOrDefault(40); // There is no element indexed with 40. So if you use ElementAt method, you will encounter runtime error.
            if (employee != null)
            {
                Console.WriteLine("Employee: {0}", employee.Name);
            }
        }
        public void FirstMethod()
        {
            var employee = Employees.First(m => m.Salary > 3000); // return first item in collection that satisfies the condition. If there is not any item, you will encounter run time error. 
            Console.WriteLine("Employee Name: {0}", employee.Name);
        }
    }
}

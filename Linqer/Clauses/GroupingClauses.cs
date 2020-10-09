using Linqer.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Linqer.Clauses
{
    public class GroupingClauses
    {
        private List<Employee> Employees { get; set; }

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
                Console.WriteLine("Group Key: {0}", group.Key);
                foreach (var employee in group)
                {
                    Console.WriteLine("{0}. Employee Name: {1}, Salary: {2}", counter + 1, employee.Name, employee.Salary);
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
                Console.WriteLine("Group Key: {0}", group.Key);
                foreach (var employee in group)
                {
                    Console.WriteLine("{0}. Employee Name: {1}, Salary: {2}", counter + 1, employee.Name, employee.Salary);
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
                Console.WriteLine("Group Key: {0}", group.Key);
                foreach (var employee in group)
                {
                    Console.WriteLine("{0}. Employee Name: {1}, Salary: {2}", counter + 1, employee.Name, employee.Salary);
                }
                Console.WriteLine("*********************");
            }
        }
    }
}

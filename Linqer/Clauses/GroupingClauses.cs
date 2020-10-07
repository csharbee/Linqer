using Linqer.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Linqer.Clauses
{
    public class GroupingClauses
    {
        private DataProvider provider { get; set; }
        public GroupingClauses()
        {
            provider = new DataProvider();
        }
        public void GroupByInQuerySyntax()
        {
            var groups = from em in provider.GenerateEmployee()
                         group em by em.EmployeeTypeId;
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

using Linqer.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linqer
{
    public class OfTypeClause
    {
        private ArrayList MixedArray { get; set; }
        public OfTypeClause()
        {
            MixedArray = new ArrayList();
            MixedArray.Add(1);
            MixedArray.Add("Huseyin");
            MixedArray.Add(new Employee() { Id = 100, Name = "Krech", EmployeeTypeId = 1, Salary = 3445 });
            MixedArray.Add(1.3);
        }
        public void OfTypeMethodInQuerySyntax()
        {
            var empleyeesInMixedArray = from em in MixedArray.OfType<Employee>()
                                        select em;
            foreach (var employee in empleyeesInMixedArray)
            {
                Console.WriteLine("Name: {0}, Salary: {1}", employee.Name,employee.Salary);
            }
        }
    }
}

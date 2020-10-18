using Linqer.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Linqer.Clauses
{
    public class EqualityClause
    {
        private readonly List<Employee> Employees;
        private readonly List<Employee> newEmployeeList;
        public EqualityClause()
        {
            var provider = new DataProvider();
            Employees = provider.GenerateEmployee();
            newEmployeeList = new List<Employee>()
            {
                new Employee(){ Id=10,  Name="Test", LastName="Test", EmployeeTypeId=1, Salary=3400  },
                new Employee(){ Id=15,  Name="Test2", LastName="Test2", EmployeeTypeId=2, Salary=4500  }
            };
        }
        public void SequenceEqual()
        {
            var isEqualSequence = Employees.SequenceEqual(newEmployeeList);
            if (isEqualSequence)
            {
                Console.WriteLine("Two sequences are equal!");
            }
            else
            {
                Console.WriteLine("Two sequnces are not equal!");
            }
        }
    }
}

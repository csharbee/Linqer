using Linqer.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

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
            var areEqualSequence = Employees.SequenceEqual(newEmployeeList);
            if (areEqualSequence)
            {
                Console.WriteLine("Two sequences are equal!");
            }
            else
            {
                Console.WriteLine("Two sequnces are not equal!");
            }
        }
        public void SequenceEqualForReferenceTypes()
        {
            // To compare the values of two collection of complex type(reference type or object), you need to implement IEqualityComperar < T > interface
            // You can see EmployeeComparer class
            var list = new List<Employee>();
            list.Add(new Employee() { Id = 1, Name = "Huseyin", LastName = "Simsek", EmployeeTypeId = 1, Salary = 8000 }); // index : 0
            list.Add(new Employee() { Id = 2, Name = "John", LastName = "Doe", EmployeeTypeId = 2, Salary = 2000 });
            list.Add(new Employee() { Id = 3, Name = "Marry", LastName = "Carter", EmployeeTypeId = 3, Salary = 3500 });
            list.Add(new Employee() { Id = 4, Name = "Taylor", LastName = "Smith", EmployeeTypeId = 1, Salary = 4000 });
            list.Add(new Employee() { Id = 4, Name = "Joe", LastName = "Smith", EmployeeTypeId = 1, Salary = 4000 });

            var areEqualSequence = Employees.SequenceEqual(list, new EmployeeComparer());
            if (areEqualSequence)
            {
                Console.WriteLine("Two sequences are equal!");
            }
            else
            {
                Console.WriteLine("Two sequnces are not equal!");
            }
        }
    }
    public class EmployeeComparer : IEqualityComparer<Employee>
    {

        public bool Equals([AllowNull] Employee x, [AllowNull] Employee y)
        {
            if (x.Id == y.Id && x.Name == y.Name && x.LastName == y.LastName && x.EmployeeTypeId == y.EmployeeTypeId)
            {
                return true;
            }
            return false;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.GetHashCode();
        }
    }
}

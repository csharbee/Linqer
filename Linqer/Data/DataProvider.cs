﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Linqer.Data
{
    public class DataProvider
    {
        public List<Employee> GenerateEmployee()
        {
            var list = new List<Employee>();
            list.Add(new Employee() { Id = 1, Name = "Huseyin", LastName = "Simsek", EmployeeTypeId = 1, Salary = 8000 }); // index : 0
            list.Add(new Employee() { Id = 2, Name = "John", LastName = "Doe", EmployeeTypeId = 2, Salary = 2000 });
            list.Add(new Employee() { Id = 3, Name = "Marry", LastName = "Carter", EmployeeTypeId = 3, Salary = 3500 });
            list.Add(new Employee() { Id = 4, Name = "Taylor", LastName = "Smith", EmployeeTypeId = 1, Salary = 4000 });
            list.Add(new Employee() { Id = 4, Name = "Joe", LastName = "Smith", EmployeeTypeId = 1, Salary = 4000 }); // added multiple sorting example. You can see difference in sorting clauses
            return list;
        }
        public List<EmployeeType> GenerateEmployeeTypes()
        {
            var list = new List<EmployeeType>();
            list.Add(new EmployeeType() { Id = 1, Name = "CTO" });
            list.Add(new EmployeeType() { Id = 2, Name = "Software Developer" });
            list.Add(new EmployeeType() { Id = 3, Name = "Software Architecture" });
            return list;
        }
        public List<EmployeeComparable> GenerateEmployeesComparable()
        {
            var list = new List<EmployeeComparable>();
            list.Add(new EmployeeComparable() { Id = 1, Name = "Huseyin", LastName = "Simsek", EmployeeTypeId = 1, Salary = 8000 }); // index : 0
            list.Add(new EmployeeComparable() { Id = 2, Name = "John", LastName = "Doe", EmployeeTypeId = 2, Salary = 2000 });
            list.Add(new EmployeeComparable() { Id = 3, Name = "Marry", LastName = "Carter", EmployeeTypeId = 3, Salary = 3500 });
            list.Add(new EmployeeComparable() { Id = 4, Name = "Taylor", LastName = "Smith", EmployeeTypeId = 1, Salary = 4000 });
            list.Add(new EmployeeComparable() { Id = 4, Name = "Joe", LastName = "Smith", EmployeeTypeId = 1, Salary = 4000 }); // added multiple sorting example. You can see difference in sorting clauses
            return list;
        }
    }
}

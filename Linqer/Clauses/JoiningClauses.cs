﻿using Linqer.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linqer.Clauses
{
    public class JoiningClauses
    {
        private readonly List<Employee> Employees;
        private readonly List<EmployeeType> EmployeeTypes;

        public JoiningClauses()
        {
            var provider = new DataProvider();
            Employees = provider.GenerateEmployee();
            EmployeeTypes = provider.GenerateEmployeeTypes();
        }
        public void JoinInQuerySyntax()
        {
            var employeesDetail = from em in Employees
                                  join et in EmployeeTypes
                                  on em.EmployeeTypeId equals et.Id
                                  select new { Name = em.Name, EmployeeTypeName = et.Name };
            foreach (var employee in employeesDetail)
            {
                Console.WriteLine($"Employee Name: {employee.Name}, Employee Type Name: {employee.EmployeeTypeName}");
            }
        }
        public void JoinInMethodSyntax()
        {
            var employeesDetail = Employees.Join(                // outer sequence
                                        EmployeeTypes,           // inner sequence
                                        em => em.EmployeeTypeId, // outerKeySelector
                                        et => et.Id,             // innerKeySelector
                                        (employee, employeeDetail) => new // resultSelector
                                        {
                                            Name = employee.Name,
                                            EmployeeTypeName = employeeDetail.Name
                                        }
                                    );
            foreach (var employee in employeesDetail)
            {
                Console.WriteLine($"Employee Name: {employee.Name}, Employee Type Name: {employee.EmployeeTypeName}");
            }
        }

    }
}

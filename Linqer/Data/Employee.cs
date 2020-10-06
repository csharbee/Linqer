using System;
using System.Collections.Generic;
using System.Text;

namespace Linqer.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public int EmployeeTypeId { get; set; }
    }
}

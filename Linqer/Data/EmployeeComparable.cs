using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Linqer.Data
{
    public class EmployeeComparable : IComparable<EmployeeComparable>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public int EmployeeTypeId { get; set; }

        public int CompareTo([AllowNull] EmployeeComparable other)
        {
            if (this.Name.Length >= other.Name.Length)
                return 1;
            return 0;
        }
    }
}

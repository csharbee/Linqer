using Linqer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linqer.Clauses
{
    public class AggregationClauses
    {
        private readonly List<Employee> Employees;
        public AggregationClauses()
        {
            var provider = new DataProvider();
            Employees = provider.GenerateEmployee();
        }
        /// <summary>
        /// Performs a custom aggregation operation on the values in the collection.
        /// </summary>
        public void AggregateMethod()
        {

            var commaSeperatedEmployeeNames = Employees.Aggregate<Employee, string, string>("Employee Names: ", (str, em) => str += em.Name + ",",
                                                                                                                    str => str.Substring(0, str.Length - 1));  // s1 = s1+s2;

            Console.WriteLine(commaSeperatedEmployeeNames);
        }
    }
}

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
            IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };

            var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);

            Console.WriteLine(commaSeperatedString); 
        }
    }
}

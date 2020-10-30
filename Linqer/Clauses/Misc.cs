using Linqer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linqer.Clauses
{
    public class Misc
    {
        public void DefaultIfEmptyMethod()
        {
            var emp = new List<Employee>();
            var listOfEmployee = emp.DefaultIfEmpty();
            Console.WriteLine($"Employee List Count: {listOfEmployee.Count()}");
        }
    }
}

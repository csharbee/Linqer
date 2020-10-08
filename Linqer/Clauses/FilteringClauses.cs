using Linqer.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linqer.Clauses
{
    public class FilteringClauses
    {
        private DataProvider _dataProvider { get; set; }
        private ArrayList MixedArray { get; set; }

        public FilteringClauses()
        {
            _dataProvider = new DataProvider();

            MixedArray = new ArrayList();
            MixedArray.Add(1);
            MixedArray.Add("Huseyin");
            MixedArray.Add(new Employee() { Id = 100, Name = "Krech", EmployeeTypeId = 1, Salary = 3445 });
            MixedArray.Add(1.3);
        }
        public void WhereFirstOverloadInQuerySyntax()
        {
            var employees = from em in _dataProvider.GenerateEmployee()
                            where em.Salary > 3000
                            select em;

            foreach (var employee in employees)
            {
                Console.WriteLine("Employee Name: {0}, Salary: {1}", employee.Name, employee.Salary);
            }
        }

        /// <summary>
        /// public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
        /// </summary>
        public void WhereFirstOverloadInMethodSyntax()
        {
            var employees = _dataProvider.GenerateEmployee().Where(m => m.Salary > 3000);

            foreach (var employee in employees)
            {
                Console.WriteLine("Employee Name: {0}, Salary: {1}", employee.Name, employee.Salary);
            }
        }

        /// <summary>
        ///  public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate);
        ///  Return Even Index Items
        /// </summary>
        public void WhereSecondOverloadInMethodSyntax()
        {
            // i index, m object
            var employees = _dataProvider.GenerateEmployee().Where((m, i) =>
            {
                if (i % 2 == 0)
                {
                    return true;
                }
                return false;
            });

            foreach (var employee in employees)
            {
                Console.WriteLine("Employee Name: {0}, Salary: {1}", employee.Name, employee.Salary);
            }
        }

        public void OfTypeMethodInQuerySyntax()
        {
            var empleyeesInMixedArray = from em in MixedArray.OfType<Employee>()
                                        select em;
            foreach (var employee in empleyeesInMixedArray)
            {
                Console.WriteLine("Name: {0}, Salary: {1}", employee.Name, employee.Salary);
            }
        }
    }
}

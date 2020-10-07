using Linqer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linqer
{
    public class WhereClause
    {
        private DataProvider _dataProvider { get; set; }
        public WhereClause()
        {
            _dataProvider = new DataProvider();
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

    }
}

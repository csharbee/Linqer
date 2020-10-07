using Linqer.Clauses;
using System;

namespace Linqer
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Where and OfType methods are filter methods.
            var whereClause = new WhereClause();
            whereClause.WhereFirstOverloadInQuerySyntax();    // 1- Where filter in query syntax  
            whereClause.WhereFirstOverloadInMethodSyntax();   // 2- Where filter in method (lambda) syntax
            whereClause.WhereSecondOverloadInMethodSyntax();  // 3- Another overload where filter method (using index) in method syntax

            var ofTypeClause = new OfTypeClause();
            ofTypeClause.OfTypeMethodInQuerySyntax();         // 4- OfType is a filter method which filter specific type in mixed type collection 

            //// Sorting Methods
            var sortingClause = new SortingClauses();
            sortingClause.OrderByInQuerySynax();              // 5-  Order By collection in query syntax
            sortingClause.OrderByInMethodSynax();             // 6-  Order By collection in method syntax
            sortingClause.OrderByDescendingInQuerySynax();    // 7-  Order By Descending collection in query syntax
            sortingClause.OrderByDescendingInMethodSynax();   // 8-  Order By Descending collection in method syntax
            sortingClause.ThenByInMethodSynax();              // 9-  Multiple ordering collection in method syntax
            sortingClause.ThenByDescendingInMethodSynax();    // 10- ThenByDescending method allows you to multiple descending ordering collection
        }
    }
}

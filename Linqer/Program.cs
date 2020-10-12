using Linqer.Clauses;
using System;

namespace Linqer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Filtering Methods
            var filterClause = new FilteringClauses();
            filterClause.WhereFirstOverloadInQuerySyntax();    // 1- Where filter in query syntax  
            filterClause.WhereFirstOverloadInMethodSyntax();   // 2- Where filter in method (lambda) syntax
            filterClause.WhereSecondOverloadInMethodSyntax();  // 3- Another overload where filter method (using index) in method syntax

            filterClause.OfTypeMethodInQuerySyntax();         // 4- OfType is a filter method which filter specific type in mixed type collection 

            //// Sorting Methods
            var sortingClause = new SortingClauses();
            sortingClause.OrderByInQuerySynax();              // 5-  Order By collection in query syntax
            sortingClause.OrderByInMethodSynax();             // 6-  Order By collection in method syntax
            sortingClause.OrderByDescendingInQuerySynax();    // 7-  Order By Descending collection in query syntax
            sortingClause.OrderByDescendingInMethodSynax();   // 8-  Order By Descending collection in method syntax
            sortingClause.ThenByInMethodSynax();              // 9-  Multiple ordering collection in method syntax
            sortingClause.ThenByDescendingInMethodSynax();    // 10- ThenByDescending method allows you to multiple descending ordering collection

            //// Grouping Methods
            var groupByClauses = new GroupingClauses();
            groupByClauses.GroupByInQuerySyntax();            // 11- Group By collection according to a property, Then returns grouping collection
            groupByClauses.GroupByInMethodSyntax();           // 12- Similar to 11. Using method syntax
            groupByClauses.ToLookupInMethodSyntax();          // 13- ToLookup is the same as GroupBy; the only difference is GroupBy execution is deferred, whereas ToLookup execution is immediate.

            //// Joining Methods
            var joiningClause = new JoiningClauses();
            joiningClause.JoinInQuerySyntax();               // 14- Join two collections according to same property and select new joined collection by query syntax
            joiningClause.JoinInMethodSyntax();              // 15- Join two collections according to same property and select new joined collection by method syntax

            //// Selection Methods
            var selectionClause = new SelectionClauses();
            selectionClause.SelectAnonymousTypeInQuerySyntax();   // 16- Select new anonymous type collection in following collection in query syntax
            selectionClause.SelectAnonymousTypeInMethodSyntax();  // 17- Select new anonymous type collection in following collection in method syntax
            selectionClause.SelectCollectionTypeInMethodSyntax(); // 18- Select some value or some same collection in following collection in method syntax

            //// Quentifier Methods
            var quentifierClause = new QuantifierClauses();
            quentifierClause.AllMethod();                       // 19- Checks if all the elements in a sequence satisfies the specified condition 
            quentifierClause.ContainsMethod();                  // 20- Checks if the sequence contains a specific element
            quentifierClause.AnyMethod();                       // 21- Checks if any of the elements in a sequence satisfies the specified condition

            //// Aggregate Methods
            var aggreageClause = new AggregationClauses();
            aggreageClause.AggregateMethod();                   // 22- Performs a custom aggregation operation on the values in the collection. 
            aggreageClause.CountMethod();                       // 23- Counts the elements in a collection.
        }
    }
}

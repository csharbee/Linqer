﻿using Linqer.Clauses;
using System;

namespace Linqer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tutorial Resource : https://www.tutorialsteacher.com/linq/linq-tutorials 

            // Filtering Methods
            //var filterClause = new FilteringClauses();
            //filterClause.WhereFirstOverloadInQuerySyntax();    // 1- Where filter in query syntax  
            //filterClause.WhereFirstOverloadInMethodSyntax();   // 2- Where filter in method (lambda) syntax
            //filterClause.WhereSecondOverloadInMethodSyntax();  // 3- Another overload where filter method (using index) in method syntax

            //filterClause.OfTypeMethodInQuerySyntax();         // 4- OfType is a filter method which filter specific type in mixed type collection 

            ////// Sorting Methods
            //var sortingClause = new SortingClauses();
            //sortingClause.OrderByInQuerySynax();              // 5-  Order By collection in query syntax
            //sortingClause.OrderByInMethodSynax();             // 6-  Order By collection in method syntax
            //sortingClause.OrderByDescendingInQuerySynax();    // 7-  Order By Descending collection in query syntax
            //sortingClause.OrderByDescendingInMethodSynax();   // 8-  Order By Descending collection in method syntax
            //sortingClause.ThenByInMethodSynax();              // 9-  Multiple ordering collection in method syntax
            //sortingClause.ThenByDescendingInMethodSynax();    // 10- ThenByDescending method allows you to multiple descending ordering collection

            ////// Grouping Methods
            //var groupByClauses = new GroupingClauses();
            //groupByClauses.GroupByInQuerySyntax();            // 11- Group By collection according to a property, Then returns grouping collection
            //groupByClauses.GroupByInMethodSyntax();           // 12- Similar to 11. Using method syntax
            //groupByClauses.ToLookupInMethodSyntax();          // 13- ToLookup is the same as GroupBy; the only difference is GroupBy execution is deferred, whereas ToLookup execution is immediate.

            ////// Joining Methods
            //var joiningClause = new JoiningClauses();
            //joiningClause.JoinInQuerySyntax();               // 14- Join two collections according to same property and select new joined collection by query syntax
            //joiningClause.JoinInMethodSyntax();              // 15- Join two collections according to same property and select new joined collection by method syntax

            ////// Selection Methods
            //var selectionClause = new SelectionClauses();
            //selectionClause.SelectAnonymousTypeInQuerySyntax();   // 16- Select new anonymous type collection in following collection in query syntax
            //selectionClause.SelectAnonymousTypeInMethodSyntax();  // 17- Select new anonymous type collection in following collection in method syntax
            //selectionClause.SelectCollectionTypeInMethodSyntax(); // 18- Select some value or some same collection in following collection in method syntax

            ////// Quentifier Methods
            //var quentifierClause = new QuantifierClauses();
            //quentifierClause.AllMethod();                       // 19- Checks if all the elements in a sequence satisfies the specified condition 
            //quentifierClause.ContainsMethod();                  // 20- Checks if the sequence contains a specific element
            //quentifierClause.AnyMethod();                       // 21- Checks if any of the elements in a sequence satisfies the specified condition

            //// Aggregate Methods
            //var aggreageClause = new AggregationClauses();
            //aggreageClause.AggregateMethod();                   // 22- Performs a custom aggregation operation on the values in the collection. 
            //aggreageClause.CountMethod();                       // 23- Counts the elements in a collection.
            //aggreageClause.AverageMethod();                     // 24- Average method performs average of integer values in the collection.
            //aggreageClause.MaxMethod();                         // 25- Max method with integer value
            //aggreageClause.MaxMethodWithCollection();           // 26- Max method with a collection object that in IComparable implemented collection
            //aggreageClause.SumMethod();                         // 27- Calculate the sum of selected numerical value in the collection
            //aggreageClause.ZipMethod();

            ////// ElementOperation Methods
            //var elementOprClause = new ElementOprClauses();
            //elementOprClause.ElementAtMethod();                 // 28- Returns the element at a specified index in a collection
            //elementOprClause.ElementOrDefaultAtMethod();        // 29- Returns the element at a specified index in a collection or a default value if the index is out of range.
            //elementOprClause.FirstMethod();                     // 30- Returns the first element of a collection, or the first element that satisfies a condition.
            //elementOprClause.FirstOrDefaultMethod();            // 31- Returns the first element of a collection, or the first element that satisfies a condition. Returns a default value if index is out of range. 
            //elementOprClause.LastMethod();                      // 32- Returns the last element of a collection, or the last element that satisfies a condition 
            //elementOprClause.LastOrDefaultMethod();             // 33- Returns the last element of a collection, or the last element that satisfies a condition. Returns a default value if no such element exists. 
            //elementOprClause.SingleMethod();                    // 34- Returns the only element of a collection, or the only element that satisfies a condition. 
            //elementOprClause.SingleOrDefaultMethod();           // 35- Returns the only element of a collection, or the only element that satisfies a condition. Returns a default value if no such element exists or the collection does not contain exactly one element. 

            ////// Equality Methods
            //var equalityClause = new EqualityClause();
            //equalityClause.SequenceEqual();
            //equalityClause.SequenceEqualForReferenceTypes();

            //// Concatination Method
            //var concatClause = new ConcatinationClause();
            //concatClause.ConcatMethod();
            var misc = new Misc();
            misc.DefaultIfEmptyMethod();
            misc.EmptyMethod();
        }
    }
}

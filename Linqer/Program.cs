using System;

namespace Linqer
{
    class Program
    {
        static void Main(string[] args)
        {
            var whereClause = new WhereClause();
            whereClause.WhereFirstOverloadByQuerySyntax();
            whereClause.WhereFirstOverloadByMethodSyntax();
            // with index
            whereClause.WhereSecondOverloadByMethodSyntax();

        }
    }
}

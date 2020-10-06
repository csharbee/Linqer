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
            whereClause.WhereSecondOverloadByMethodSyntax();

            var ofTypeClause = new OfTypeClause();
            ofTypeClause.OfTypeMethodByQuerySyntax();
        }
    }
}

using System;

namespace DefaultLiteralExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            // before
            Func<string, bool> whereClause1 = default(Func<string, bool>);

            // in 7.1
            Func<string, bool> whereClause2 = default;
        }
    }
}

using System;

namespace NullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;

            // Will not raise Null ref exception
            Console.WriteLine(s[0]);
        }
    }
}

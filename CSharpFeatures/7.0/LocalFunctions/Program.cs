using System;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalFunction();

            void LocalFunction() => Console.WriteLine("Local");
        }
    }
}

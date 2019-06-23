using System;

namespace OutVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "1";

            if (int.TryParse(input, out var result))
                Console.WriteLine(result);
            else
                Console.WriteLine("Could not parse input");
        }
    }
}

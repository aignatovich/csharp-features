using System;

namespace ThrowExpression
{
    class Program
    {
        private string name;

        public void Throw() => throw new Exception();

        public string Name
        {
            get => name;
            set => name = value ??
                throw new ArgumentNullException(paramName: nameof(value), message: "Name cannot be null");
        }

        static void Main(string[] args)
        {
        }

        private static void DisplayFirstNumber(string[] args)
        {
            string arg = args.Length >= 1 ? args[0] :
                                       throw new ArgumentException("You must supply an argument");
            if (Int64.TryParse(arg, out var number))
                Console.WriteLine($"You entered {number:F0}");
            else
                Console.WriteLine($"{arg} is not a number.");

        }
    }
}

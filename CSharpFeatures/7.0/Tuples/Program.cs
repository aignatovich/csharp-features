using System;

namespace Tuples
{
    public class Point
    {
        public Point(double x, double y)
            => (X, Y) = (x, y);

        public double X { get; }
        public double Y { get; }

        public void Deconstruct(out double x, out double y) =>
            (x, y) = (X, Y);
    }

    class Program
    {
        static void Main(string[] args)
        {
            (string Alpha, string Beta) namedLetters = ("a", "b");
            Console.WriteLine($"{namedLetters.Alpha}, {namedLetters.Beta}");

            var alphabetStart = (Alpha: "a", Beta: "b");
            Console.WriteLine($"{alphabetStart.Alpha}, {alphabetStart.Beta}");

            var p = new Point(3.14, 2.71);
            (double X, double Y) = p;
        }
    }
}

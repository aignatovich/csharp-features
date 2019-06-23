using System;

namespace ExpressionBodiedMembers
{
    class Program
    {
        static void Main(string[] args) { }
    }

    public class ExpressionMembersExample
    {
        // Expression-bodied constructor
        public ExpressionMembersExample(string label) => this.Label = label;

        // Expression-bodied finalizer
        ~ExpressionMembersExample() => Console.Error.WriteLine("Finalized!");

        private string label;

        // Expression-bodied get / set accessors.
        public string Label
        {
            get => label;
            set => this.label = value ?? "Default label";
        }
    }
}

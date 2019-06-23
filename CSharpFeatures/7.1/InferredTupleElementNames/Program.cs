using System;

namespace InferredTupleElementNames
{
    class Program
    {
        static void Main(string[] args)
        {
            // in 7.0
            int count = 5;
            string label = "Colors used in the map";
            var pair = (count: count, label: label);

            // in 7.1
            pair = (count, label); // element names are "count" and "label"
        }
    }
}

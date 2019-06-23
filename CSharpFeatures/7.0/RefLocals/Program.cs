using System;

namespace RefLocals
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            ref var item = ref Find(matrix, (val) => val == 8);

            Console.WriteLine(item);
            item = 24;
            Console.WriteLine(matrix[3, 1]);
        }

        public static ref int Find(int[,] matrix, Func<int, bool> predicate)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (predicate(matrix[i, j]))
                        return ref matrix[i, j];

            throw new InvalidOperationException("Not found");
        }
    }
}
